Imports Oracle.DataAccess.Client
Public Class Fine
    Dim con As New OracleConnection
    Dim cmd, cmd1, cmd2, cmd3 As New OracleCommand
    Private Sub Fine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        con = New OracleConnection("Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root")
        con.Open()
        Try
            cmd = New OracleCommand("insert into fine_table values ('" + FineId.Text() + "', '" + FineAmount.Text() + "', '" + FineDate.Text() + "', '" + FBprn.Text() + "')", con)
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
            cmd = New OracleCommand("Update Fine_table Set Fine_id = '" + FineId.Text() + "', Fine_amount =  '" + FineAmount.Text() + "', Fine_date= '" + FineDate.Text() + "', B_prn= '" + FBprn.Text() + "' where Fine_id = '" + FineId.Text() + "'", con)
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
            cmd = New OracleCommand("DELETE From Fine_table Where fine_ID= '" + FineId.Text() + "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("DATA  DELETED  SUCCESSFULLY")
            con.Close()
          Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FineDetailsView.Show()
    End Sub
End Class