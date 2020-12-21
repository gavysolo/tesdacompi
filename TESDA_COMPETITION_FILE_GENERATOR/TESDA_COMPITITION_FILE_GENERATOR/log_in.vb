Public Class log_infrm
    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        con.Open()
        Dim adpt As New SqlClient.SqlDataAdapter("select * from dbo.Users Where Email='" + untxt.Text + "' and Passwords= '" + pwdtxt.Text + "'", con)
        Dim ds As New DataSet
        Dim dt As New DataTable
        adpt.Fill(ds, "Users")
        dt = ds.Tables(0)

        Try
            If (dt.Rows.Count > 0) Then
                MsgBox("login succesully")
            Else
                MsgBox("log-in failed")

            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()
        Finally
            con.Close()
        End Try



    End Sub
End Class
