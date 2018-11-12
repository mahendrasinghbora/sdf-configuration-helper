<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCloneProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCloneProject))
        Me.LabelSDF = New System.Windows.Forms.Label()
        Me.PanelSDF = New System.Windows.Forms.Panel()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelBranch = New System.Windows.Forms.Label()
        Me.TextBoxBranch = New System.Windows.Forms.TextBox()
        Me.LabelRepositoryURL = New System.Windows.Forms.Label()
        Me.TextBoxRepositoryURL = New System.Windows.Forms.TextBox()
        Me.TextBoxClone = New System.Windows.Forms.TextBox()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.FolderBrowserDialogClone = New System.Windows.Forms.FolderBrowserDialog()
        Me.LabelInstruction = New System.Windows.Forms.Label()
        Me.ButtonClone = New System.Windows.Forms.Button()
        Me.ErrorProviderClone = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.PanelSDF.SuspendLayout()
        CType(Me.ErrorProviderClone, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TextBoxUsername
        '
        Me.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxUsername.Location = New System.Drawing.Point(108, 145)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(347, 33)
        Me.TextBoxUsername.TabIndex = 3
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelUsername.Location = New System.Drawing.Point(103, 113)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(71, 25)
        Me.LabelUsername.TabIndex = 4
        Me.LabelUsername.Text = "Label1"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(513, 113)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(71, 25)
        Me.LabelEmail.TabIndex = 6
        Me.LabelEmail.Text = "Label2"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxEmail.Location = New System.Drawing.Point(518, 145)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(347, 33)
        Me.TextBoxEmail.TabIndex = 5
        '
        'LabelBranch
        '
        Me.LabelBranch.AutoSize = True
        Me.LabelBranch.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelBranch.Location = New System.Drawing.Point(513, 233)
        Me.LabelBranch.Name = "LabelBranch"
        Me.LabelBranch.Size = New System.Drawing.Size(71, 25)
        Me.LabelBranch.TabIndex = 10
        Me.LabelBranch.Text = "Label4"
        '
        'TextBoxBranch
        '
        Me.TextBoxBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxBranch.Location = New System.Drawing.Point(518, 259)
        Me.TextBoxBranch.Name = "TextBoxBranch"
        Me.TextBoxBranch.Size = New System.Drawing.Size(347, 33)
        Me.TextBoxBranch.TabIndex = 9
        '
        'LabelRepositoryURL
        '
        Me.LabelRepositoryURL.AutoSize = True
        Me.LabelRepositoryURL.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelRepositoryURL.Location = New System.Drawing.Point(103, 233)
        Me.LabelRepositoryURL.Name = "LabelRepositoryURL"
        Me.LabelRepositoryURL.Size = New System.Drawing.Size(71, 25)
        Me.LabelRepositoryURL.TabIndex = 8
        Me.LabelRepositoryURL.Text = "Label3"
        '
        'TextBoxRepositoryURL
        '
        Me.TextBoxRepositoryURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxRepositoryURL.Font = New System.Drawing.Font("Source Sans Pro", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.TextBoxRepositoryURL.Location = New System.Drawing.Point(108, 263)
        Me.TextBoxRepositoryURL.Name = "TextBoxRepositoryURL"
        Me.TextBoxRepositoryURL.Size = New System.Drawing.Size(347, 28)
        Me.TextBoxRepositoryURL.TabIndex = 7
        '
        'TextBoxClone
        '
        Me.TextBoxClone.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxClone.Font = New System.Drawing.Font("Source Sans Pro", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.TextBoxClone.Location = New System.Drawing.Point(108, 377)
        Me.TextBoxClone.Name = "TextBoxClone"
        Me.TextBoxClone.Size = New System.Drawing.Size(571, 28)
        Me.TextBoxClone.TabIndex = 12
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBrowse.Font = New System.Drawing.Font("Source Sans Pro", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonBrowse.Location = New System.Drawing.Point(693, 373)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(172, 36)
        Me.ButtonBrowse.TabIndex = 11
        Me.ButtonBrowse.Text = "Button1"
        Me.ButtonBrowse.UseVisualStyleBackColor = False
        '
        'LabelInstruction
        '
        Me.LabelInstruction.AutoSize = True
        Me.LabelInstruction.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelInstruction.Location = New System.Drawing.Point(103, 347)
        Me.LabelInstruction.Name = "LabelInstruction"
        Me.LabelInstruction.Size = New System.Drawing.Size(158, 25)
        Me.LabelInstruction.TabIndex = 13
        Me.LabelInstruction.Text = "LabelInstruction"
        '
        'ButtonClone
        '
        Me.ButtonClone.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonClone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClone.Font = New System.Drawing.Font("Source Sans Pro", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonClone.Location = New System.Drawing.Point(357, 494)
        Me.ButtonClone.Name = "ButtonClone"
        Me.ButtonClone.Size = New System.Drawing.Size(265, 36)
        Me.ButtonClone.TabIndex = 14
        Me.ButtonClone.Text = "Button2"
        Me.ButtonClone.UseVisualStyleBackColor = False
        '
        'ErrorProviderClone
        '
        Me.ErrorProviderClone.ContainerControl = Me
        '
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNext.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonNext.Location = New System.Drawing.Point(766, 561)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(156, 37)
        Me.ButtonNext.TabIndex = 15
        Me.ButtonNext.Text = "ButtonNext"
        Me.ButtonNext.UseVisualStyleBackColor = False
        '
        'FormCloneProject
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(978, 644)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonClone)
        Me.Controls.Add(Me.LabelInstruction)
        Me.Controls.Add(Me.TextBoxClone)
        Me.Controls.Add(Me.ButtonBrowse)
        Me.Controls.Add(Me.LabelBranch)
        Me.Controls.Add(Me.TextBoxBranch)
        Me.Controls.Add(Me.LabelRepositoryURL)
        Me.Controls.Add(Me.TextBoxRepositoryURL)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.PanelSDF)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormCloneProject"
        Me.PanelSDF.ResumeLayout(False)
        Me.PanelSDF.PerformLayout()
        CType(Me.ErrorProviderClone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSDF As Label
    Friend WithEvents PanelSDF As Panel
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelBranch As Label
    Friend WithEvents TextBoxBranch As TextBox
    Friend WithEvents LabelRepositoryURL As Label
    Friend WithEvents TextBoxRepositoryURL As TextBox
    Friend WithEvents TextBoxClone As TextBox
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents FolderBrowserDialogClone As FolderBrowserDialog
    Friend WithEvents LabelInstruction As Label
    Friend WithEvents ButtonClone As Button
    Friend WithEvents ErrorProviderClone As ErrorProvider
    Friend WithEvents ButtonNext As Button
End Class
