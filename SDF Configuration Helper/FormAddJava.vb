Public Class FormAddJava
    Private Sub FormAddJava_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="SDF | Add Java to the PATH")   ' Form Styles
        PanelSDF.Size = New Size(1000, 45)
        PanelSDF.BackColor = Color.FromArgb(36, 41, 46)   ' Top Panel Color
        LabelSDF.ForeColor = Color.FromArgb(255, 255, 255)
        LabelSDF.Size = New Size(1000, 60)
        LabelSDF.Text = "Step #2- Add Java to the PATH"
        FolderBrowserDialogJDK.Description = "Select the JDK folder."
        FolderBrowserDialogJDK.ShowNewFolderButton = False
        TextBoxJDK.ReadOnly = True
        ButtonAdd.Text = "Add Java to the PATH"
        ButtonAdd.FlatAppearance.BorderColor = Color.FromArgb(40, 167, 69)
        ButtonAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 167, 69)
        ButtonAdd.ForeColor = Color.FromArgb(40, 167, 69)
        ButtonAdd.Visible = False   ' Hidden by default
        ButtonBrowse.Text = "Browse Folder..."
        ButtonBrowse.FlatAppearance.BorderColor = Color.FromArgb(23, 162, 184)
        ButtonBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 162, 184)
        ButtonBrowse.ForeColor = Color.FromArgb(23, 162, 184)
        LabelInstruction.Text = "Select the JDK folder (e.g. C:\Program Files\Java\jdkX.X.X)"
        LabelInstruction.BackColor = Color.FromArgb(0)
        ButtonNext.FlatAppearance.BorderColor = Color.FromArgb(52, 58, 64)
        ButtonNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64)
        ButtonNext.ForeColor = Color.FromArgb(52, 58, 64)
        ButtonNext.Text = "Next Step"
        ButtonPrev.FlatAppearance.BorderColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.ForeColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.Text = "Previous Step"
    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        If FolderBrowserDialogJDK.ShowDialog() = DialogResult.OK Then
            TextBoxJDK.Text = FolderBrowserDialogJDK.SelectedPath()
        End If
    End Sub

    Private Sub ButtonAdd_MouseEnter(sender As Object, e As EventArgs) Handles ButtonAdd.MouseEnter
        ButtonAdd.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonAdd_MouseLeave(sender As Object, e As EventArgs) Handles ButtonAdd.MouseLeave
        ButtonAdd.ForeColor = Color.FromArgb(40, 167, 69)
    End Sub

    Private Sub ButtonBrowse_MouseEnter(sender As Object, e As EventArgs) Handles ButtonBrowse.MouseEnter
        ButtonBrowse.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonBrowse_MouseLeave(sender As Object, e As EventArgs) Handles ButtonBrowse.MouseLeave
        ButtonBrowse.ForeColor = Color.FromArgb(23, 162, 184)
    End Sub

    Private Sub ButtonNext_MouseEnter(sender As Object, e As EventArgs) Handles ButtonNext.MouseEnter
        ButtonNext.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonNext_MouseLeave(sender As Object, e As EventArgs) Handles ButtonNext.MouseLeave
        ButtonNext.ForeColor = Color.FromArgb(52, 58, 64)
    End Sub

    Private Sub TextBoxJDK_TextChanged(sender As Object, e As EventArgs) Handles TextBoxJDK.TextChanged
        ButtonAdd.Visible = True
    End Sub

    Private Sub ButtonPrev_MouseEnter(sender As Object, e As EventArgs) Handles ButtonPrev.MouseEnter
        ButtonPrev.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonPrev_MouseLeave(sender As Object, e As EventArgs) Handles ButtonPrev.MouseLeave
        ButtonPrev.ForeColor = Color.FromArgb(52, 58, 64)
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If LCase(TextBoxJDK.Text).Contains("java") And LCase(TextBoxJDK.Text).Contains("jdk") Then
            Dim Command = $"cmd.exe /k setx -m JAVA_HOME ""{FolderBrowserDialogJDK.SelectedPath}"" && setx PATH ""%JAVA_HOME%\bin;%PATH%"" /m && exit"
            Shell(Command)
            ButtonAdd.Visible = False
            MessageBox.Show(text:="Java successfully added to the PATH.", caption:="Success alert!", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Else
            ButtonAdd.Visible = False
            MessageBox.Show(text:="The selected folder doesn't contain a JDK installation.", caption:="Insallation not found!", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        FormAddCertificate.Show()
        Dispose()
    End Sub

    Private Sub ButtonPrev_Click(sender As Object, e As EventArgs) Handles ButtonPrev.Click
        FormCloneProject.Show()
        Dispose()
    End Sub
End Class