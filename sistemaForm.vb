Public Class sistemaForm
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtID.Text = "0" Then
            Dim cmd As New OleDb.OleDbCommand("insert into sistema(impuestos) values('" & txtImpuestos.Text & "')", Conexion)
            cmd.ExecuteNonQuery()
        Else
            Dim cmd As New OleDb.OleDbCommand("update sistema set  impuestos='" & txtImpuestos.Text & "' where id=" & txtID.Text, Conexion)
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub LlenarDatos()
        Dim da As New OleDb.OleDbDataAdapter("select * from sistema", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            For Each fila In ds.Tables(0).Rows
                txtID.Text = fila("ID")
                txtImpuestos.Text = fila("IMPUESTOS")
            Next
        End If
    End Sub

    Private Sub sistemaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()
    End Sub

    Private Sub txtImpuestos_Leave(sender As Object, e As EventArgs) Handles txtImpuestos.Leave
        If txtImpuestos.Text.Length = 0 Then
            txtImpuestos.Text = "0"
        End If
    End Sub
End Class