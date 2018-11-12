<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddJava
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddJava))
        Me.LabelSDF = New System.Windows.Forms.Label()
        Me.PanelSDF = New System.Windows.Forms.Panel()
        Me.FolderBrowserDialogJDK = New System.Windows.Forms.FolderBrowserDialog()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.TextBoxJDK = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.LabelInstruction = New System.Windows.Forms.Label()
        Me.ButtonNext = New System.Windows.Forms.Button()
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
        Me.PanelSDF.TabIndex = 1
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBrowse.Font = New System.Drawing.Font("Source Sans Pro", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonBrowse.Location = New System.Drawing.Point(680, 205)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(156, 36)
        Me.ButtonBrowse.TabIndex = 2
        Me.ButtonBrowse.Text = "Button1"
        Me.ButtonBrowse.UseVisualStyleBackColor = False
        '
        'TextBoxJDK
        '
        Me.TextBoxJDK.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxJDK.Font = New System.Drawing.Font("Source Sans Pro", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.TextBoxJDK.Location = New System.Drawing.Point(98, 209)
        Me.TextBoxJDK.Name = "TextBoxJDK"
        Me.TextBoxJDK.Size = New System.Drawing.Size(555, 28)
        Me.TextBoxJDK.TabIndex = 3
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Font = New System.Drawing.Font("Source Sans Pro", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(324, 357)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(265, 36)
        Me.ButtonAdd.TabIndex = 4
        Me.ButtonAdd.Text = "Button2"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'LabelInstruction
        '
        Me.LabelInstruction.AutoSize = True
        Me.LabelInstruction.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelInstruction.Location = New System.Drawing.Point(92, 167)
        Me.LabelInstruction.Name = "LabelInstruction"
        Me.LabelInstruction.Size = New System.Drawing.Size(158, 25)
        Me.LabelInstruction.TabIndex = 5
        Me.LabelInstruction.Text = "LabelInstruction"
        '
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNext.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonNext.Location = New System.Drawing.Point(766, 553)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(156, 37)
        Me.ButtonNext.TabIndex = 6
        Me.ButtonNext.Text = "Button3"
        Me.ButtonNext.UseVisualStyleBackColor = False
        '
        'ButtonPrev
        '
        Me.ButtonPrev.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrev.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ButtonPrev.Location = New System.Drawing.Point(50, 553)
        Me.ButtonPrev.Name = "ButtonPrev"
        Me.ButtonPrev.Size = New System.Drawing.Size(156, 37)
        Me.ButtonPrev.TabIndex = 9
        Me.ButtonPrev.Text = "ButtonPrev"
        Me.ButtonPrev.UseVisualStyleBackColor = False
        '
        'FormAddJava
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(978, 644)
        Me.Controls.Add(Me.ButtonPrev)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.LabelInstruction)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxJDK)
        Me.Controls.Add(Me.ButtonBrowse)
        Me.Controls.Add(Me.PanelSDF)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Source Sans Pro", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAddJava"
        Me.ShowIcon = False
        Me.PanelSDF.ResumeLayout(False)
        Me.PanelSDF.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSDF As Label
    Friend WithEvents PanelSDF As Panel
    Friend WithEvents FolderBrowserDialogJDK As FolderBrowserDialog
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents TextBoxJDK As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents LabelInstruction As Label
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonPrev As Button
End Class
