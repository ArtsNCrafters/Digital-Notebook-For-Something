Public Class scaryform
    Dim tick As Integer = 0
    Private Sub scaryform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim width As Double = My.Computer.Screen.Bounds.Size.Width
        Dim height As Double = My.Computer.Screen.Bounds.Size.Height
        Size = New Size(width, height)
        picScary.Size = New Size(width, height)
        sacretimer.Enabled = True
    End Sub

    Private Sub sacretimer_Tick(sender As Object, e As EventArgs) Handles sacretimer.Tick
        If tick = 1 Then
            Me.Close()
        End If
        tick += 1
    End Sub
End Class