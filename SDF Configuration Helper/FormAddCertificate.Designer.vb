<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddCertificate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddCertificate))
        Me.LabelSDF = New System.Windows.Forms.Label()
        Me.PanelSDF = New System.Windows.Forms.Panel()
        Me.OpenFileDialogCertificate = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonPrev = New System.Windows.Forms.Button()
        Me.TextBoxCertificate = New System.Windows.Forms.TextBox()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.ButtonCertificate = New System.Windows.Forms.Button()
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
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNext.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonNext.Location = New System.Drawing.Point(766, 545)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(156, 37)
        Me.ButtonNext.TabIndex = 7
        Me.ButtonNext.Text = "ButtonNext"
        Me.ButtonNext.UseVisualStyleBackColor = False
        '
        'ButtonPrev
        '
        Me.ButtonPrev.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrev.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonPrev.Location = New System.Drawing.Point(56, 545)
        Me.ButtonPrev.Name = "ButtonPrev"
        Me.ButtonPrev.Size = New System.Drawing.Size(156, 37)
        Me.ButtonPrev.TabIndex = 8
        Me.ButtonPrev.Text = "ButtonPrev"
        Me.ButtonPrev.UseVisualStyleBackColor = False
        '
        'TextBoxCertificate
        '
        Me.TextBoxCertificate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxCertificate.Font = New System.Drawing.Font("Source Sans Pro", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.TextBoxCertificate.Location = New System.Drawing.Point(139, 225)
        Me.TextBoxCertificate.Name = "TextBoxCertificate"
        Me.TextBoxCertificate.Size = New System.Drawing.Size(507, 28)
        Me.TextBoxCertificate.TabIndex = 9
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBrowse.Font = New System.Drawing.Font("Source Sans Pro", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonBrowse.Location = New System.Drawing.Point(677, 221)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(156, 36)
        Me.ButtonBrowse.TabIndex = 10
        Me.ButtonBrowse.Text = "Button1"
        Me.ButtonBrowse.UseVisualStyleBackColor = False
        '
        'ButtonCertificate
        '
        Me.ButtonCertificate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCertificate.Font = New System.Drawing.Font("Source Sans Pro", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonCertificate.Location = New System.Drawing.Point(374, 367)
        Me.ButtonCertificate.Name = "ButtonCertificate"
        Me.ButtonCertificate.Size = New System.Drawing.Size(220, 36)
        Me.ButtonCertificate.TabIndex = 11
        Me.ButtonCertificate.Text = "Button2"
        Me.ButtonCertificate.UseVisualStyleBackColor = False
        '
        'FormAddCertificate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(978, 644)
        Me.Controls.Add(Me.ButtonCertificate)
        Me.Controls.Add(Me.ButtonBrowse)
        Me.Controls.Add(Me.TextBoxCertificate)
        Me.Controls.Add(Me.ButtonPrev)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.PanelSDF)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAddCertificate"
        Me.PanelSDF.ResumeLayout(False)
        Me.PanelSDF.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSDF As Label
    Friend WithEvents PanelSDF As Panel
    Friend WithEvents OpenFileDialogCertificate As OpenFileDialog
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonPrev As Button
    Friend WithEvents TextBoxCertificate As TextBox
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents ButtonCertificate As Button
End Class
