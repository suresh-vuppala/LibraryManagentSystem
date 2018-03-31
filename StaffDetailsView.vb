Imports Oracle.DataAccess.Client
Public Class StaffDetailsView
    Dim cmd2 As New OracleCommand
    Dim ds As DataSet
    Dim da As OracleDataAdapter
    Private Sub StaffDetailsView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str As String = "Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root"
        Dim con2 As New OracleConnection(str)
        con2.Open()
        da = New OracleDataAdapter("Select * from staff_table", con2)
        ds = New DataSet
        da.Fill(ds, "staff_table")
        DataGridView1.DataMember = "staff_table"
        DataGridView1.DataSource = ds
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class