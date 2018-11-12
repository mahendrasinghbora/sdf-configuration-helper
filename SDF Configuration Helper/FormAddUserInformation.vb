Imports System.IO

Public Class FormAddUserInformation
    Private Sub FormAddUserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="SDF | Create a file to store user information")   ' Form Styles
        PanelSDF.Size = New Size(1000, 45)
        PanelSDF.BackColor = Color.FromArgb(36, 41, 46)   ' Top Panel Color
        LabelSDF.ForeColor = Color.FromArgb(255, 255, 255)
        LabelSDF.Size = New Size(1000, 60)
        LabelSDF.Text = "Step #4- Create a file to store user information"
        LabelAccount.Text = "NetSuite Account ID"
        LabelAccount.BackColor = Color.FromArgb(0)
        LabelEmail.Text = "NetSuite E-mail Address"
        LabelEmail.BackColor = Color.FromArgb(0)
        LabelRole.Text = "Internal ID of the Role"
        LabelRole.BackColor = Color.FromArgb(0)
        LabelURL.Text = "NetSuite Account URL"
        LabelURL.BackColor = Color.FromArgb(0)
        ButtonAddInformation.Text = "Add User Information"
        ButtonAddInformation.FlatAppearance.BorderColor = Color.FromArgb(40, 167, 69)
        ButtonAddInformation.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 167, 69)
        ButtonAddInformation.ForeColor = Color.FromArgb(40, 167, 69)
        ButtonAddInformation.Enabled = False   ' Disabled by default
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\SDFConfigurationHelper\sdf_config.txt") Then
            Dim Data(4) As String
            Dim Count = 0
            For Each Line In File.ReadLines(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\SDFConfigurationHelper\sdf_config.txt")
                Data(Count) = Line
                Count += 1
            Next
            TextBoxAccount.Text = Data(0)
            TextBoxEmail.Text = Data(1)
            TextBoxRole.Text = Data(2)
            TextBoxURL.Text = Data(3)
        End If
        ButtonNext.FlatAppearance.BorderColor = Color.FromArgb(52, 58, 64)
        ButtonNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64)
        ButtonNext.ForeColor = Color.FromArgb(52, 58, 64)
        ButtonNext.Text = "Next Step"
        ButtonPrev.FlatAppearance.BorderColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.ForeColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.Text = "Previous Step"
    End Sub

    Private Sub ButtonAddInformation_MouseEnter(sender As Object, e As EventArgs) Handles ButtonAddInformation.MouseEnter
        ButtonAddInformation.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonAddInformation_MouseLeave(sender As Object, e As EventArgs) Handles ButtonAddInformation.MouseLeave
        ButtonAddInformation.ForeColor = Color.FromArgb(40, 167, 69)
    End Sub

    Private Sub TextBoxAccount_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxAccount.Validating
        If TextBoxAccount.Text = "" Then
            ErrorProviderAddInformation.SetError(control:=TextBoxAccount, value:="Account ID can't be empty.")
            TextBoxAccount.Focus()
        Else
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextBoxRole_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxRole.Validating
        If TextBoxRole.Text = "" Then
            ErrorProviderAddInformation.SetError(control:=TextBoxRole, value:="Role ID can't be empty.")
            TextBoxRole.Focus()
        Else
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextBoxURL_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxURL.Validating
        If TextBoxURL.Text = "" Then
            ErrorProviderAddInformation.SetError(control:=TextBoxURL, value:="NetSuite URL can't be empty.")
            TextBoxURL.Focus()
        Else
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextBoxEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxEmail.Validating
        If Not System.Text.RegularExpressions.Regex.IsMatch(input:=TextBoxEmail.Text, pattern:="^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$") And
            TextBoxEmail.Text <> "" Then
            ErrorProviderAddInformation.SetError(control:=TextBoxEmail, value:="Please enter a valid email address.")
            TextBoxEmail.Focus()
        Else
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextBoxAccount_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAccount.TextChanged
        If TextBoxEmail.Text <> "" And TextBoxRole.Text <> "" And TextBoxURL.Text <> "" And TextBoxAccount.Text <> "" Then
            ButtonAddInformation.Enabled = True
        Else
            ButtonAddInformation.Enabled = False
        End If
    End Sub

    Private Sub TextBoxEmail_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEmail.TextChanged
        If TextBoxAccount.Text <> "" And TextBoxRole.Text <> "" And TextBoxURL.Text <> "" And TextBoxEmail.Text <> "" Then
            ButtonAddInformation.Enabled = True
        Else
            ButtonAddInformation.Enabled = False
        End If
    End Sub

    Private Sub TextBoxRole_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRole.TextChanged
        If TextBoxEmail.Text <> "" And TextBoxAccount.Text <> "" And TextBoxURL.Text <> "" And TextBoxRole.Text <> "" Then
            ButtonAddInformation.Enabled = True
        Else
            ButtonAddInformation.Enabled = False
        End If
    End Sub

    Private Sub TextBoxURL_TextChanged(sender As Object, e As EventArgs) Handles TextBoxURL.TextChanged
        If TextBoxEmail.Text <> "" And TextBoxRole.Text <> "" And TextBoxAccount.Text <> "" And TextBoxURL.Text <> "" Then
            ButtonAddInformation.Enabled = True
        Else
            ButtonAddInformation.Enabled = False
        End If
    End Sub

    Private Sub ButtonAddInformation_Click(sender As Object, e As EventArgs) Handles ButtonAddInformation.Click
        Dim Command As String
        If Not Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\SDFConfigurationHelper") Then
            Command = $"cmd.exe /k cd ""{My.Computer.FileSystem.SpecialDirectories.MyDocuments}"" && mkdir ""SDFConfigurationHelper"" && exit"
            Shell(Command)
        End If
        MessageBox.Show(text:="User information successfully stored.", caption:="Success alert!", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Dim FileContent As String = TextBoxAccount.Text + vbCrLf + TextBoxEmail.Text + vbCrLf + TextBoxRole.Text + vbCrLf + TextBoxURL.Text
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\SDFConfigurationHelper\sdf_config.txt", FileContent, False)
    End Sub

    Private Sub ButtonNext_MouseEnter(sender As Object, e As EventArgs) Handles ButtonNext.MouseEnter
        ButtonNext.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonNext_MouseLeave(sender As Object, e As EventArgs) Handles ButtonNext.MouseLeave
        ButtonNext.ForeColor = Color.FromArgb(52, 58, 64)
    End Sub

    Private Sub ButtonPrev_MouseEnter(sender As Object, e As EventArgs) Handles ButtonPrev.MouseEnter
        ButtonPrev.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonPrev_MouseLeave(sender As Object, e As EventArgs) Handles ButtonPrev.MouseLeave
        ButtonPrev.ForeColor = Color.FromArgb(52, 58, 64)
    End Sub

    Private Sub ButtonPrev_Click(sender As Object, e As EventArgs) Handles ButtonPrev.Click
        FormAddCertificate.Show()
        Dispose()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        FormGenerateToken.Show()
        Dispose()
    End Sub
End Class