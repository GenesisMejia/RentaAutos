Imports System.Runtime.InteropServices

Public Class reporteForm

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        LlenarGrid()
    End Sub

    Private Sub LlenarGrid()
        Dim cadena As String = ""

        If chkCliente.Checked = True Then
            cadena = "select renta.id,renta.fecha, renta.id_cliente, renta.licencia, renta.nombre, renta.direccion, renta.telefono, renta_detalle.placa, renta_detalle.marca, renta_detalle.modelo, renta_detalle.color, renta_detalle.fabricado, renta_detalle.asientos, renta_detalle.tipo, renta_detalle.precio, renta_detalle.impuestos, renta_detalle.total, renta_detalle.rentado_desde, renta_detalle.rentado_hasta  " &
                                          "from renta_detalle inner join renta on renta_detalle.renta_id=renta.id where renta.nombre like'%" & txtBuscar.Text & "%'"
        Else
            cadena = "select renta.id,renta.fecha, renta.id_cliente, renta.licencia, renta.nombre, renta.direccion, renta.telefono, renta_detalle.placa, renta_detalle.marca, renta_detalle.modelo, renta_detalle.color, renta_detalle.fabricado, renta_detalle.asientos, renta_detalle.tipo, renta_detalle.precio, renta_detalle.impuestos, renta_detalle.total, renta_detalle.rentado_desde, renta_detalle.rentado_hasta  " &
                                             "from renta_detalle inner join renta on renta_detalle.renta_id=renta.id where  (renta.fecha between @FECHA1 AND @FECHA2)"
        End If

        Dim comando As New OleDb.OleDbCommand(cadena, Conexion)
        comando.Parameters.AddWithValue("@FECHA1", OleDb.OleDbType.Date).Value = DateTimePicker1.Value.Date
        comando.Parameters.AddWithValue("@FECHA2", OleDb.OleDbType.Date).Value = DateTimePicker2.Value.Date

        Dim da As New OleDb.OleDbDataAdapter(comando)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns("id").Visible = False
            DataGridView1.Columns("id_cliente").Visible = False
            DataGridView1.Columns("direccion").Visible = False
            DataGridView1.Columns("telefono").Visible = False
            DataGridView1.Columns("color").Visible = False
            DataGridView1.Columns("asientos").Visible = False
            DataGridView1.Columns("tipo").Visible = False


        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub

    Private Sub reporteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGrid()
        SendMessage(Me.txtBuscar.Handle, &H1501, 0, "Escriba el nombre del cliente aquí para consultar")

    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If DataGridView1.RowCount > 0 Then

            FacturaHTML.FechaRenta = DataGridView1.CurrentRow.Cells("FECHA").Value
            FacturaHTML.Factura = DataGridView1.CurrentRow.Cells("ID").Value
            FacturaHTML.NombreCliente = DataGridView1.CurrentRow.Cells("NOMBRE").Value.ToString
            FacturaHTML.IDcliente = DataGridView1.CurrentRow.Cells("ID_CLIENTE").Value
            FacturaHTML.Empleado = mainForm.lbNombreUsuario.Text
            FacturaHTML.Placa = DataGridView1.CurrentRow.Cells("PLACA").Value.ToString
            FacturaHTML.Marca = DataGridView1.CurrentRow.Cells("MARCA").Value.ToString
            FacturaHTML.Modelo = DataGridView1.CurrentRow.Cells("MODELO").Value.ToString
            FacturaHTML.Color = DataGridView1.CurrentRow.Cells("COLOR").Value.ToString
            FacturaHTML.Fabricado = DataGridView1.CurrentRow.Cells("FABRICADO").Value
            FacturaHTML.Tipo = DataGridView1.CurrentRow.Cells("TIPO").Value.ToString
            FacturaHTML.SubTotal = DataGridView1.CurrentRow.Cells("PRECIO").Value
            FacturaHTML.Impuestos = DataGridView1.CurrentRow.Cells("IMPUESTOS").Value
            FacturaHTML.Total = DataGridView1.CurrentRow.Cells("TOTAL").Value
            FacturaHTML.Desde = DataGridView1.CurrentRow.Cells("RENTADO_DESDE").Value
            FacturaHTML.Hasta = DataGridView1.CurrentRow.Cells("RENTADO_HASTA").Value

            FacturaHTML.ImpresionFisica()

        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LlenarGrid()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        LlenarGrid()
    End Sub
End Class