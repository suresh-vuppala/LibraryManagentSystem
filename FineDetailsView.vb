Imports Oracle.DataAccess.Client
Public Class FineDetailsView
    Dim cmd2 As New OracleCommand
    Dim ds As DataSet
    Dim da As OracleDataAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = "Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root"
        Dim con2 As New OracleConnection(str)
        con2.Open()
        da = New OracleDataAdapter("Select * from Fine_table", con2)
        ds = New DataSet
        da.Fill(ds, "fine_table")
        DataGridView1.DataMember = "fine_table"
        DataGridView1.DataSource = ds
    End Sub
End Class