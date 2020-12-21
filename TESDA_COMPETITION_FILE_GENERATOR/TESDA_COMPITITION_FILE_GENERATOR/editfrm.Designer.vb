<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editfrm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rollcmb = New System.Windows.Forms.ComboBox()
        Me.officecmb = New System.Windows.Forms.ComboBox()
        Me.lntxt = New System.Windows.Forms.TextBox()
        Me.fntxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.svbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(53, 375)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "ROLE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(48, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "OFFICE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(28, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "LAST NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(28, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "FIRST NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(53, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "EMAIL"
        '
        'rollcmb
        '
        Me.rollcmb.FormattingEnabled = True
        Me.rollcmb.Location = New System.Drawing.Point(157, 375)
        Me.rollcmb.Name = "rollcmb"
        Me.rollcmb.Size = New System.Drawing.Size(272, 23)
        Me.rollcmb.TabIndex = 16
        '
        'officecmb
        '
        Me.officecmb.FormattingEnabled = True
        Me.officecmb.Location = New System.Drawing.Point(157, 327)
        Me.officecmb.Name = "officecmb"
        Me.officecmb.Size = New System.Drawing.Size(272, 23)
        Me.officecmb.TabIndex = 15
        '
        'lntxt
        '
        Me.lntxt.Location = New System.Drawing.Point(157, 204)
        Me.lntxt.Name = "lntxt"
        Me.lntxt.Size = New System.Drawing.Size(272, 23)
        Me.lntxt.TabIndex = 14
        '
        'fntxt
        '
        Me.fntxt.Location = New System.Drawing.Point(157, 148)
        Me.fntxt.Name = "fntxt"
        Me.fntxt.Size = New System.Drawing.Size(272, 23)
        Me.fntxt.TabIndex = 13
        '
        'emailtxt
        '
        Me.emailtxt.Location = New System.Drawing.Point(157, 88)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(272, 23)
        Me.emailtxt.TabIndex = 12
        '
        'svbtn
        '
        Me.svbtn.Location = New System.Drawing.Point(323, 510)
        Me.svbtn.Name = "svbtn"
        Me.svbtn.Size = New System.Drawing.Size(140, 61)
        Me.svbtn.TabIndex = 22
        Me.svbtn.Text = "SAVE"
        Me.svbtn.UseVisualStyleBackColor = True
        '
        'editfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 583)
        Me.Controls.Add(Me.svbtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rollcmb)
        Me.Controls.Add(Me.officecmb)
        Me.Controls.Add(Me.lntxt)
        Me.Controls.Add(Me.fntxt)
        Me.Controls.Add(Me.emailtxt)
        Me.Name = "editfrm"
        Me.Text = "editfrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rollcmb As ComboBox
    Friend WithEvents officecmb As ComboBox
    Friend WithEvents lntxt As TextBox
    Friend WithEvents fntxt As TextBox
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents svbtn As Button
End Class
