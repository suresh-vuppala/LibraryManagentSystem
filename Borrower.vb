Imports Oracle.DataAccess.Client
Public Class Borrower
    Dim con As New OracleConnection
    Dim cmd, cmd1, cmd2, cmd3 As New OracleCommand
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        con = New OracleConnection("Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root")

        con.Open()
        Try
            cmd = New OracleCommand("insert into b_table values ('" + Bprn.Text() + "', '" + BlName.Text() + "', '" + BfName.Text() + "','" + BRoolNo.Text() + "','" + bStaffId.Text + "' )", con)
            cmd1 = New OracleCommand("insert into B_prn_Bk_code_table values ('" + Bprn.Text() + "', '" + BMobNo.Text + "' )", con)

            cmd.ExecuteNonQuery()
        
            MessageBox.Show("DATA  INSERTED  SUCCESSFULLY")
            con.Close()
           

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        con = New OracleConnection("Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root")

        con.Open()
        Try
            cmd = New OracleCommand("Update B_table Set b_prn = '" + Bprn.Text() + "', b_l_name =  '" + BlName.Text() + "', b_f_name= '" + BfName.Text() + "', b_rollno= '" + BRoolNo.Text() + "',staff_id='" + bStaffId.Text() + "' where b_prn = '" + Bprn.Text() + "'", con)
          
            cmd.ExecuteNonQuery()
            MessageBox.Show("DATA  UPDATED  SUCCESSFULLY")
            con.Close()
        
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Borrower_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        con = New OracleConnection("Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root")

        con.Open()
        Try
            cmd = New OracleCommand("DELETE From B_table Where b_prn= '" + Bprn.Text() + "'", con)
        

            cmd.ExecuteNonQuery()
       
            MessageBox.Show("DATA  DELETED  SUCCESSFULLY")
            con.Close()
      
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BorrowersDetailsView.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BorrowerMobileDetails.Show()
    End Sub
End Class