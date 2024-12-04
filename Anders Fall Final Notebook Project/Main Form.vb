Public Class MainForm

    ' to find the notebook file, go to
    '"C:\Users\YOURUSERHERE\yourpersonalnotebook.txt"






    Dim stringReader As String
    Dim pass As String
    Dim user As String = SystemInformation.UserName
    Dim afile As IO.File
    Dim tick As Integer = 0
    Dim pwned As Boolean = False
    Dim passuccess As Boolean = False

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'had to do some research to find this code

        Me.StartPosition = FormStartPosition.CenterScreen

        If afile.Exists("C:\Users\" & user & "\yourpersonalnotebook.txt") Then
            MsgBox("Welcome back, " & user & "!")
            txtText.ReadOnly = True
            Dim fileReader As System.IO.StreamReader
            fileReader =
            My.Computer.FileSystem.OpenTextFileReader("C:\Users\" & user & "\yourpersonalnotebook.txt")

            stringReader = fileReader.ReadLine()
            lblPlan.Text = stringReader
            Select Case lblPlan.Text
                Case "Basic"
                    'to prevent you from getting pwned on basic
                Case "Pro"
                    lblPlan.ForeColor = Color.Chartreuse
                Case "Premium"

                    lblPlan.ForeColor = Color.LightSeaGreen
                    PictureBox1.Image = My.Resources.you_have_autosave
                    btnSave.Visible = False
                Case Else
                    lblPlan.Text = "PWN3D!11!!1!"
                    txtText.ForeColor = Color.Goldenrod
                    UnregisteredHypercam2.Visible = True
                    MsgBox("Grr, why u h4ck m4h Pr0duc7 " & user & "???/? GRRR!1!1111")
                    Me.Text = "N03tb00k fr33 3d1t10n >:("
                    resetform.lblYap.Text = "H3h.... try1ng to r3s3t 1 s33.... f00l.... 
Click me if u DARE......"
                    pwned = True
                    Me.Cursor = Cursors.No
                    Me.ShowInTaskbar = False
                    UnregisteredHypercam2.ShowInTaskbar = False
            End Select
            If Not lblPlan.Text = "Basic" Then
                stringReader = fileReader.ReadLine()
                pass = stringReader
                txtText.Text = "please enter password!"
            Else
                Dim lines As Integer
                stringReader = fileReader.ReadLine()
                Do Until fileReader.EndOfStream = True
                    fileReader.ReadLine()
                    lines += 1
                Loop
                fileReader.Close()
                fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\" & user & "\yourpersonalnotebook.txt")
                fileReader.ReadLine()
                fileReader.ReadLine()
                fileReader.ReadLine()

                Dim reader As Integer
                txtText.Text = String.Empty
                Do While reader <= lines + 1
                    stringReader = fileReader.ReadLine()
                    reader += 1
                    txtText.Text = txtText.Text & stringReader & ControlChars.NewLine
                Loop
                txtText.ReadOnly = False
                txtPass.Visible = False
                btnPasswordCheck.Visible = False
                Label1.Visible = False
            End If
            fileReader.Close()
            ResetTimer.Enabled = True
        Else
            MsgBox("Hello " & user & "! Welcome to our brand new Digital Notebook system, where you can keep all your important stuff!")
            MsgBox("It seems like you're new to this program, so let's get your Notebook price plan all sorted out!")
            Me.Visible = False
            PricePlanForm.Visible = True
        End If
    End Sub
    Dim testvariable As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If passuccess = True Then
            If lblPlan.Text = "Premium" Then
                Dim fileReader As System.IO.StreamReader
                fileReader =
                My.Computer.FileSystem.OpenTextFileReader("C:\Users\" & user & "\yourpersonalnotebook.txt")
                If Not lblPlan.Text = "Basic" Then
                    fileReader.ReadLine()
                    pass = fileReader.ReadLine()
                Else
                    pass = "ΣΣΣΣΣΣΣΣ۞۞۞۞۞۞۞ ۝ 	 ۝ 	 ۝ 	 ۝ 	 ۝ 	 ۝ 	ΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣlmao"
                End If

                fileReader.Close()
                My.Computer.FileSystem.DeleteFile("C:\Users\" & user & "\yourpersonalnotebook.txt")

                Dim filepath As String = "C:\Users\" & user & "\yourpersonalnotebook.txt"
                If Not System.IO.File.Exists(filepath) Then
                    System.IO.File.Create(filepath).Dispose()
                End If

                Dim file As System.IO.StreamWriter
                file =
    My.Computer.FileSystem.OpenTextFileWriter("C:\Users\" & user & "\yourpersonalnotebook.txt", True)

                file.WriteLine(lblPlan.Text)
                file.WriteLine(pass)
                file.Close()
                Dim current As String
                Dim reader As System.IO.StreamReader
                reader =
            My.Computer.FileSystem.OpenTextFileReader("C:\Users\" & user & "\yourpersonalnotebook.txt")
                Dim lines As Integer
                Do While reader.EndOfStream = False
                    current = reader.ReadLine()
                    lines += 1
                Loop
                reader.Close()
                file =
    My.Computer.FileSystem.OpenTextFileWriter("C:\Users\" & user & "\yourpersonalnotebook.txt", True)
                Dim writer As Integer
                file.WriteLine(lines)
                file.WriteLine(txtText.Text)
                file.Close()
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btnPasswordCheck_Click(sender As Object, e As EventArgs) Handles btnPasswordCheck.Click
        Dim fileReader As System.IO.StreamReader
        fileReader =
            My.Computer.FileSystem.OpenTextFileReader("C:\Users\" & user & "\yourpersonalnotebook.txt")
        If txtPass.Text = pass Then
            stringReader = fileReader.ReadLine()
            txtText.ReadOnly = False
            stringReader = fileReader.ReadLine()
            MsgBox("Correct Password!")
            passuccess = True
            stringReader = fileReader.ReadLine()
            Dim lines As Integer = stringReader
            Do Until fileReader.EndOfStream = True
                stringReader = fileReader.ReadLine()
                lines += 1
            Loop
            fileReader.Close()
            fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\" & user & "\yourpersonalnotebook.txt")
            fileReader.ReadLine()
            fileReader.ReadLine()
            fileReader.ReadLine()

            Dim reader As Integer
                txtText.Text = String.Empty
            Do While reader <= lines + 1
                stringReader = fileReader.ReadLine()
                reader += 1
                txtText.Text = txtText.Text & stringReader & ControlChars.NewLine
            Loop

        End If
            fileReader.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If passuccess = True Then
            Dim fileReader As System.IO.StreamReader
            fileReader =
                My.Computer.FileSystem.OpenTextFileReader("C:\Users\" & user & "\yourpersonalnotebook.txt")
            If Not lblPlan.Text = "Basic" Then
                fileReader.ReadLine()
                pass = fileReader.ReadLine()
            Else
                pass = "ΣΣΣΣΣΣΣΣ۞۞۞۞۞۞۞ ۝ 	 ۝ 	 ۝ 	 ۝ 	 ۝ 	 ۝ 	ΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣΣlmao"
            End If

            fileReader.Close()
            My.Computer.FileSystem.DeleteFile("C:\Users\" & user & "\yourpersonalnotebook.txt")

            Dim filepath As String = "C:\Users\" & user & "\yourpersonalnotebook.txt"
            If Not System.IO.File.Exists(filepath) Then
                System.IO.File.Create(filepath).Dispose()
            End If

            Dim file As System.IO.StreamWriter
            file =
    My.Computer.FileSystem.OpenTextFileWriter("C:\Users\" & user & "\yourpersonalnotebook.txt", True)

            file.WriteLine(lblPlan.Text)
            file.WriteLine(pass)
            file.Close()
            Dim reader As System.IO.StreamReader
            reader =
            My.Computer.FileSystem.OpenTextFileReader("C:\Users\" & user & "\yourpersonalnotebook.txt")
            Dim lines As Integer
            Do While reader.EndOfStream = False
                reader.ReadLine()
                lines += 1
            Loop
            reader.Close()
            file =
    My.Computer.FileSystem.OpenTextFileWriter("C:\Users\" & user & "\yourpersonalnotebook.txt", True)
            Dim writer As Integer
            file.WriteLine(lines)
            file.WriteLine(txtText.Text)
            file.Close()
        End If
    End Sub

    Private Sub ResetTimer_Tick(sender As Object, e As EventArgs) Handles ResetTimer.Tick

        Select Case tick
            Case 10
                Label3.Visible = True
            Case 30
                btnDev.Visible = True
        End Select
        Dim y As Integer
        Dim x As Integer
        Dim position As Point
        position = Me.Location
        If pwned = True Then
            x = position.X + Int((100 - -100 + 1) * Rnd() + -100)
            y = position.Y + ((100 - -100 + 1) * Rnd() + -100)
            Me.Location = New Point(x, y)
        End If

        tick += 1
    End Sub

    Private Sub btnDev_Click(sender As Object, e As EventArgs) Handles btnDev.Click
        resetform.Visible = True
    End Sub
End Class
