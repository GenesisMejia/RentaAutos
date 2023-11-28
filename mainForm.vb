Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        VerificaPermisos()

        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        loginForm.MdiParent = Me
        PanelPrincipal.Controls.Add(loginForm)
        loginForm.Show()

        loginForm.WindowState = FormWindowState.Maximized

        LabelTop.Text = "Acceso al sistema"
    End Sub

    Public Sub VerificaPermisos()
        Dim da As New OleDb.OleDbDataAdapter("select * from usuario", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then

            da = New OleDb.OleDbDataAdapter("select * from usuario where id=" & lbIdUsuario.Text, Conexion)
            ds = New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim fila As DataRow
                For Each fila In ds.Tables(0).Rows
                    btnClientes.Enabled = fila("REGISTRO_CLIENTES")
                    btnVehiculos.Enabled = fila("REGISTRO_VEHICULOS")
                    btnRentar.Enabled = fila("RENTAR")
                    btnDevolver.Enabled = fila("DEVOLVER")
                    btnReportes.Enabled = fila("REPORTES")
                    btnUsuarios.Enabled = fila("REGISTRO_USUARIOS")
                    btnSistema.Enabled = fila("SISTEMA")
                Next
            Else
                btnClientes.Enabled = False
                btnVehiculos.Enabled = False
                btnRentar.Enabled = False
                btnDevolver.Enabled = False
                btnReportes.Enabled = False
                btnUsuarios.Enabled = False
                btnSistema.Enabled = False

            End If

        Else
            btnClientes.Enabled = False
            btnVehiculos.Enabled = False
            btnRentar.Enabled = False
            btnDevolver.Enabled = False
            btnReportes.Enabled = False
            btnUsuarios.Enabled = True
            btnSistema.Enabled = False
        End If

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        clienteForm.MdiParent = Me
        PanelPrincipal.Controls.Add(clienteForm)
        clienteForm.Show()

        clienteForm.WindowState = FormWindowState.Maximized

        LabelTop.Text = "Registro de clientes"
    End Sub

    Private Sub btnVehiculos_Click(sender As Object, e As EventArgs) Handles btnVehiculos.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        vehiculoForm.MdiParent = Me
        PanelPrincipal.Controls.Add(vehiculoForm)
        vehiculoForm.Show()

        vehiculoForm.WindowState = FormWindowState.Maximized

        LabelTop.Text = "Registro de vehículos"
    End Sub

    Private Sub btnRentar_Click(sender As Object, e As EventArgs) Handles btnRentar.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        rentarForm.MdiParent = Me
        PanelPrincipal.Controls.Add(rentarForm)
        rentarForm.Show()

        rentarForm.WindowState = FormWindowState.Maximized

        LabelTop.Text = "Formulario de renta"
    End Sub

    Private Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btnDevolver.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        devolverForm.MdiParent = Me
        PanelPrincipal.Controls.Add(devolverForm)
        devolverForm.Show()

        devolverForm.WindowState = FormWindowState.Maximized

        LabelTop.Text = "Devolución de vehículo rentado"
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        reporteForm.MdiParent = Me
        PanelPrincipal.Controls.Add(reporteForm)
        reporteForm.Show()

        reporteForm.WindowState = FormWindowState.Maximized

        LabelTop.Text = "Historial vehículos rentados"
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        usuarioForm.MdiParent = Me
        PanelPrincipal.Controls.Add(usuarioForm)
        usuarioForm.Show()

        usuarioForm.WindowState = FormWindowState.Maximized

        LabelTop.Text = "Registro de usuarios"
    End Sub

    Private Sub btnSistema_Click(sender As Object, e As EventArgs) Handles btnSistema.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        sistemaForm.MdiParent = Me
        PanelPrincipal.Controls.Add(sistemaForm)
        sistemaForm.Show()

        sistemaForm.WindowState = FormWindowState.Maximized

        LabelTop.Text = "Parámetros del sistema"
    End Sub

    Private Sub btnSesion_Click(sender As Object, e As EventArgs) Handles btnSesion.Click
        If MessageBox.Show("¿Seguro que desea salir de esta sesión?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            lbIdUsuario.Text = "0"
            VerificaPermisos()

            My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())

            loginForm.MdiParent = Me
            PanelPrincipal.Controls.Add(loginForm)
            loginForm.Show()

            loginForm.WindowState = FormWindowState.Maximized

            LabelTop.Text = "Acceso al sistema"

            loginForm.txtUsuario.Focus()



        End If
    End Sub

    Private Sub mainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Para que los formularios ajusten el tamaño al cambiar el tamaño del mainForm

        clienteForm.WindowState = FormWindowState.Normal : clienteForm.WindowState = FormWindowState.Maximized
        vehiculoForm.WindowState = FormWindowState.Normal : vehiculoForm.WindowState = FormWindowState.Maximized
        usuarioForm.WindowState = FormWindowState.Normal : usuarioForm.WindowState = FormWindowState.Maximized
        sistemaForm.WindowState = FormWindowState.Normal : sistemaForm.WindowState = FormWindowState.Maximized
        rentarForm.WindowState = FormWindowState.Normal : rentarForm.WindowState = FormWindowState.Maximized
        devolverForm.WindowState = FormWindowState.Normal : devolverForm.WindowState = FormWindowState.Maximized
        reporteForm.WindowState = FormWindowState.Normal : reporteForm.WindowState = FormWindowState.Maximized
        loginForm.WindowState = FormWindowState.Normal : loginForm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PanelPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles PanelPrincipal.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
