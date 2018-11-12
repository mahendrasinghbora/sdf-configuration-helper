Public Class SDFConfigurationHelper
    Private Sub SDFConfigurationHelper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="SDF | SuiteCloud Development Framework Configuration Helper")   ' Form Styles
        PanelSDF.Size = New Size(1000, 45)
        PanelSDF.BackColor = Color.FromArgb(36, 41, 46)   ' Top Panel Color
        LabelSDF.ForeColor = Color.FromArgb(255, 255, 255)
        LabelSDF.Size = New Size(1000, 60)
        LabelSDF.Text = "SuiteCloud Development Framework Configuration Helper"
        PanelSteps.Size = New Size(600, 450)
        PanelSteps.BackColor = Color.FromArgb(255, 255, 255)
        PictureBoxSDF.BackColor = Color.FromArgb(0)
        LabelStep1.ForeColor = Color.FromArgb(123, 139, 142)
        LabelStep1.Text = "Add Java to the PATH"
        PictureBoxCheck1.BackColor = Color.FromArgb(0)
        LabelStep2.ForeColor = Color.FromArgb(123, 139, 142)
        LabelStep2.Text = "Add NetSuite certificate to keytool"
        PictureBoxCheck2.BackColor = Color.FromArgb(0)
        LabelStep3.ForeColor = Color.FromArgb(123, 139, 142)
        LabelStep3.Text = "Create a file to store user information"
        PictureBoxCheck3.BackColor = Color.FromArgb(0)
        LabelStep4.ForeColor = Color.FromArgb(123, 139, 142)
        LabelStep4.Text = "Generate an authentication token"
        PictureBoxCheck5.BackColor = Color.FromArgb(0)
        LabelStep5.ForeColor = Color.FromArgb(123, 139, 142)
        LabelStep5.Text = "Deploy the Project"
        PictureBoxCheck6.BackColor = Color.FromArgb(0)
        LabelStep6.ForeColor = Color.FromArgb(123, 139, 142)
        LabelStep6.Text = "Clone the Project Repository"
        PictureBoxCheck4.BackColor = Color.FromArgb(0)
        ButtonSDF.FlatAppearance.BorderColor = Color.FromArgb(40, 167, 69)
        ButtonSDF.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 167, 69)
        ButtonSDF.ForeColor = Color.FromArgb(40, 167, 69)
        ButtonSDF.Text = "Get Started"
    End Sub

    Private Sub ButtonSDF_MouseEnter(sender As Object, e As EventArgs) Handles ButtonSDF.MouseEnter
        ButtonSDF.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub ButtonSDF_MouseLeave(sender As Object, e As EventArgs) Handles ButtonSDF.MouseLeave
        ButtonSDF.ForeColor = Color.FromArgb(40, 167, 69)
    End Sub

    Private Sub ButtonSDF_Click(sender As Object, e As EventArgs) Handles ButtonSDF.Click
        FormCloneProject.Show()
    End Sub

    Private Sub LabelStep1_MouseEnter(sender As Object, e As EventArgs) Handles LabelStep1.MouseEnter
        LabelStep1.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub LabelStep1_MouseLeave(sender As Object, e As EventArgs) Handles LabelStep1.MouseLeave
        LabelStep1.ForeColor = Color.FromArgb(123, 139, 142)
    End Sub

    Private Sub LabelStep2_MouseEnter(sender As Object, e As EventArgs) Handles LabelStep2.MouseEnter
        LabelStep2.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub LabelStep2_MouseLeave(sender As Object, e As EventArgs) Handles LabelStep2.MouseLeave
        LabelStep2.ForeColor = Color.FromArgb(123, 139, 142)
    End Sub

    Private Sub LabelStep3_MouseEnter(sender As Object, e As EventArgs) Handles LabelStep3.MouseEnter
        LabelStep3.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub LabelStep3_MouseLeave(sender As Object, e As EventArgs) Handles LabelStep3.MouseLeave
        LabelStep3.ForeColor = Color.FromArgb(123, 139, 142)
    End Sub

    Private Sub LabelStep4_MouseEnter(sender As Object, e As EventArgs) Handles LabelStep4.MouseEnter
        LabelStep4.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub LabelStep4_MouseLeave(sender As Object, e As EventArgs) Handles LabelStep4.MouseLeave
        LabelStep4.ForeColor = Color.FromArgb(123, 139, 142)
    End Sub

    Private Sub LabelStep5_MouseEnter(sender As Object, e As EventArgs) Handles LabelStep5.MouseEnter
        LabelStep5.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub LabelStep5_MouseLeave(sender As Object, e As EventArgs) Handles LabelStep5.MouseLeave
        LabelStep5.ForeColor = Color.FromArgb(123, 139, 142)
    End Sub

    Private Sub LabelStep6_MouseEnter(sender As Object, e As EventArgs) Handles LabelStep6.MouseEnter
        LabelStep6.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub LabelStep6_MouseLeave(sender As Object, e As EventArgs) Handles LabelStep6.MouseLeave
        LabelStep6.ForeColor = Color.FromArgb(123, 139, 142)
    End Sub

    Private Sub LabelStep1_Click(sender As Object, e As EventArgs) Handles LabelStep1.Click
        FormAddJava.Show()
    End Sub

    Private Sub LabelStep2_Click(sender As Object, e As EventArgs) Handles LabelStep2.Click
        FormAddCertificate.Show()
    End Sub

    Private Sub LabelStep6_Click(sender As Object, e As EventArgs) Handles LabelStep6.Click
        FormCloneProject.Show()
    End Sub

    Private Sub LabelStep3_Click(sender As Object, e As EventArgs) Handles LabelStep3.Click
        FormAddUserInformation.Show()
    End Sub

    Private Sub LabelStep4_Click(sender As Object, e As EventArgs) Handles LabelStep4.Click
        FormGenerateToken.Show()
    End Sub

    Private Sub LabelStep5_Click(sender As Object, e As EventArgs) Handles LabelStep5.Click
        FormDeployProject.Show()
    End Sub
End Class
