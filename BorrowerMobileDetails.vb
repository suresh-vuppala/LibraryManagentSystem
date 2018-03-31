Imports Oracle.DataAccess.Client
Public Class BorrowerMobileDetails
    Dim cmd2 As New OracleCommand
    Dim ds As DataSet
    Dim da As OracleDataAdapter
    Private Sub BorrowerMobileDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str As String = "Data Source=Samarpit;Persist Security Info=True;User ID=system;Password=root"
        Dim con2 As New OracleConnection(str)
        con2.Open()
        da = New OracleDataAdapter("Select * from b_prn_with_B_MobNO", con2)
        ds = New DataSet
        da.Fill(ds, "b_prn_with_B_MobNO")
        DataGridView1.DataMember = "b_prn_with_B_MobNO"
        DataGridView1.DataSource = ds
    End Sub
End Class