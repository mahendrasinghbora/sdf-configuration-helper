Imports System.IO

Public Class FormAddCertificate
    Private Sub FormAddCertificate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="SDF | Add NetSuite certificate to keytool")   ' Form Styles
        PanelSDF.Size = New Size(1000, 45)
        PanelSDF.BackColor = Color.FromArgb(36, 41, 46)   ' Top Panel Color
        LabelSDF.ForeColor = Color.FromArgb(255, 255, 255)
        LabelSDF.Size = New Size(1000, 60)
        LabelSDF.Text = "Step #3- Add NetSuite certificate to keytool"
        ButtonNext.FlatAppearance.BorderColor = Color.FromArgb(52, 58, 64)
        ButtonNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64)
        ButtonNext.ForeColor = Color.FromArgb(52, 58, 64)
        ButtonNext.Text = "Next Step"
        ButtonPrev.FlatAppearance.BorderColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.ForeColor = Color.FromArgb(52, 58, 64)
        ButtonPrev.Text = "Previous Step"
        ButtonBrowse.Text = "Browse Certificate..."
        ButtonBrowse.FlatAppearance.BorderColor = Color.FromArgb(23, 162, 184)
        ButtonBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 162, 184)
        ButtonBrowse.ForeColor = Color.FromArgb(23, 162, 184)
        TextBoxCertificate.ReadOnly = True
        ButtonCertificate.Text = "Add Certificate"
        ButtonCertificate.FlatAppearance.BorderColor = Color.FromArgb(40, 167, 69)
        ButtonCertificate.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 167, 69)
        ButtonCertificate.ForeColor = Color.FromArgb(40, 167, 69)
        ButtonCertificate.Visible = False   ' Hidden by default
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

    Private Sub ButtonBrowse_MouseEnter(sender As Object, e As EventArgs) Handles ButtonBrowse.MouseEnter
        ButtonBrowse.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonBrowse_MouseLeave(sender As Object, e As EventArgs) Handles ButtonBrowse.MouseLeave
        ButtonBrowse.ForeColor = Color.FromArgb(23, 162, 184)
    End Sub

    Private Sub ButtonPrev_Click(sender As Object, e As EventArgs) Handles ButtonPrev.Click
        FormAddJava.Show()
        Dispose()
    End Sub

    Private Sub ButtonCertificate_MouseEnter(sender As Object, e As EventArgs) Handles ButtonCertificate.MouseEnter
        ButtonCertificate.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonCertificate_MouseLeave(sender As Object, e As EventArgs) Handles ButtonCertificate.MouseLeave
        ButtonCertificate.ForeColor = Color.FromArgb(40, 167, 69)
    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        OpenFileDialogCertificate.Title = "Choose a NetSuite certificate"
        OpenFileDialogCertificate.Filter = "Certificate files (*.cer)|*.cer"
        If OpenFileDialogCertificate.ShowDialog() = DialogResult.OK Then
            TextBoxCertificate.Text = Path.GetFullPath(OpenFileDialogCertificate.FileName)
            ButtonCertificate.Visible = True
        End If
    End Sub

    Private Sub ButtonCertificate_Click(sender As Object, e As EventArgs) Handles ButtonCertificate.Click
        If LCase(TextBoxCertificate.Text).Contains(".cer") Then
            Dim Command = $"cmd.exe /k keytool -import -trustcacerts -keystore cacerts -storepass changeit -noprompt -alias deloitte -file ""{TextBoxCertificate.Text}"" && exit"
            Shell(Command)
            ButtonCertificate.Visible = False
            MessageBox.Show(text:="Certificate successfully added to keytool.", caption:="Success alert!", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Else
            MessageBox.Show(text:="The selected file is not a valid certificate.", caption:="Certificate not found!", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        FormAddUserInformation.Show()
        Dispose()
    End Sub
End Class