Public Class editfrm
    Private Sub svbtn_Click(sender As Object, e As EventArgs) Handles svbtn.Click
        con.Open()
        com = con.CreateCommand
        com.CommandType = CommandType.Text
        '     trans = con.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim ra As Integer = 2
        Dim pda As Integer = 3

        Try
            com.CommandText = "Update Users SET Email= @email ,FirstName= @Fn ,LastName=@Ln ,RoleID= @role, Office= @office"
            With com.Parameters
                .AddWithValue("@email", emailtxt.Text)
                .AddWithValue("@Fn", fntxt.Text)
                .AddWithValue("@Ln", lntxt.Text)
                .AddWithValue("office", officecmb.Text)

                If officecmb.Text = "Region Admin" Then
                    .AddWithValue("@role", ra)
                ElseIf officecmb.Text = "Province/District Admin" Then
                    .AddWithValue("@role", pda)
                Else


                End If

            End With

            com.ExecuteNonQuery()
            MessageBox.Show("Updated Succesfuly" + MsgBoxStyle.Information, "NOTIFICATION")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()
        Finally
            con.Close()

        End Try


    End Sub
End Class