Imports Oracle.DataAccess.Client
Public Class Book_Details
    Dim con As New OracleConnection
    Dim cmd, cmd1, cmd2, cmd3 As New OracleCommand
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        con = New OracleConnection("Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root")

        con.Open()
        Try
            cmd = New OracleCommand("insert into bk_table values ('" + BookCode.Text() + "', '" + BookName.Text() + "', '" + BookPrice.Text() + "','" + BookAuthor.Text() + "','" + BookStatus.Text() + "')", con)
            ' cmd1 = New OracleCommand("insert into staff_table values ('" + .Text() + "', '" + TextBox8.Text() + "')", con)
            'cmd2 = New OracleCommand("insert into eidANDeeid_table values ('" + TextBox1.Text() + "', '" + TextBox9.Text() + "')", con)
            'cmd3 = New OracleCommand("insert into emp_address_table values ('" + TextBox6.Text() + "', '" + TextBox10.Text() + "', '" + TextBox11.Text() + "')", con)

            cmd.ExecuteNonQuery()
            'cmd1.ExecuteNonQuery()
            'cmd2.ExecuteNonQuery()
            'cmd3.ExecuteNonQuery()
            MessageBox.Show("DATA  INSERTED  SUCCESSFULLY")
            con.Close()
            'Me.Close()
            'Form2.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        con = New OracleConnection("Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root")

        con.Open()
        Try
            cmd = New OracleCommand("Update Bk_table Set bk_code = '" + BookCode.Text() + "', bk_name =  '" + BookName.Text() + "', bk_price= '" + BookPrice.Text() + "', bk_author= '" + BookAuthor.Text() +
                                    "',status='" + BookStatus.Text() + "' where bk_code = '" + BookCode.Text() + "'", con)
           
            cmd.ExecuteNonQuery()
                MessageBox.Show("DATA  UPDATED  SUCCESSFULLY")
            con.Close()
    
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Book_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        con = New OracleConnection("Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root")

        con.Open()
        Try
            cmd = New OracleCommand("DELETE From BK_table Where bk_code= '" + BookCode.Text() + "'", con)
 

            cmd.ExecuteNonQuery()
  
            MessageBox.Show("DATA  DELETED  SUCCESSFULLY")
            con.Close()
  
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ViewBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewBook.Click
        BookDetailsView.Show()
    End Sub
End Class