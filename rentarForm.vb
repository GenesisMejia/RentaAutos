Imports System.Runtime.InteropServices
Imports System.IO

Public Class rentarForm
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As DataSet

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Try
            completarForm.txtPlaca.Text = DataGridView1.CurrentRow.Cells("PLACA").Value
            completarForm.txtMarca.Text = DataGridView1.CurrentRow.Cells("MARCA").Value
            completarForm.txtModelo.Text = DataGridView1.CurrentRow.Cells("MODELO").Value
            completarForm.txtColor.Text = DataGridView1.CurrentRow.Cells("COLOR").Value
            completarForm.txtFabricado.Text = DataGridView1.CurrentRow.Cells("FABRICADO").Value
            completarForm.txtAsientos.Text = DataGridView1.CurrentRow.Cells("ASIENTOS").Value
            completarForm.txtTipo.Text = DataGridView1.CurrentRow.Cells("TIPO").Value
            completarForm.txtPrecio.Text = DataGridView1.CurrentRow.Cells("PRECIO").Value

            ' Obtener la celda "FOTO"
            Dim fotoCell As DataGridViewCell = DataGridView1.CurrentRow.Cells("FOTO")

            ' Verificar si la celda contiene una cadena o un objeto Bitmap
            If TypeOf fotoCell.Value Is String Then
                ' La celda contiene una cadena, usarla como ruta de la imagen
                Dim rutaImagen As String = DirectCast(fotoCell.Value, String)

                ' Mostrar la ruta en un MessageBox para verificar si es correcta
                MessageBox.Show("Ruta de la imagen: " & rutaImagen)

                ' Obtener la imagen desde la ruta utilizando la nueva función
                Dim imagen As Image = ObtenerImagenDesdeRuta(rutaImagen)

                ' Asignar la imagen al control picCarro en completarForm
                completarForm.picCarro.Image = imagen
            ElseIf TypeOf fotoCell.Value Is Bitmap Then
                ' La celda contiene un objeto Bitmap, intentar convertirlo a Image
                Dim bitmap As Bitmap = DirectCast(fotoCell.Value, Bitmap)
                Dim imagen As Image = DirectCast(bitmap, Image)

                ' Asignar la imagen al control picCarro en completarForm
                completarForm.picCarro.Image = imagen
            Else
                ' Tipo no manejado, mostrar un mensaje de error
                MessageBox.Show("Tipo no manejado para la celda FOTO.")
            End If

            My.Application.OpenForms.Cast(Of Form)().Except({mainForm}).ToList().ForEach(Sub(form) form.Close())

            completarForm.MdiParent = mainForm
            mainForm.PanelPrincipal.Controls.Add(completarForm)
            completarForm.Show()

            completarForm.WindowState = FormWindowState.Maximized

            mainForm.LabelTop.Text = "Completar Renta"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        LlenarGrid()
        FotoCarro()
    End Sub

    Private Sub LlenarGrid()
        Dim da As New OleDb.OleDbDataAdapter("select ID,PLACA,MARCA,MODELO,COLOR,FABRICADO,ASIENTOS,TIPO, PRECIO,FOTO, (marca & ' ' & modelo & ',' & color & ',' & fabricado) as descripcion from vehiculo where " &
            "((marca & ' ' & modelo & ' ' & color & ' ' & fabricado) like'%" & txtBuscar.Text & "%'  or " &
            "(marca & ' ' & modelo & ' ' & fabricado & ' ' & color) like'%" & txtBuscar.Text & "%'  or " &
            "(marca & ' ' & modelo & ' ' & color & ' ' & fabricado) like'%" & txtBuscar.Text & "%'  or " &
            "(tipo & ' ' & asientos & ' ' & color & ' ' & fabricado) like'%" & txtBuscar.Text & "%'  or " &
            "(asientos & ' asientos') like'%" & txtBuscar.Text & "%'  or " &
            "(marca & ' ' & color & ' ' & fabricado & ' ' & color) like'%" & txtBuscar.Text & "%' or placa like'%" & txtBuscar.Text & "%') and disponible='SI' order by asientos asc", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = ds.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub

    Private Sub FotoCarro()
        For Each fila As DataGridViewRow In DataGridView1.Rows
            Dim idVehiculo As Integer

            If Integer.TryParse(fila.Cells("ID").Value.ToString(), idVehiculo) Then
                ' Solo proceder si se puede convertir el valor de la celda "ID" a un entero

                Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM vehiculo WHERE ID = " & idVehiculo, Conexion)
                Dim ds As New DataSet
                da.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    fila.Cells("FOTO").Value = ObtenerImagenDesdeRuta(ds.Tables(0).Rows(0).Item("FOTO").ToString())
                End If
            End If
        Next
    End Sub

    Private Function ObtenerImagenDesdeRuta(rutaImagen As String) As Image
        ' Verificar si la ruta no está vacía y si el archivo realmente existe
        If Not String.IsNullOrEmpty(rutaImagen) AndAlso File.Exists(rutaImagen) Then
            ' Cargar la imagen desde el archivo y devolverla
            Return Image.FromFile(rutaImagen)
        Else
            ' Manejar el caso en que la ruta de la imagen es inválida o el archivo no existe
            Return Nothing
        End If
    End Function

    Private Sub rentarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGrid()

        SendMessage(Me.txtBuscar.Handle, &H1501, 0, "Describa el auto que busca aqui")
    End Sub

    Private Sub rentarForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ' Llamar al método FotoCarro para cargar las imágenes cuando el formulario se vuelva visible
        FotoCarro()
    End Sub





End Class