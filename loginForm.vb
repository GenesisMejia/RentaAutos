Public Class loginForm
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim da As New OleDb.OleDbDataAdapter("select * from usuario where usuario='" & txtUsuario.Text & "' and clave='" & txtClave.Text & "'", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            mainForm.lbNombreUsuario.Text = ds.Tables(0).Rows(0).Item("usuario")
            mainForm.lbIdUsuario.Text = ds.Tables(0).Rows(0).Item("id")
            mainForm.VerificaPermisos()
            Me.Close()
        Else
            MessageBox.Show("Nombre de usuario o clave inválido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("¿Seguro que desea salir del sistema?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            End
        End If
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class