Public Class PricePlanForm

    Dim check As Boolean = False
    Const DBLbaseprice As Double = 5
    Dim dblPro As Double = 5
    Dim dblPremium As Double = 10.75
    Dim user As String = SystemInformation.UserName
    Dim Plan As String
    Private Sub PricePlanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Here, you'll set up your app so that the price is just right for you!")
        MainForm.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MainForm.Close()
        Me.Close()
    End Sub

    Private Sub rdbBasic_CheckedChanged(sender As Object, e As EventArgs) Handles rdbBasic.CheckedChanged
        If rdbBasic.Checked = True Then
            lblPrice.Text = "Price:" & DBLbaseprice.ToString("C2")
            Plan = "Basic"
        End If
    End Sub

    Private Sub rdbPro_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPro.CheckedChanged
        If rdbPro.Checked = True Then
            lblPrice.Text = "Price:" & (DBLbaseprice + dblPro).ToString("C2")
            Plan = "Pro"
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPremium.CheckedChanged
        If rdbPremium.Checked = True Then
            lblPrice.Text = "Price:" & (DBLbaseprice + dblPremium).ToString("C2")
            Plan = "Premium"
        End If
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click

        Dim filepath As String = "C:\Users\" & user & "\yourpersonalnotebook.txt"
        If Not System.IO.File.Exists(filepath) Then
            System.IO.File.Create(filepath).Dispose()
        End If
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(filepath, True)

        If check = False Then
            MainForm.Enabled = True
            MainForm.txtText.Text = "Start typing!"
            MainForm.txtText.ReadOnly = False
            MainForm.lblPlan.Text = Plan
            Select Case Plan
                Case "Basic"
                    MsgBox("Thank you for purchasing our Basic Plan! Your app will be ready shortly...")
                    MainForm.txtPass.Visible = False
                    MainForm.btnPasswordCheck.Visible = False
                    MainForm.Label1.Visible = False
                Case "Pro"
                    MsgBox("Thank you for purchasing our Pro Plan! Your unique app will be ready shortly...")
                Case "Premium"
                    MsgBox("Thank you, thank you so much " & user & " for purchasing our Premium Plan! Your specialized app will be ready shortly...")
                    MainForm.btnSave.Enabled = False
            End Select


            file.WriteLine(Plan)
            grpPlans.Enabled = False
            If Plan = "Pro" Or Plan = "Premium" Then
                MainForm.Enabled = False
                MsgBox("Please Make A Password! Once finished inputting your password in the Price Planner form, select the 'complete' button.")
                btnPurchase.Text = "&Complete"
                txtSetPass.Visible = True
                Label2.Visible = True
                check = True
                Select Case Plan
                    Case "Pro"
                        MainForm.lblPlan.ForeColor = Color.Chartreuse
                    Case "Premium"
                        MainForm.lblPlan.ForeColor = Color.LightSeaGreen
                        MainForm.PictureBox1.Image = My.Resources.you_have_autosave
                        MainForm.btnSave.Visible = False
                End Select
            End If
            file.Close()
            If Plan = "Basic" Then
                Me.Close()
            End If
        Else
            MainForm.Enabled = True

            Dim password As String = txtSetPass.Text
            file.WriteLine(password)
            file.Close()

            Me.Close()
        End If


    End Sub

End Class