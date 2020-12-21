Public Class mainform
    Dim ds As New DataSet
    Dim numID As Integer
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub usrbtn_Click(sender As Object, e As EventArgs) Handles usrbtn.Click
        If userstrip.Visible = False Then
            userstrip.Visible = True
        Else
            userstrip.Visible = False
        End If


    End Sub

    Private Sub srchbtn_Click(sender As Object, e As EventArgs) Handles srchbtn.Click
        Dim adpt As New SqlClient.SqlDataAdapter("select * from Users where FirstName= '" + srchtxt.Text + "' OR LastName='" + srchtxt.Text + "'", con)
        Dim dss As New DataSet
        adpt.Fill(dss, "Users")

        UsersView.DataSource = dss.Tables(0)


    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        addfrm.Show()
        Me.Hide()

    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        editfrm.Show()
        Me.Hide()

    End Sub

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '  loadview()
    End Sub

    Public Sub loadview()
        Dim cons As String = "select  Users.FirstName, Users.LastName, Roles.RoleType, Users.Email, Users.Office from Users Inner Join on Roles(ID) = Users(RoleID) "
        Dim adapt As New SqlClient.SqlDataAdapter(cons, con)

        adapt.Fill(ds, "Users")
        UsersView.DataSource = ds.Tables(0)

    End Sub

    Private Sub enblbtn_Click(sender As Object, e As EventArgs) Handles enblbtn.Click

    End Sub

    Private Sub UsersView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersView.CellClick
        '  numID = UsersView.SelectedRows.Item(0).ToString()


    End Sub
End Class