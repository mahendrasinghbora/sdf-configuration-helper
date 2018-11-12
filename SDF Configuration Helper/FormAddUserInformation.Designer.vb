<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddUserInformation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddUserInformation))
        Me.LabelSDF = New System.Windows.Forms.Label()
        Me.PanelSDF = New System.Windows.Forms.Panel()
        Me.LabelURL = New System.Windows.Forms.Label()
        Me.TextBoxURL = New System.Windows.Forms.TextBox()
        Me.LabelRole = New System.Windows.Forms.Label()
        Me.TextBoxRole = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelAccount = New System.Windows.Forms.Label()
        Me.TextBoxAccount = New System.Windows.Forms.TextBox()
        Me.ButtonAddInformation = New System.Windows.Forms.Button()
        Me.ErrorProviderAddInformation = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ButtonPrev = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.PanelSDF.SuspendLayout()
        CType(Me.ErrorProviderAddInformation, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelSDF.TabIndex = 1
        '
        'LabelURL
        '
        Me.LabelURL.AutoSize = True
        Me.LabelURL.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelURL.Location = New System.Drawing.Point(515, 283)
        Me.LabelURL.Name = "LabelURL"
        Me.LabelURL.Size = New System.Drawing.Size(71, 25)
        Me.LabelURL.TabIndex = 18
        Me.LabelURL.Text = "Label4"
        '
        'TextBoxURL
        '
        Me.TextBoxURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxURL.Location = New System.Drawing.Point(520, 309)
        Me.TextBoxURL.Name = "TextBoxURL"
        Me.TextBoxURL.Size = New System.Drawing.Size(347, 33)
        Me.TextBoxURL.TabIndex = 17
        '
        'LabelRole
        '
        Me.LabelRole.AutoSize = True
        Me.LabelRole.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelRole.Location = New System.Drawing.Point(105, 283)
        Me.LabelRole.Name = "LabelRole"
        Me.LabelRole.Size = New System.Drawing.Size(71, 25)
        Me.LabelRole.TabIndex = 16
        Me.LabelRole.Text = "Label3"
        '
        'TextBoxRole
        '
        Me.TextBoxRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxRole.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.TextBoxRole.Location = New System.Drawing.Point(110, 313)
        Me.TextBoxRole.Name = "TextBoxRole"
        Me.TextBoxRole.Size = New System.Drawing.Size(347, 33)
        Me.TextBoxRole.TabIndex = 15
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(515, 141)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(71, 25)
        Me.LabelEmail.TabIndex = 14
        Me.LabelEmail.Text = "Label2"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxEmail.Location = New System.Drawing.Point(520, 173)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(347, 33)
        Me.TextBoxEmail.TabIndex = 13
        '
        'LabelAccount
        '
        Me.LabelAccount.AutoSize = True
        Me.LabelAccount.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelAccount.Location = New System.Drawing.Point(105, 141)
        Me.LabelAccount.Name = "LabelAccount"
        Me.LabelAccount.Size = New System.Drawing.Size(71, 25)
        Me.LabelAccount.TabIndex = 12
        Me.LabelAccount.Text = "Label1"
        '
        'TextBoxAccount
        '
        Me.TextBoxAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAccount.Location = New System.Drawing.Point(110, 173)
        Me.TextBoxAccount.Name = "TextBoxAccount"
        Me.TextBoxAccount.Size = New System.Drawing.Size(347, 33)
        Me.TextBoxAccount.TabIndex = 11
        '
        'ButtonAddInformation
        '
        Me.ButtonAddInformation.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAddInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddInformation.Font = New System.Drawing.Font("Source Sans Pro", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonAddInformation.Location = New System.Drawing.Point(358, 451)
        Me.ButtonAddInformation.Name = "ButtonAddInformation"
        Me.ButtonAddInformation.Size = New System.Drawing.Size(265, 36)
        Me.ButtonAddInformation.TabIndex = 19
        Me.ButtonAddInformation.Text = "Button2"
        Me.ButtonAddInformation.UseVisualStyleBackColor = False
        '
        'ErrorProviderAddInformation
        '
        Me.ErrorProviderAddInformation.ContainerControl = Me
        '
        'ButtonPrev
        '
        Me.ButtonPrev.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrev.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonPrev.Location = New System.Drawing.Point(56, 550)
        Me.ButtonPrev.Name = "ButtonPrev"
        Me.ButtonPrev.Size = New System.Drawing.Size(156, 37)
        Me.ButtonPrev.TabIndex = 21
        Me.ButtonPrev.Text = "ButtonPrev"
        Me.ButtonPrev.UseVisualStyleBackColor = False
        '
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNext.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonNext.Location = New System.Drawing.Point(766, 550)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(156, 37)
        Me.ButtonNext.TabIndex = 20
        Me.ButtonNext.Text = "ButtonNext"
        Me.ButtonNext.UseVisualStyleBackColor = False
        '
        'FormAddUserInformation
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(978, 644)
        Me.Controls.Add(Me.ButtonPrev)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonAddInformation)
        Me.Controls.Add(Me.LabelURL)
        Me.Controls.Add(Me.TextBoxURL)
        Me.Controls.Add(Me.LabelRole)
        Me.Controls.Add(Me.TextBoxRole)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.LabelAccount)
        Me.Controls.Add(Me.TextBoxAccount)
        Me.Controls.Add(Me.PanelSDF)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAddUserInformation"
        Me.PanelSDF.ResumeLayout(False)
        Me.PanelSDF.PerformLayout()
        CType(Me.ErrorProviderAddInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSDF As Label
    Friend WithEvents PanelSDF As Panel
    Friend WithEvents LabelURL As Label
    Friend WithEvents TextBoxURL As TextBox
    Friend WithEvents LabelRole As Label
    Friend WithEvents TextBoxRole As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelAccount As Label
    Friend WithEvents TextBoxAccount As TextBox
    Friend WithEvents ButtonAddInformation As Button
    Friend WithEvents ErrorProviderAddInformation As ErrorProvider
    Friend WithEvents ButtonPrev As Button
    Friend WithEvents ButtonNext As Button
End Class
