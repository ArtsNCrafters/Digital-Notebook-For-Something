Public Class resetform
    Dim user As String = SystemInformation.UserName

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        If chk1.Checked = True And chk2.Checked = True And chk3.Checked = True Then
            My.Computer.FileSystem.DeleteFile("C:\Users\" & user & "\yourpersonalnotebook.txt")
            MainForm.Close()
        End If
    End Sub

    Private Sub lblYap_Click(sender As Object, e As EventArgs) Handles lblYap.Click
        scaryform.Visible = True
        scaryform.sacretimer.Enabled = True
    End Sub
End Class