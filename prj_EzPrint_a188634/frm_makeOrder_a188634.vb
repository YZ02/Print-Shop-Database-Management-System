Public Class frm_makeorder_a188634
    Dim order_id As String
    Dim desc_id As String
    Dim prd_id As String
    Dim cust_id As String
    Dim staff_id As String
    Dim order_date As String
    Dim payMethod As String
    Dim total As Integer

    Private Sub frm_makeorder_a188634_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_list()
        calculateTotal()

        cmb_custID.DataSource = run_sql_query("SELECT FLD_ID FROM TBL_CUSTOMER_A188634 ORDER BY FLD_ID")
        cmb_custID.DisplayMember = "FLD_ID"

        cmb_staffID.DataSource = run_sql_query("SELECT FLD_STAFF_ID FROM TBL_STAFF_A188634 ORDER BY FLD_STAFF_ID")
        cmb_staffID.DisplayMember = "FLD_STAFF_ID"

        cmb_payMethod.Items.Add("CASH")
        cmb_payMethod.Items.Add("E-WALLET")
        cmb_payMethod.Items.Add("CREDIT/DEBIT")
        cmb_payMethod.SelectedIndex = 0

    End Sub
    Private Function generateOrder_id()
        ' if got incomplete take that one, if no.. generate new order id with default values
        Dim id As String
        Try
            id = run_sql_query("SELECT FLD_ORDER_ID AS ID FROM TBL_ORDER_A188634 WHERE FLD_STATUS='" & "incomplete" & "'").Rows(0).Item("ID")
        Catch ex As Exception
            Dim lastid As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A188634").Rows(0).Item("LASTID")
            Dim newid As String = "R" & Mid(lastid, 2) + 1
            Dim mysql As String = "INSERT INTO TBL_ORDER_A188634 VALUES ('" & newid & "', '" & "C1001" & "', '" & "T101" & "', '" & "no date" & "', '" & "CASH" & "', '" & 0 & "', '" & "incomplete" & "')"
            Dim mydatatable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
            myreader.Fill(mydatatable)
            id = newid
        End Try

        Return id
    End Function
    Private Sub calculateTotal()

        Dim mysql As String = "SELECT FLD_SUBTOTAL FROM TBL_ORDER_DESCRIPTION_A188634 WHERE FLD_ORDER_ID='" & order_id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        ' Takes summation of all subtotal
        Dim calculate As Integer = 0
        For Each row As DataRow In mydatatable.Rows
            calculate = calculate + row.Item("FLD_SUBTOTAL")
        Next row
        'Dim calculate = run_sql_query("SELECT MAX(FLD_ORDER_DESC_ID) AS LASTID FROM TBL_ORDER_DESCRIPTION_A188634").Rows(0).Item("LASTID")
        txt_total.Text = "RM" & calculate
        total = calculate
    End Sub

    Private Sub refresh_list()

        'Takes input of action = where we click, then calls refresh based on the product_id we click
        order_id = generateOrder_id()
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_ORDER_DESCRIPTION_A188634 WHERE FLD_ORDER_ID='" & order_id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_id.DataSource = mydatatable
        lst_id.DisplayMember = "FLD_PRODUCT_ID"

        'Refreshes the output
        refresh_text(lst_id.Text)
    End Sub
    Private Sub refresh_text(id As String)

        'Display info of product_id we choose
        'INFO FROM TABLE: DESCRIPTION - qty,subtotal...based on which order. ORDER 1, prd_1 is 3 RM50, ORDER 2, prd_1 is 5 RM80
        Dim mysql As String = "SELECT * FROM TBL_ORDER_DESCRIPTION_A188634 WHERE FLD_PRODUCT_ID='" & id & "' AND FLD_ORDER_ID='" & order_id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        Dim ysql As String = "SELECT * FROM TBL_PRODUCT_A188634 WHERE FLD_PRODUCT_ID='" & id & "'"
        Dim NEWmydatatable As New DataTable
        Dim yreader As New OleDb.OleDbDataAdapter(ysql, myconnection)
        yreader.Fill(NEWmydatatable)

        lbl_inputOrderID.Text = order_id
        prd_id = id
        Try
            desc_id = run_sql_query("SELECT FLD_ORDER_DESC_ID AS ID FROM TBL_ORDER_DESCRIPTION_A188634 WHERE FLD_ORDER_ID='" & order_id & "' AND FLD_PRODUCT_ID='" & prd_id & "'").Rows(0).Item("ID")
        Catch ex As Exception
            desc_id = ""
        End Try

        Try

            lbl_inputID.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
            lbl_inputName.Text = NEWmydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
            lbl_inputPrice.Text = "RM" & NEWmydatatable.Rows(0).Item("FLD_PRICE")
            lbl_inputQty.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_QTY")
            lbl_inputSubtotal.Text = "RM" & mydatatable.Rows(0).Item("FLD_SUBTOTAL")
            pic_product.BackgroundImage = Image.FromFile("pictures/" & id & ".png")
        Catch ex As Exception
            lbl_inputID.Text = ""
            lbl_inputName.Text = ""
            lbl_inputPrice.Text = ""
            lbl_inputQty.Text = ""
            lbl_inputSubtotal.Text = ""
            pic_product.BackgroundImage = Image.FromFile("pictures\nophoto.jpg")
        End Try

    End Sub
    Private Sub lst_id_MouseClick(sender As Object, e As EventArgs) Handles lst_id.MouseClick
        refresh_text(lst_id.Text)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a188634.Show()
        Me.Hide()
    End Sub

    Private Sub btn_makeOrder_Click(sender As Object, e As EventArgs) Handles btn_makeOrder.Click
        'Update order table

        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction
        Try
            Dim mysql As String = "UPDATE TBL_ORDER_A188634 SET FLD_CUSTOMER_ID='" & cust_id & "', FLD_STAFF_ID='" & staff_id & "', FLD_DATE='" & order_date & "'  , FLD_PAYMENT_METHOD='" & payMethod & "', FLD_TOTAL_PRICE='" & total & "', FLD_STATUS='" & "completed" & "' WHERE FLD_ORDER_ID='" & order_id & "'"
            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
            mywriter.ExecuteNonQuery()
            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("Transaction successful!")
            refresh_list()
        Catch ex As Exception
            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()
            refresh_list()
        End Try

        refresh_list()
        Me.Refresh()
    End Sub

    Private Sub cmb_custID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_custID.SelectedIndexChanged
        Dim val As String = cmb_custID.Text
        cust_id = val
    End Sub

    Private Sub cmb_staffID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_staffID.SelectedIndexChanged
        Dim val As String = cmb_staffID.Text
        staff_id = val
    End Sub
    Private Sub cmb_payMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_payMethod.SelectedIndexChanged
        payMethod = cmb_payMethod.Items(cmb_payMethod.SelectedIndex).ToString
    End Sub
    Private Sub dtp_date_ValueChanged(sender As Object, e As EventArgs) Handles dtp_date.ValueChanged
        Dim dt As String = dtp_date.Value.ToString
        order_date = dt
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        Dim price As Integer = run_sql_query("SELECT FLD_PRICE AS PRICE FROM TBL_PRODUCT_A188634 WHERE FLD_PRODUCT_ID='" & prd_id & "'").Rows(0).Item("PRICE")
        Dim count As Integer = run_sql_query("SELECT FLD_PRODUCT_QTY AS QTY FROM TBL_ORDER_DESCRIPTION_A188634 WHERE FLD_ORDER_DESC_ID='" & desc_id & "'").Rows(0).Item("QTY")
        count = count - 1
        Dim subtotal = price * count
        Dim mysql As String = "UPDATE TBL_ORDER_DESCRIPTION_A188634 SET FLD_PRODUCT_QTY='" & count & "', FLD_SUBTOTAL='" & subtotal & "' WHERE FLD_ORDER_DESC_ID='" & desc_id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        refresh_list()
        calculateTotal()

    End Sub

    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        Dim price As Integer = run_sql_query("SELECT FLD_PRICE AS PRICE FROM TBL_PRODUCT_A188634 WHERE FLD_PRODUCT_ID='" & prd_id & "'").Rows(0).Item("PRICE")

        Dim count As Integer = run_sql_query("SELECT FLD_PRODUCT_QTY AS QTY FROM TBL_ORDER_DESCRIPTION_A188634 WHERE FLD_ORDER_DESC_ID='" & desc_id & "'").Rows(0).Item("QTY")
        count = count + 1
        Dim subtotal = price * count
        Dim mysql As String = "UPDATE TBL_ORDER_DESCRIPTION_A188634 SET FLD_PRODUCT_QTY='" & count & "', FLD_SUBTOTAL='" & subtotal & "' WHERE FLD_ORDER_DESC_ID='" & desc_id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        refresh_list()
        calculateTotal()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim mysql As String = "DELETE FROM TBL_ORDER_DESCRIPTION_A188634 WHERE FLD_ORDER_DESC_ID='" & desc_id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        refresh_list()
        calculateTotal()
    End Sub
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Me.Refresh()
    End Sub
End Class