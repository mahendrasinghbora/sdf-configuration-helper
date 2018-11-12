Imports System.IO

Public Class FormDeployProject
    Dim Role As String

    Private Sub FormDeployProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="SDF | Deploy the Project")   ' Form Styles
        PanelSDF.Size = New Size(1000, 45)
        PanelSDF.BackColor = Color.FromArgb(36, 41, 46)   ' Top Panel Color
        LabelSDF.ForeColor = Color.FromArgb(255, 255, 255)
        LabelSDF.Size = New Size(1000, 60)
        LabelSDF.Text = "Step #6- Deploy the Project"
        LabelProjectPath.Text = "Project Path"
        LabelProjectPath.BackColor = Color.FromArgb(0)
        LabelEmail.Text = "NetSuite E-mail Address"
        LabelEmail.BackColor = Color.FromArgb(0)
        LabelAccount.Text = "NetSuite Account ID"
        LabelAccount.BackColor = Color.FromArgb(0)
        LabelURL.Text = "NetSuite Account URL"
        LabelURL.BackColor = Color.FromArgb(0)
        ButtonDeployProject.Text = "Deploy Project"
        ButtonDeployProject.FlatAppearance.BorderColor = Color.FromArgb(40, 167, 69)
        ButtonDeployProject.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 167, 69)
        ButtonDeployProject.ForeColor = Color.FromArgb(40, 167, 69)
        TextBoxAccount.ReadOnly = True
        TextBoxEmail.ReadOnly = True
        TextBoxURL.ReadOnly = True
        TextBoxProjectPath.ReadOnly = True
        ButtonPrev.FlatAppearance.BorderColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.ForeColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.Text = "Previous Step"
        MessageBox.Show(text:="Before deploying the project make sure that you have generated an authentication token.", caption:="Warning!", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Warning)
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\SDFConfigurationHelper\sdf_config.txt") Then
            Dim Data(4) As String
            Dim Count = 0
            For Each Line In File.ReadLines(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\SDFConfigurationHelper\sdf_config.txt")
                Data(Count) = Line
                Count += 1
            Next
            TextBoxAccount.Text = Data(0)
            TextBoxEmail.Text = Data(1)
            Role = Data(2)
            TextBoxURL.Text = Data(3)
        Else
            MessageBox.Show(text:="Please add user information before deploying the project.", caption:="User information not found!", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        End If
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\SDFConfigurationHelper\git_config.txt") Then
            Dim Data(3) As String
            Dim Count = 0
            For Each Line In File.ReadLines(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\SDFConfigurationHelper\git_config.txt")
                Data(Count) = Line
                Count += 1
            Next
            TextBoxProjectPath.Text = Data(2)
        Else
            MessageBox.Show(text:="No project found to deploy. Make sure that you have cloned the project repository.", caption:="No project to deploy!", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        End If
        If TextBoxAccount.Text <> "" And TextBoxEmail.Text <> "" And TextBoxProjectPath.Text <> "" And TextBoxURL.Text <> "" Then
            ButtonDeployProject.Enabled = True
        Else
            ButtonDeployProject.Enabled = False
        End If
    End Sub

    Private Sub ButtonDeployProject_MouseEnter(sender As Object, e As EventArgs) Handles ButtonDeployProject.MouseEnter
        ButtonDeployProject.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonDeployProject_MouseLeave(sender As Object, e As EventArgs) Handles ButtonDeployProject.MouseLeave
        ButtonDeployProject.ForeColor = Color.FromArgb(red:=40, green:=167, blue:=69)
    End Sub

    Private Sub ButtonDeployProject_Click(sender As Object, e As EventArgs)
        Dim Command = $"cmd.exe /k echo YES | sdfcli deploy -account {TextBoxAccount.Text} -email {TextBoxEmail.Text} -p ""{TextBoxProjectPath.Text}"" -role {Role} -url {TextBoxURL.Text} -np && exit"
        Shell(Command)
        MessageBox.Show(text:="Project successfully deployed to NetSuite.", caption:="Success alert!", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonPrev_MouseEnter(sender As Object, e As EventArgs) Handles ButtonPrev.MouseEnter
        ButtonPrev.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonPrev_MouseLeave(sender As Object, e As EventArgs) Handles ButtonPrev.MouseLeave
        ButtonPrev.ForeColor = Color.FromArgb(52, 58, 64)
    End Sub

    Private Sub ButtonPrev_Click(sender As Object, e As EventArgs) Handles ButtonPrev.Click
        FormGenerateToken.Show()
        Dispose()
    End Sub
End Class