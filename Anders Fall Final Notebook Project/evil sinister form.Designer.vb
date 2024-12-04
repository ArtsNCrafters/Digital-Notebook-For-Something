<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scaryform
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
        Me.picScary = New System.Windows.Forms.PictureBox()
        Me.sacretimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picScary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picScary
        '
        Me.picScary.Image = Global.Anders_Fall_Final_Notebook_Project.My.Resources.Resources.boo
        Me.picScary.Location = New System.Drawing.Point(0, 0)
        Me.picScary.Name = "picScary"
        Me.picScary.Size = New System.Drawing.Size(100, 50)
        Me.picScary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picScary.TabIndex = 0
        Me.picScary.TabStop = False
        '
        'sacretimer
        '
        Me.sacretimer.Interval = 1000
        '
        'scaryform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picScary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "scaryform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.picScary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picScary As PictureBox
    Friend WithEvents sacretimer As Timer
End Class
