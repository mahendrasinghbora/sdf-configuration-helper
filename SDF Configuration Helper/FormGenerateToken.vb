Imports System.IO

Public Class FormGenerateToken
    Dim Account As String
    Dim Role As String
    Dim URL As String

    Private Sub FormGenerateToken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="SDF | Generate an authentication token")   ' Form Styles
        PanelSDF.Size = New Size(1000, 45)
        PanelSDF.BackColor = Color.FromArgb(36, 41, 46)   ' Top Panel Color
        LabelSDF.ForeColor = Color.FromArgb(255, 255, 255)
        LabelSDF.Size = New Size(1000, 60)
        LabelSDF.Text = "Step #5- Generate an authentication token"
        ButtonGenerateToken.Text = "Generate Token"
        ButtonGenerateToken.FlatAppearance.BorderColor = Color.FromArgb(40, 167, 69)
        ButtonGenerateToken.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 167, 69)
        ButtonGenerateToken.ForeColor = Color.FromArgb(40, 167, 69)
        LabelPassword.Text = "NetSuite Account Password"
        LabelPassword.BackColor = Color.FromArgb(0)
        LabelEmail.Text = "Netsuite Account E-mail Address"
        LabelEmail.BackColor = Color.FromArgb(0)
        TextBoxEmail.ReadOnly = True
        ButtonGenerateToken.Enabled = False   ' Disabled by default
        ButtonNext.FlatAppearance.BorderColor = Color.FromArgb(52, 58, 64)
        ButtonNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64)
        ButtonNext.ForeColor = Color.FromArgb(52, 58, 64)
        ButtonNext.Text = "Next Step"
        ButtonPrev.FlatAppearance.BorderColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.ForeColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.Text = "Previous Step"
        MessageBox.Show(text:="Before generating token, please make sure that your role has the User Access Tokens permission.", caption:="Warning!", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Warning)
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\SDFConfigurationHelper\sdf_config.txt") Then
            Dim Data(4) As String
            Dim Count = 0
            For Each Line In File.ReadLines(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\SDFConfigurationHelper\sdf_config.txt")
                Data(Count) = Line
                Count += 1
            Next
            Account = Data(0)
            TextBoxEmail.Text = Data(1)
            Role = Data(2)
            URL = Data(3)
        Else
            MessageBox.Show(text:="Please add user information before generating a token.", caption:="User information not found!", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBoxPassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged
        If TextBoxEmail.Text <> "" And TextBoxPassword.Text <> "" Then
            ButtonGenerateToken.Enabled = True
        Else
            ButtonGenerateToken.Enabled = False
        End If
    End Sub

    Private Sub ButtonGenerateToken_MouseEnter(sender As Object, e As EventArgs) Handles ButtonGenerateToken.MouseEnter
        ButtonGenerateToken.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonGenerateToken_MouseLeave(sender As Object, e As EventArgs) Handles ButtonGenerateToken.MouseLeave
        ButtonGenerateToken.ForeColor = Color.FromArgb(red:=40, green:=167, blue:=69)
    End Sub

    Private Sub ButtonGenerateToken_Click(sender As Object, e As EventArgs) Handles ButtonGenerateToken.Click
        Dim Command = $"cmd.exe /k echo {TextBoxPassword.Text} | sdfcli issuetoken -account {Account} -email {TextBoxEmail.Text} -role {Role} -url {URL} && exit"
        Shell(PathName:=Command)
        MessageBox.Show(text:="Token successfully issued.", caption:="Success alert!", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        FormDeployProject.Show()
        Dispose()
    End Sub

    Private Sub ButtonPrev_Click(sender As Object, e As EventArgs) Handles ButtonPrev.Click
        FormAddUserInformation.Show()
        Dispose()
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
End Class