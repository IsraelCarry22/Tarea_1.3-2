Imports System.Text.RegularExpressions

Public Class Form1

    Private Personas As ArrayList = New ArrayList()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TsbGuardar_Click(sender As Object, e As EventArgs) Handles TsbGuardar.Click
        If txtNombres.Text = "" Then
            ErrorProvider1.SetError(txtNombres, "Nombres no ingresados")
            txtNombres.Focus()
            Return
        End If

        ErrorProvider1.SetError(txtNombres, "")

        If txtApellidoPaterno.Text = "" Then
            ErrorProvider1.SetError(txtApellidoPaterno, "Apellido no ingresados")
            txtNombres.Focus()
            Return
        End If

        ErrorProvider1.SetError(txtApellidoPaterno, "")

        If txtApellidoMaterno.Text = "" Then
            ErrorProvider1.SetError(txtApellidoMaterno, "Apellido no ingresados")
            txtNombres.Focus()
            Return
        End If

        ErrorProvider1.SetError(txtApellidoMaterno, "")
        Dim regemailo As Regex = New Regex("^(([^<>()[\]\\.,;:\s@\""]+" & "(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@" & "((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}" & "\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+" & "[]" & "[a-zA-Z]{2,}))$", RegexOptions.Compiled)

        If Not regemailo.IsMatch(txtGmail.Text) Then
            ErrorProvider1.SetError(txtGmail, "Gmail no es valida")
            txtNombres.Focus()
            Return
        End If

        ErrorProvider1.SetError(txtGmail, "")

        If txtTelefono.Text = "" Then
            ErrorProvider1.SetError(txtTelefono, "Telefono no es valido")
            txtNombres.Focus()
            Return
        End If

        ErrorProvider1.SetError(txtTelefono, "")
        Dim mipersona As Person = New Person()
        mipersona.Nombre = txtNombres.Text
        mipersona.Apellido_Paterno = txtApellidoPaterno.Text
        mipersona.Apellido_Materno = txtApellidoMaterno.Text
        mipersona.Fecha_Cumpleaños = dtpFechadenacimiento.Value
        mipersona.Correo = TxtGmail.Text
        mipersona.Telefono = txtTelefono.Text
        Personas.Add(mipersona)
        DgvDatos.DataSource = Nothing
        DgvDatos.DataSource = Personas
        txtNombres.Clear()
        txtApellidoPaterno.Clear()
        txtApellidoMaterno.Clear()
        txtTelefono.Clear()
        txtGmail.Clear()
        txtNombres.Focus()
    End Sub

End Class