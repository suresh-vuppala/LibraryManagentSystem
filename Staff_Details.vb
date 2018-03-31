Imports Oracle.DataAccess.Client

Public Class Staff_Details
    Dim con As New OracleConnection
    Dim cmd, cmd1, cmd2, cmd3 As New OracleCommand
    Private Sub Staff_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con = New OracleConnection("Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root")

        con.Open()
        Try
            cmd = New OracleCommand("insert into staff_table values ('" + txtStaffID.Text() + "', '" + txtStaffName.Text() + "', '" + txtStaffGender.Text() + "', '" + txtStaffZip.Text() + "')", con)
              cmd.ExecuteNonQuery()
               MessageBox.Show("DATA  INSERTED  SUCCESSFULLY")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con = New OracleConnection("Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root")
        con.Open()
        Try
            cmd = New OracleCommand("Update staff_table Set Staff_Id = '" + txtStaffID.Text() + "', staff_name =  '" + txtStaffName.Text() + "', staff_gender= '" + txtStaffGender.Text() + "', staff_zip= '" + txtStaffZip.Text() + "' where staff_id = '" + txtStaffID.Text() + "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("DATA  UPDATED  SUCCESSFULLY")
            con.Close()
           Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con = New OracleConnection("Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root")
        con.Open()
        Try
            cmd = New OracleCommand("DELETE From staff_table Where staff_id = '" + txtStaffID.Text() + "' ", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("DATA  DELETED  SUCCESSFULLY")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        StaffDetailsView.Show()
    End Sub
End Class
