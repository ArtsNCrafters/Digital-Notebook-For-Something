<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class resetform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(resetform))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chk3 = New System.Windows.Forms.CheckBox()
        Me.lblYap = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(485, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clicking yes will delete your data and reset the app so you start all the way fro" &
    "m the beginning. Are you sure?"
        '
        'btnconfirm
        '
        Me.btnconfirm.Location = New System.Drawing.Point(417, 55)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(81, 23)
        Me.btnconfirm.TabIndex = 1
        Me.btnconfirm.Text = "&Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(13, 60)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(44, 17)
        Me.chk1.TabIndex = 2
        Me.chk1.Text = "Yes"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(63, 60)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(55, 17)
        Me.chk2.TabIndex = 3
        Me.chk2.Text = "Really"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'chk3
        '
        Me.chk3.AutoSize = True
        Me.chk3.Location = New System.Drawing.Point(133, 61)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(74, 17)
        Me.chk3.TabIndex = 4
        Me.chk3.Text = "Absolutely"
        Me.chk3.UseVisualStyleBackColor = True
        '
        'lblYap
        '
        Me.lblYap.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblYap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYap.Location = New System.Drawing.Point(12, 81)
        Me.lblYap.Name = "lblYap"
        Me.lblYap.Size = New System.Drawing.Size(486, 294)
        Me.lblYap.TabIndex = 5
        Me.lblYap.Text = resources.GetString("lblYap.Text")
        '
        'resetform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 385)
        Me.Controls.Add(Me.lblYap)
        Me.Controls.Add(Me.chk3)
        Me.Controls.Add(Me.chk2)
        Me.Controls.Add(Me.chk1)
        Me.Controls.Add(Me.btnconfirm)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "resetform"
        Me.Text = "Super Cool Dev Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnconfirm As Button
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents lblYap As Label
End Class
