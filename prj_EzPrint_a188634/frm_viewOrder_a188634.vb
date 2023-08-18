Public Class frm_viewOrder_a188634
    Private Sub frm_viewOrder_a188634_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_list()
    End Sub
    Private Sub refresh_list()

        'Takes input of action = where we click, then calls refresh based on the product_id we click
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A188634 WHERE FLD_STATUS='" & "completed" & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_id.DataSource = mydatatable
        lst_id.DisplayMember = "FLD_ORDER_ID"

        'Refreshes the output
        refresh_text(lst_id.Text)
        refresh_grid(lst_id.Text)
    End Sub
    Private Sub refresh_text(id As String)

        'Display info of product_id we choose
        'INFO FROM TABLE: DESCRIPTION - qty,subtotal...based on which order. ORDER 1, prd_1 is 3 RM50, ORDER 2, prd_1 is 5 RM80

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A188634 WHERE FLD_ORDER_ID='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)


        lbl_inputID.Text = id
        lbl_inputDate.Text = mydatatable.Rows(0).Item("FLD_DATE")
        lbl_inputCustID.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")
        lbl_inputStaffID.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
        lbl_inputPayMethod.Text = mydatatable.Rows(0).Item("FLD_PAYMENT_METHOD")
        lbl_inputPrice.Text = "RM" & mydatatable.Rows(0).Item("FLD_TOTAL_PRICE")

    End Sub
    Private Sub refresh_grid(id As String)
        'Dim mysql As String = "SELECT FLD_PRODUCT_ID, FLD_PRODUCT_QTY, FLD_SUBTOTAL FROM TBL_ORDER_DESCRIPTION_A188634 WHERE FLD_ORDER_ID='" & id & "'"
        Dim mysql As String = "SELECT p.FLD_PRODUCT_NAME, p.FLD_PRICE, o.FLD_PRODUCT_QTY, o.FLD_SUBTOTAL FROM TBL_PRODUCT_A188634 p, TBL_ORDER_DESCRIPTION_A188634 o WHERE o.FLD_ORDER_ID='" & id & "' AND p.FLD_PRODUCT_ID = o.FLD_PRODUCT_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable

        grd_order.Columns(0).HeaderText = "Product Name"
        grd_order.Columns(1).HeaderText = "Price/net (RM)"
        grd_order.Columns(2).HeaderText = "Quantity"
        grd_order.Columns(3).HeaderText = "SUBTOTAL (RM)"

    End Sub

    'Private Sub cmb_dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_dept.SelectedIndexChanged
    '   refresh_grid(cmb_dept.Text)
    'End Sub
    Private Sub lst_id_MouseClick(sender As Object, e As EventArgs) Handles lst_id.MouseClick
        refresh_text(lst_id.Text)
        refresh_grid(lst_id.Text)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a188634.Show()
        Me.Hide()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Me.Refresh()
    End Sub

End Class