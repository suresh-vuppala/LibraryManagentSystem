Imports Oracle.DataAccess.Client
Public Class Publisher
    Dim con As New OracleConnection
    Dim cmd, cmd1, cmd2, cmd3 As New OracleCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con = New OracleConnection("Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root")

        con.Open()
        Try
            cmd = New OracleCommand("insert into pub_table values ('" + txtPubName.Text() + "', '" + txtPubId.Text() + "', '" + txtPubAddress.Text() + "')", con)
                cmd.ExecuteNonQuery()
                 MessageBox.Show("DATA  INSERTED  SUCCESSFULLY")
            con.Close()
           Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Publisher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con = New OracleConnection("Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root")

        con.Open()
        Try
            cmd = New OracleCommand("DELETE From pub_table Where pub_id= '" + txtPubId.Text() + "'", con)
            cmd.ExecuteNonQuery()
             MessageBox.Show("DATA  DELETED  SUCCESSFULLY")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con = New OracleConnection("Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root")
        con.Open()
        Try
            cmd = New OracleCommand("Update pub_table Set pub_id = '" + txtPubId.Text() + "', pub_name =  '" + txtPubName.Text() + "', pub_address= '" + txtPubAddress.Text() + "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("DATA  UPDATED  SUCCESSFULLY")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PublisherDetailsView.Show()
    End Sub
End Class