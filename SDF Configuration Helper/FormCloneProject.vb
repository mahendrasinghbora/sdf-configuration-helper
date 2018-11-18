Imports System.IO

Public Class FormCloneProject
    Private Sub FormCloneProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="SDF | Clone the Project Repository")   ' Form Styles
        PanelSDF.Size = New Size(1000, 45)
        PanelSDF.BackColor = Color.FromArgb(36, 41, 46)   ' Top Panel Color
        LabelSDF.ForeColor = Color.FromArgb(255, 255, 255)
        LabelSDF.Size = New Size(1000, 60)
        LabelSDF.Text = "Step #1- Clone the Project Repository"
        ButtonBrowse.Text = "Browse Folder..."
        ButtonBrowse.FlatAppearance.BorderColor = Color.FromArgb(23, 162, 184)
        ButtonBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 162, 184)
        ButtonBrowse.ForeColor = Color.FromArgb(23, 162, 184)
        TextBoxClone.ReadOnly = True
        LabelUsername.Text = "Username"
        LabelUsername.BackColor = Color.FromArgb(0)
        LabelEmail.Text = "Github Account E-mail Address"
        LabelEmail.BackColor = Color.FromArgb(0)
        LabelRepositoryURL.Text = "Git URL (Repository)"
        LabelRepositoryURL.BackColor = Color.FromArgb(0)
        LabelBranch.Text = "Branch Name"
        LabelBranch.BackColor = Color.FromArgb(0)
        LabelInstruction.Text = "Select the Destination Folder"
        LabelInstruction.BackColor = Color.FromArgb(0)
        ButtonClone.Text = "Clone Project Repository"
        ButtonClone.FlatAppearance.BorderColor = Color.FromArgb(40, 167, 69)
        ButtonClone.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 167, 69)
        ButtonClone.ForeColor = Color.FromArgb(40, 167, 69)
        ButtonClone.Enabled = False   ' Disabled by default
        ButtonNext.FlatAppearance.BorderColor = Color.FromArgb(52, 58, 64)
        ButtonNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64)
        ButtonNext.ForeColor = Color.FromArgb(52, 58, 64)
        ButtonNext.Text = "Next Step"
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\SDFConfigurationHelper\git_config.txt") Then
            Dim Data(2) As String
            Dim Count = 0
            For Each Line In File.ReadLines(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\SDFConfigurationHelper\git_config.txt")
                Data(Count) = Line
                Count += 1
            Next
            TextBoxUsername.Text = Data(0)
            TextBoxEmail.Text = Data(1)
        End If
    End Sub

    Private Sub ButtonBrowse_MouseEnter(sender As Object, e As EventArgs) Handles ButtonBrowse.MouseEnter
        ButtonBrowse.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonBrowse_MouseLeave(sender As Object, e As EventArgs) Handles ButtonBrowse.MouseLeave
        ButtonBrowse.ForeColor = Color.FromArgb(23, 162, 184)
    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        If FolderBrowserDialogClone.ShowDialog() = DialogResult.OK Then
            TextBoxClone.Text = FolderBrowserDialogClone.SelectedPath()
        End If
    End Sub

    Private Sub TextBoxUsername_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxUsername.Validating
        If TextBoxUsername.Text = "" Then
            ErrorProviderClone.SetError(control:=TextBoxUsername, value:="Username can't be empty.")
            TextBoxUsername.Focus()
        Else
            ErrorProviderClone.Dispose()
        End If
    End Sub

    Private Sub TextBoxEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxEmail.Validating
        If Not System.Text.RegularExpressions.Regex.IsMatch(input:=TextBoxEmail.Text, pattern:="^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$") And
            TextBoxEmail.Text <> "" Then
            ErrorProviderClone.SetError(control:=TextBoxEmail, value:="Please enter a valid email address.")
            TextBoxEmail.Focus()
        Else
            ErrorProviderClone.Dispose()
        End If
    End Sub

    Private Sub TextBoxClone_TextChanged(sender As Object, e As EventArgs) Handles TextBoxClone.TextChanged
        If TextBoxUsername.Text <> "" And TextBoxEmail.Text <> "" And TextBoxRepositoryURL.Text <> "" And TextBoxBranch.Text <> "" Then
            ButtonClone.Enabled = True
        End If
    End Sub

    Private Sub TextBoxRepositoryURL_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxRepositoryURL.Validating
        If TextBoxRepositoryURL.Text = "" Then
            ErrorProviderClone.SetError(control:=TextBoxRepositoryURL, value:="Repository URL can't be empty.")
            TextBoxRepositoryURL.Focus()
        Else
            ErrorProviderClone.Dispose()
        End If
    End Sub

    Private Sub TextBoxBranch_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxBranch.Validating
        If TextBoxBranch.Text = "" Then
            ErrorProviderClone.SetError(control:=TextBoxBranch, value:="Branch name can't be empty.")
            TextBoxBranch.Focus()
        Else
            ErrorProviderClone.Dispose()
        End If
    End Sub

    Private Sub ButtonClone_MouseEnter(sender As Object, e As EventArgs) Handles ButtonClone.MouseEnter
        ButtonClone.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonClone_MouseLeave(sender As Object, e As EventArgs) Handles ButtonClone.MouseLeave
        ButtonClone.ForeColor = Color.FromArgb(40, 167, 69)
    End Sub

    Private Sub ButtonClone_Click(sender As Object, e As EventArgs) Handles ButtonClone.Click
        If LCase(TextBoxRepositoryURL.Text).Contains("https://github.com") And LCase(TextBoxRepositoryURL.Text).Contains(".git") Then
            Dim Command = $"cmd.exe /k git config --global user.email ""{TextBoxEmail.Text}"" && exit"
            Shell(Command)
            Command = $"cmd.exe /k git config --global user.name ""{TextBoxUsername.Text}"" && exit"
            Shell(Command)
            Command = $"cmd.exe /k cd ""{TextBoxClone.Text}"" && git clone -b {TextBoxBranch.Text} ""{TextBoxRepositoryURL.Text}"" && exit"
            Shell(Command)
            If Not Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\SDFConfigurationHelper") Then
                Command = $"cmd.exe /k cd ""{My.Computer.FileSystem.SpecialDirectories.MyDocuments}"" && mkdir ""SDFConfigurationHelper"" && exit"
                Shell(Command)
            End If
            Threading.Thread.Sleep(10000)
            MessageBox.Show(text:="Project Repository successfully cloned.", caption:="Success alert!", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
            Dim FileContent As String = TextBoxUsername.Text + vbCrLf + TextBoxEmail.Text + vbCrLf + TextBoxClone.Text + "\" + TextBoxRepositoryURL.Text.Substring(TextBoxRepositoryURL.Text.LastIndexOf("/") + 1, TextBoxRepositoryURL.Text.LastIndexOf(".") - TextBoxRepositoryURL.Text.LastIndexOf("/") - 1)
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\SDFConfigurationHelper\git_config.txt", FileContent, False)
        Else
            MessageBox.Show(text:="The git URL (Repository) is invalid.", caption:="Invalid URL!", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonNext_MouseEnter(sender As Object, e As EventArgs) Handles ButtonNext.MouseEnter
        ButtonNext.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonNext_MouseLeave(sender As Object, e As EventArgs) Handles ButtonNext.MouseLeave
        ButtonNext.ForeColor = Color.FromArgb(52, 58, 64)
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        FormAddJava.Show()
        Dispose()
    End Sub
End Class