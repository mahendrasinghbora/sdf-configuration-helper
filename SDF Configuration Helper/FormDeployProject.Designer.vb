<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDeployProject
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDeployProject))
        Me.LabelSDF = New System.Windows.Forms.Label()
        Me.PanelSDF = New System.Windows.Forms.Panel()
        Me.LabelURL = New System.Windows.Forms.Label()
        Me.TextBoxURL = New System.Windows.Forms.TextBox()
        Me.LabelAccount = New System.Windows.Forms.Label()
        Me.TextBoxAccount = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelProjectPath = New System.Windows.Forms.Label()
        Me.TextBoxProjectPath = New System.Windows.Forms.TextBox()
        Me.ButtonDeployProject = New System.Windows.Forms.Button()
        Me.ButtonPrev = New System.Windows.Forms.Button()
        Me.PanelSDF.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelSDF
        '
        Me.LabelSDF.AutoSize = True
        Me.LabelSDF.Font = New System.Drawing.Font("Source Sans Pro", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelSDF.Location = New System.Drawing.Point(3, 9)
        Me.LabelSDF.Name = "LabelSDF"
        Me.LabelSDF.Size = New System.Drawing.Size(77, 29)
        Me.LabelSDF.TabIndex = 0
        Me.LabelSDF.Text = "Label1"
        '
        'PanelSDF
        '
        Me.PanelSDF.Controls.Add(Me.LabelSDF)
        Me.PanelSDF.Location = New System.Drawing.Point(0, 0)
        Me.PanelSDF.Name = "PanelSDF"
        Me.PanelSDF.Size = New System.Drawing.Size(1000, 66)
        Me.PanelSDF.TabIndex = 2
        '
        'LabelURL
        '
        Me.LabelURL.AutoSize = True
        Me.LabelURL.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelURL.Location = New System.Drawing.Point(518, 291)
        Me.LabelURL.Name = "LabelURL"
        Me.LabelURL.Size = New System.Drawing.Size(71, 25)
        Me.LabelURL.TabIndex = 27
        Me.LabelURL.Text = "Label4"
        '
        'TextBoxURL
        '
        Me.TextBoxURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxURL.Location = New System.Drawing.Point(523, 317)
        Me.TextBoxURL.Name = "TextBoxURL"
        Me.TextBoxURL.Size = New System.Drawing.Size(347, 33)
        Me.TextBoxURL.TabIndex = 26
        '
        'LabelAccount
        '
        Me.LabelAccount.AutoSize = True
        Me.LabelAccount.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelAccount.Location = New System.Drawing.Point(108, 291)
        Me.LabelAccount.Name = "LabelAccount"
        Me.LabelAccount.Size = New System.Drawing.Size(71, 25)
        Me.LabelAccount.TabIndex = 25
        Me.LabelAccount.Text = "Label3"
        '
        'TextBoxAccount
        '
        Me.TextBoxAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAccount.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.TextBoxAccount.Location = New System.Drawing.Point(113, 321)
        Me.TextBoxAccount.Name = "TextBoxAccount"
        Me.TextBoxAccount.Size = New System.Drawing.Size(347, 33)
        Me.TextBoxAccount.TabIndex = 24
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(518, 149)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(71, 25)
        Me.LabelEmail.TabIndex = 23
        Me.LabelEmail.Text = "Label2"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxEmail.Location = New System.Drawing.Point(523, 181)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(347, 33)
        Me.TextBoxEmail.TabIndex = 22
        '
        'LabelProjectPath
        '
        Me.LabelProjectPath.AutoSize = True
        Me.LabelProjectPath.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelProjectPath.Location = New System.Drawing.Point(108, 149)
        Me.LabelProjectPath.Name = "LabelProjectPath"
        Me.LabelProjectPath.Size = New System.Drawing.Size(71, 25)
        Me.LabelProjectPath.TabIndex = 21
        Me.LabelProjectPath.Text = "Label1"
        '
        'TextBoxProjectPath
        '
        Me.TextBoxProjectPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxProjectPath.Font = New System.Drawing.Font("Source Sans Pro", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.TextBoxProjectPath.Location = New System.Drawing.Point(113, 181)
        Me.TextBoxProjectPath.Name = "TextBoxProjectPath"
        Me.TextBoxProjectPath.Size = New System.Drawing.Size(347, 28)
        Me.TextBoxProjectPath.TabIndex = 20
        '
        'ButtonDeployProject
        '
        Me.ButtonDeployProject.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonDeployProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeployProject.Font = New System.Drawing.Font("Source Sans Pro", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonDeployProject.Location = New System.Drawing.Point(276, 413)
        Me.ButtonDeployProject.Name = "ButtonDeployProject"
        Me.ButtonDeployProject.Size = New System.Drawing.Size(426, 79)
        Me.ButtonDeployProject.TabIndex = 28
        Me.ButtonDeployProject.Text = "Button2"
        Me.ButtonDeployProject.UseVisualStyleBackColor = False
        '
        'ButtonPrev
        '
        Me.ButtonPrev.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrev.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonPrev.Location = New System.Drawing.Point(56, 551)
        Me.ButtonPrev.Name = "ButtonPrev"
        Me.ButtonPrev.Size = New System.Drawing.Size(156, 37)
        Me.ButtonPrev.TabIndex = 30
        Me.ButtonPrev.Text = "ButtonPrev"
        Me.ButtonPrev.UseVisualStyleBackColor = False
        '
        'FormDeployProject
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(978, 644)
        Me.Controls.Add(Me.ButtonPrev)
        Me.Controls.Add(Me.ButtonDeployProject)
        Me.Controls.Add(Me.LabelURL)
        Me.Controls.Add(Me.TextBoxURL)
        Me.Controls.Add(Me.LabelAccount)
        Me.Controls.Add(Me.TextBoxAccount)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.LabelProjectPath)
        Me.Controls.Add(Me.TextBoxProjectPath)
        Me.Controls.Add(Me.PanelSDF)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDeployProject"
        Me.PanelSDF.ResumeLayout(False)
        Me.PanelSDF.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSDF As Label
    Friend WithEvents PanelSDF As Panel
    Friend WithEvents LabelURL As Label
    Friend WithEvents TextBoxURL As TextBox
    Friend WithEvents LabelAccount As Label
    Friend WithEvents TextBoxAccount As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelProjectPath As Label
    Friend WithEvents TextBoxProjectPath As TextBox
    Friend WithEvents ButtonDeployProject As Button
    Friend WithEvents ButtonPrev As Button
End Class
