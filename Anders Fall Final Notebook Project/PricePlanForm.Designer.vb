<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PricePlanForm
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
        Me.grpPlans = New System.Windows.Forms.GroupBox()
        Me.rdbPremium = New System.Windows.Forms.RadioButton()
        Me.rdbPro = New System.Windows.Forms.RadioButton()
        Me.rdbBasic = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtSetPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grpPlans.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPlans
        '
        Me.grpPlans.Controls.Add(Me.rdbPremium)
        Me.grpPlans.Controls.Add(Me.rdbPro)
        Me.grpPlans.Controls.Add(Me.rdbBasic)
        Me.grpPlans.Location = New System.Drawing.Point(162, 12)
        Me.grpPlans.Name = "grpPlans"
        Me.grpPlans.Size = New System.Drawing.Size(200, 148)
        Me.grpPlans.TabIndex = 0
        Me.grpPlans.TabStop = False
        Me.grpPlans.Text = "Plans"
        '
        'rdbPremium
        '
        Me.rdbPremium.Location = New System.Drawing.Point(7, 106)
        Me.rdbPremium.Name = "rdbPremium"
        Me.rdbPremium.Size = New System.Drawing.Size(187, 37)
        Me.rdbPremium.TabIndex = 2
        Me.rdbPremium.TabStop = True
        Me.rdbPremium.Text = "Premium: Comes with all features, including auto saving"
        Me.rdbPremium.UseVisualStyleBackColor = True
        '
        'rdbPro
        '
        Me.rdbPro.Location = New System.Drawing.Point(6, 63)
        Me.rdbPro.Name = "rdbPro"
        Me.rdbPro.Size = New System.Drawing.Size(187, 37)
        Me.rdbPro.TabIndex = 1
        Me.rdbPro.TabStop = True
        Me.rdbPro.Text = "Pro: Comes with Basic features along with password lock"
        Me.rdbPro.UseVisualStyleBackColor = True
        '
        'rdbBasic
        '
        Me.rdbBasic.Location = New System.Drawing.Point(7, 20)
        Me.rdbBasic.Name = "rdbBasic"
        Me.rdbBasic.Size = New System.Drawing.Size(187, 37)
        Me.rdbBasic.TabIndex = 0
        Me.rdbBasic.TabStop = True
        Me.rdbBasic.Text = "Basic: Comes with default saving and loading, no password"
        Me.rdbBasic.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose the plan that is right for you!"
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(287, 199)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(75, 23)
        Me.btnPurchase.TabIndex = 2
        Me.btnPurchase.Text = "Pur&chase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 199)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.Cornsilk
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(251, 173)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(111, 23)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSetPass
        '
        Me.txtSetPass.Location = New System.Drawing.Point(137, 201)
        Me.txtSetPass.Name = "txtSetPass"
        Me.txtSetPass.Size = New System.Drawing.Size(100, 20)
        Me.txtSetPass.TabIndex = 5
        Me.txtSetPass.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Set Password:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Leave A Tip:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 140)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'PricePlanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 234)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSetPass)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpPlans)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PricePlanForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Digital Notebook Price Planner"
        Me.TopMost = True
        Me.grpPlans.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpPlans As GroupBox
    Friend WithEvents rdbPremium As RadioButton
    Friend WithEvents rdbPro As RadioButton
    Friend WithEvents rdbBasic As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPurchase As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtSetPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
