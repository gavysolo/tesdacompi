<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
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
        Me.UsersView = New System.Windows.Forms.DataGridView()
        Me.filebtn = New System.Windows.Forms.Button()
        Me.intsbtn = New System.Windows.Forms.Button()
        Me.usrbtn = New System.Windows.Forms.Button()
        Me.logbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.srchtxt = New System.Windows.Forms.TextBox()
        Me.srchbtn = New System.Windows.Forms.Button()
        Me.chngbtn = New System.Windows.Forms.Button()
        Me.enblbtn = New System.Windows.Forms.Button()
        Me.userstrip = New System.Windows.Forms.Panel()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        CType(Me.UsersView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.userstrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsersView
        '
        Me.UsersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersView.Location = New System.Drawing.Point(12, 147)
        Me.UsersView.Name = "UsersView"
        Me.UsersView.RowTemplate.Height = 25
        Me.UsersView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsersView.Size = New System.Drawing.Size(969, 283)
        Me.UsersView.TabIndex = 0
        '
        'filebtn
        '
        Me.filebtn.Location = New System.Drawing.Point(12, 12)
        Me.filebtn.Name = "filebtn"
        Me.filebtn.Size = New System.Drawing.Size(110, 36)
        Me.filebtn.TabIndex = 1
        Me.filebtn.Text = "file"
        Me.filebtn.UseVisualStyleBackColor = True
        '
        'intsbtn
        '
        Me.intsbtn.Location = New System.Drawing.Point(128, 12)
        Me.intsbtn.Name = "intsbtn"
        Me.intsbtn.Size = New System.Drawing.Size(110, 36)
        Me.intsbtn.TabIndex = 2
        Me.intsbtn.Text = "institution"
        Me.intsbtn.UseVisualStyleBackColor = True
        '
        'usrbtn
        '
        Me.usrbtn.Location = New System.Drawing.Point(244, 12)
        Me.usrbtn.Name = "usrbtn"
        Me.usrbtn.Size = New System.Drawing.Size(110, 36)
        Me.usrbtn.TabIndex = 3
        Me.usrbtn.Text = "users"
        Me.usrbtn.UseVisualStyleBackColor = True
        '
        'logbtn
        '
        Me.logbtn.Location = New System.Drawing.Point(360, 12)
        Me.logbtn.Name = "logbtn"
        Me.logbtn.Size = New System.Drawing.Size(110, 36)
        Me.logbtn.TabIndex = 4
        Me.logbtn.Text = "log-out"
        Me.logbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(410, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SEARCH NAME"
        '
        'srchtxt
        '
        Me.srchtxt.Location = New System.Drawing.Point(504, 97)
        Me.srchtxt.Name = "srchtxt"
        Me.srchtxt.Size = New System.Drawing.Size(333, 23)
        Me.srchtxt.TabIndex = 6
        '
        'srchbtn
        '
        Me.srchbtn.Location = New System.Drawing.Point(865, 90)
        Me.srchbtn.Name = "srchbtn"
        Me.srchbtn.Size = New System.Drawing.Size(67, 35)
        Me.srchbtn.TabIndex = 7
        Me.srchbtn.Text = "search"
        Me.srchbtn.UseVisualStyleBackColor = True
        '
        'chngbtn
        '
        Me.chngbtn.Location = New System.Drawing.Point(12, 547)
        Me.chngbtn.Name = "chngbtn"
        Me.chngbtn.Size = New System.Drawing.Size(110, 23)
        Me.chngbtn.TabIndex = 8
        Me.chngbtn.Text = "CHANGE ROLL"
        Me.chngbtn.UseVisualStyleBackColor = True
        '
        'enblbtn
        '
        Me.enblbtn.Location = New System.Drawing.Point(142, 547)
        Me.enblbtn.Name = "enblbtn"
        Me.enblbtn.Size = New System.Drawing.Size(133, 23)
        Me.enblbtn.TabIndex = 9
        Me.enblbtn.Text = "ENABLE USER"
        Me.enblbtn.UseVisualStyleBackColor = True
        '
        'userstrip
        '
        Me.userstrip.Controls.Add(Me.editbtn)
        Me.userstrip.Controls.Add(Me.addbtn)
        Me.userstrip.Location = New System.Drawing.Point(240, 54)
        Me.userstrip.Name = "userstrip"
        Me.userstrip.Size = New System.Drawing.Size(120, 71)
        Me.userstrip.TabIndex = 10
        Me.userstrip.Visible = False
        '
        'editbtn
        '
        Me.editbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.editbtn.Location = New System.Drawing.Point(0, 36)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(120, 36)
        Me.editbtn.TabIndex = 12
        Me.editbtn.Text = "EDIT USERS"
        Me.editbtn.UseVisualStyleBackColor = True
        '
        'addbtn
        '
        Me.addbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.addbtn.Location = New System.Drawing.Point(0, 0)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(120, 36)
        Me.addbtn.TabIndex = 11
        Me.addbtn.Text = "ADD USERS"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 582)
        Me.Controls.Add(Me.userstrip)
        Me.Controls.Add(Me.enblbtn)
        Me.Controls.Add(Me.chngbtn)
        Me.Controls.Add(Me.srchbtn)
        Me.Controls.Add(Me.srchtxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logbtn)
        Me.Controls.Add(Me.usrbtn)
        Me.Controls.Add(Me.intsbtn)
        Me.Controls.Add(Me.filebtn)
        Me.Controls.Add(Me.UsersView)
        Me.Name = "mainform"
        Me.Text = "mainform"
        CType(Me.UsersView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.userstrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsersView As DataGridView
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents filebtn As Button
    Friend WithEvents intsbtn As Button
    Friend WithEvents usrbtn As Button
    Friend WithEvents logbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents srchtxt As TextBox
    Friend WithEvents srchbtn As Button
    Friend WithEvents chngbtn As Button
    Friend WithEvents enblbtn As Button
    Friend WithEvents userstrip As Panel
    Friend WithEvents editbtn As Button
    Friend WithEvents addbtn As Button
End Class
