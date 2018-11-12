Module Functions
    Public Sub FormStyles(CallingForm As Form, Text As String)
        CallingForm.Text = Text
        CallingForm.MinimizeBox = True
        CallingForm.MaximizeBox = False
        CallingForm.Size = New Size(1000, 700)   ' Default Size - 1000X700 px
        CallingForm.MaximumSize = New Size(1000, 700)   ' Maximum Size - 1000X700 px
        CallingForm.MinimumSize = New Size(1000, 700)   ' Minimum Size - 1000X700 px
        CallingForm.StartPosition = FormStartPosition.CenterScreen   ' Default Start Position - CenterScreen
        CallingForm.WindowState = FormWindowState.Normal   ' Default Window State - Normal
        CallingForm.ShowIcon = True   ' Show Icon - True
    End Sub
End Module
