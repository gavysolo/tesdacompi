<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class log_infrm
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
        Me.untxt = New System.Windows.Forms.TextBox()
        Me.pwdtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'untxt
        '
        Me.untxt.Location = New System.Drawing.Point(192, 49)
        Me.untxt.Name = "untxt"
        Me.untxt.Size = New System.Drawing.Size(211, 23)
        Me.untxt.TabIndex = 0
        '
        'pwdtxt
        '
        Me.pwdtxt.Location = New System.Drawing.Point(192, 98)
        Me.pwdtxt.Name = "pwdtxt"
        Me.pwdtxt.Size = New System.Drawing.Size(211, 23)
        Me.pwdtxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "USERNAME?email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PASSWORD"
        '
        'savebtn
        '
        Me.savebtn.Location = New System.Drawing.Point(148, 145)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(147, 47)
        Me.savebtn.TabIndex = 4
        Me.savebtn.Text = "Button1"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'log_infrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 204)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pwdtxt)
        Me.Controls.Add(Me.untxt)
        Me.Name = "log_infrm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents untxt As TextBox
    Friend WithEvents pwdtxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents savebtn As Button
End Class
