<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addfrm
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
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.fntxt = New System.Windows.Forms.TextBox()
        Me.lntxt = New System.Windows.Forms.TextBox()
        Me.pwdtxt = New System.Windows.Forms.TextBox()
        Me.officecmb = New System.Windows.Forms.ComboBox()
        Me.rollcmb = New System.Windows.Forms.ComboBox()
        Me.svbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'emailtxt
        '
        Me.emailtxt.Location = New System.Drawing.Point(143, 89)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(272, 23)
        Me.emailtxt.TabIndex = 0
        '
        'fntxt
        '
        Me.fntxt.Location = New System.Drawing.Point(143, 149)
        Me.fntxt.Name = "fntxt"
        Me.fntxt.Size = New System.Drawing.Size(272, 23)
        Me.fntxt.TabIndex = 1
        '
        'lntxt
        '
        Me.lntxt.Location = New System.Drawing.Point(143, 205)
        Me.lntxt.Name = "lntxt"
        Me.lntxt.Size = New System.Drawing.Size(272, 23)
        Me.lntxt.TabIndex = 2
        '
        'pwdtxt
        '
        Me.pwdtxt.Location = New System.Drawing.Point(143, 421)
        Me.pwdtxt.Name = "pwdtxt"
        Me.pwdtxt.Size = New System.Drawing.Size(272, 23)
        Me.pwdtxt.TabIndex = 3
        '
        'officecmb
        '
        Me.officecmb.FormattingEnabled = True
        Me.officecmb.Location = New System.Drawing.Point(143, 328)
        Me.officecmb.Name = "officecmb"
        Me.officecmb.Size = New System.Drawing.Size(272, 23)
        Me.officecmb.TabIndex = 4
        '
        'rollcmb
        '
        Me.rollcmb.FormattingEnabled = True
        Me.rollcmb.Location = New System.Drawing.Point(143, 376)
        Me.rollcmb.Name = "rollcmb"
        Me.rollcmb.Size = New System.Drawing.Size(272, 23)
        Me.rollcmb.TabIndex = 5
        '
        'svbtn
        '
        Me.svbtn.Location = New System.Drawing.Point(323, 510)
        Me.svbtn.Name = "svbtn"
        Me.svbtn.Size = New System.Drawing.Size(140, 61)
        Me.svbtn.TabIndex = 6
        Me.svbtn.Text = "SAVE"
        Me.svbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(39, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "EMAIL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(14, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "FIRST NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(14, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "LAST NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(34, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "OFFICE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(39, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ROLE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(20, 421)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "PASSWORD"
        '
        'addfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 583)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.svbtn)
        Me.Controls.Add(Me.rollcmb)
        Me.Controls.Add(Me.officecmb)
        Me.Controls.Add(Me.pwdtxt)
        Me.Controls.Add(Me.lntxt)
        Me.Controls.Add(Me.fntxt)
        Me.Controls.Add(Me.emailtxt)
        Me.Name = "addfrm"
        Me.Text = "addfrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents emailtxt As TextBox
    Friend WithEvents fntxt As TextBox
    Friend WithEvents lntxt As TextBox
    Friend WithEvents pwdtxt As TextBox
    Friend WithEvents officecmb As ComboBox
    Friend WithEvents rollcmb As ComboBox
    Friend WithEvents svbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
