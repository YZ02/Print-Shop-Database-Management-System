Public Class frm_custView_a188634
    Private Sub frm_custView_a188634_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_list()
    End Sub
    Private Sub refresh_list()
        'Takes input of action = where we click, then calls refresh based on the id we click
        Dim mysql As String = "SELECT FLD_ID FROM TBL_CUSTOMER_A188634"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_id.DataSource = mydatatable
        lst_id.DisplayMember = "FLD_ID"

        'Refreshes the output
        refresh_text(lst_id.Text)
    End Sub
    Private Sub refresh_text(id As String)
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A188634 WHERE FLD_ID='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lbl_inputID.Text = mydatatable.Rows(0).Item("FLD_ID")
        lbl_inputName.Text = mydatatable.Rows(0).Item("FLD_NAME")
        lbl_inputPhoneNo.Text = "0" & mydatatable.Rows(0).Item("FLD_PHONE_NO")
        lbl_inputAddress.Text = mydatatable.Rows(0).Item("FLD_ADDRESS")
        pic_customer.BackgroundImage = Image.FromFile("pictures/" & id & ".jpg")

    End Sub

    Private Sub lst_id_MouseClick(sender As Object, e As EventArgs) Handles lst_id.MouseClick
        refresh_text(lst_id.Text)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a188634.Show()
        Me.Hide()
    End Sub
End Class