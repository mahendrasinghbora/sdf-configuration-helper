<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenerateToken
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGenerateToken))
        Me.PanelSDF = New System.Windows.Forms.Panel()
        Me.LabelSDF = New System.Windows.Forms.Label()
        Me.ButtonGenerateToken = New System.Windows.Forms.Button()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.ButtonPrev = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.PanelSDF.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSDF
        '
        Me.PanelSDF.Controls.Add(Me.LabelSDF)
        Me.PanelSDF.Location = New System.Drawing.Point(-11, 0)
        Me.PanelSDF.Name = "PanelSDF"
        Me.PanelSDF.Size = New System.Drawing.Size(1000, 66)
        Me.PanelSDF.TabIndex = 3
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
        'ButtonGenerateToken
        '
        Me.ButtonGenerateToken.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonGenerateToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGenerateToken.Font = New System.Drawing.Font("Source Sans Pro", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonGenerateToken.Location = New System.Drawing.Point(289, 374)
        Me.ButtonGenerateToken.Name = "ButtonGenerateToken"
        Me.ButtonGenerateToken.Size = New System.Drawing.Size(426, 79)
        Me.ButtonGenerateToken.TabIndex = 20
        Me.ButtonGenerateToken.Text = "Button2"
        Me.ButtonGenerateToken.UseVisualStyleBackColor = False
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelPassword.Location = New System.Drawing.Point(514, 145)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(71, 25)
        Me.LabelPassword.TabIndex = 24
        Me.LabelPassword.Text = "Label2"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPassword.Location = New System.Drawing.Point(519, 177)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(347, 33)
        Me.TextBoxPassword.TabIndex = 23
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(104, 145)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(71, 25)
        Me.LabelEmail.TabIndex = 22
        Me.LabelEmail.Text = "Label1"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxEmail.Location = New System.Drawing.Point(109, 177)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(347, 33)
        Me.TextBoxEmail.TabIndex = 21
        '
        'ButtonPrev
        '
        Me.ButtonPrev.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrev.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonPrev.Location = New System.Drawing.Point(56, 527)
        Me.ButtonPrev.Name = "ButtonPrev"
        Me.ButtonPrev.Size = New System.Drawing.Size(156, 37)
        Me.ButtonPrev.TabIndex = 26
        Me.ButtonPrev.Text = "ButtonPrev"
        Me.ButtonPrev.UseVisualStyleBackColor = False
        '
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNext.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonNext.Location = New System.Drawing.Point(766, 527)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(156, 37)
        Me.ButtonNext.TabIndex = 25
        Me.ButtonNext.Text = "ButtonNext"
        Me.ButtonNext.UseVisualStyleBackColor = False
        '
        'FormGenerateToken
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(978, 644)
        Me.Controls.Add(Me.ButtonPrev)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.ButtonGenerateToken)
        Me.Controls.Add(Me.PanelSDF)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormGenerateToken"
        Me.PanelSDF.ResumeLayout(False)
        Me.PanelSDF.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelSDF As Panel
    Friend WithEvents LabelSDF As Label
    Friend WithEvents ButtonGenerateToken As Button
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents ButtonPrev As Button
    Friend WithEvents ButtonNext As Button
End Class
