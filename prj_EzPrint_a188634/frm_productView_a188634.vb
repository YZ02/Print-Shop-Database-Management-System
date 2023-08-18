Public Class frm_productView_a188634
    Dim prd_id As String
    Dim pic_directory As String
    Dim defaultpicture As String = "C:\a188634_EzPrint\prj_EzPrint_a188634\prj_EzPrint_a188634\bin\Debug\pictures\nophoto.jpg"
    Private Sub frm_productView_a188634_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_list()
    End Sub
    Private Sub refresh_list()
        'Takes input of action = where we click, then calls refresh based on the id we click
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCT_A188634"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_id.DataSource = mydatatable
        lst_id.DisplayMember = "FLD_PRODUCT_ID"

        'Refreshes the output
        refresh_text(lst_id.Text)
    End Sub
    Private Sub refresh_text(id As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A188634 WHERE FLD_PRODUCT_ID='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        prd_id = id
        lbl_inputID.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        lbl_inputName.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        lbl_inputPrice.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        lbl_inputBrand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        lbl_inputFuncType.Text = mydatatable.Rows(0).Item("FLD_FUNCTION_TYPE")
        lbl_inputInk.Text = mydatatable.Rows(0).Item("FLD_INK_SYSTEM")
        lbl_inputConn.Text = mydatatable.Rows(0).Item("FLD_CONNECTIVITY")
        lbl_inputPrintSpeed.Text = mydatatable.Rows(0).Item("FLD_PRINTING_SPEED") & " ppm"
        lbl_inputWeight.Text = mydatatable.Rows(0).Item("FLD_WEIGHT") & " kg"
        pic_product.BackgroundImage = Image.FromFile("pictures/" & lbl_inputID.Text & ".png")
        pic_directory = Nothing

    End Sub

    Private Sub lst_id_MouseClick(sender As Object, e As EventArgs) Handles lst_id.MouseClick
        refresh_text(lst_id.Text)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a188634.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cart_Click(sender As Object, e As EventArgs) Handles btn_cart.Click

        ' Auto generate order Id in tbl_order, auto generate order_desc_id and fill up order_id_product_id, qty
        ' When click again, if order_id status not complete, it will go into that order_id again. generate order_desc_id and fill prd_id, qty
        ' When click the already inserted prd, it checks if prd_id is already in order_id, if yes, add qty
        ' When done, go to make order, click make order, status change to completed

        ' get and insert order_id, order_desc_id, prd_id, qty
        Dim order_id As String = generate_orderid()

        'Dim desc_id As String = generate_descid(order_id, prd_id)
        ' If no lastid (table empty), then generate first id
        Dim desc_id As String
        Dim insertnew As Boolean
        Try
            ' generate new desc_id when the order_id doesn't have the product_id
            ' if already have, return the existing desc_id 
            Dim prd As Integer = run_sql_query("SELECT * FROM TBL_ORDER_DESCRIPTION_A188634 WHERE FLD_ORDER_ID='" & order_id & "' AND FLD_PRODUCT_ID='" & prd_id & "'").Rows.Count
            If (prd = 0) Then
                'MsgBox("New desc_id Is generated because current order don't have this product")
                Dim lastid As String = run_sql_query("SELECT MAX(FLD_ORDER_DESC_ID) AS LASTID FROM TBL_ORDER_DESCRIPTION_A188634").Rows(0).Item("LASTID")
                desc_id = "D" & Mid(lastid, 2) + 1
                insertnew = True
            Else
                'MsgBox("New desc_id is not generated because current order already have this product, so use the existing desc_id")
                desc_id = run_sql_query("SELECT FLD_ORDER_DESC_ID AS FLD_ID FROM TBL_ORDER_DESCRIPTION_A188634 WHERE FLD_ORDER_ID='" & order_id & "' AND FLD_PRODUCT_ID='" & prd_id & "'").Rows(0).Item("FLD_ID")
                insertnew = False
            End If

        Catch ex As Exception
            'MsgBox("Table is empty, D101 is generated as first desc_id")
            desc_id = "D101"
            insertnew = True
        End Try

        Dim price As Integer = run_sql_query("SELECT FLD_PRICE AS PRICE FROM TBL_PRODUCT_A188634 WHERE FLD_PRODUCT_ID='" & prd_id & "'").Rows(0).Item("PRICE")
        If (insertnew) Then
            Dim count As Integer = 1
            'MsgBox("Inserting '" & desc_id & "', '" & order_id & "', '" & prd_id & "', '" & count & "', '" & price & "'")
            Dim mysql As String = "INSERT INTO TBL_ORDER_DESCRIPTION_A188634 VALUES ('" & desc_id & "', '" & order_id & "', '" & prd_id & "', '" & count & "', '" & price & "')"
            Dim mydatatable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
            myreader.Fill(mydatatable)
        Else

            Dim count As Integer = run_sql_query("SELECT FLD_PRODUCT_QTY AS QTY FROM TBL_ORDER_DESCRIPTION_A188634 WHERE FLD_ORDER_DESC_ID='" & desc_id & "'").Rows(0).Item("QTY")
            count = count + 1
            Dim subtotal = price * count
            Dim mysql As String = "UPDATE TBL_ORDER_DESCRIPTION_A188634 SET FLD_PRODUCT_QTY='" & count & "', FLD_SUBTOTAL='" & subtotal & "' WHERE FLD_ORDER_DESC_ID='" & desc_id & "'"
            Dim mydatatable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
            myreader.Fill(mydatatable)
        End If


        refresh_list()

    End Sub
    Private Function generate_orderid() As String
        'If no lastid (table empty), then generate first id
        Dim newid As String
        Dim tmp As String = ""
        Try
            ' If lastid status is completed generate new one, if not use lastid
            Dim lastid As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A188634").Rows(0).Item("LASTID")

            Dim status As String = run_sql_query("SELECT FLD_STATUS AS STATUS FROM TBL_ORDER_A188634 WHERE FLD_ORDER_ID='" & lastid & "'").Rows(0).Item("STATUS")
            If (status = "completed") Then
                newid = "R" & Mid(lastid, 2) + 1
                Dim mysql As String = "INSERT INTO TBL_ORDER_A188634 VALUES ('" & newid & "', '" & "C1001" & "', '" & "T101" & "', '" & "5/31/1993" & "', '" & "CASH" & "', '" & 0 & "', '" & "incomplete" & "')"
                Dim mydatatable As New DataTable
                Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
                myreader.Fill(mydatatable)
            Else
                newid = lastid
            End If

        Catch ex As Exception
            newid = "R101"
            Dim mysql As String = "INSERT INTO TBL_ORDER_A188634 VALUES ('" & newid & "', '" & "C1001" & "', '" & "T101" & "', '" & "5/31/1993" & "', '" & "CASH" & "',, '" & 0 & "', '" & "incomplete" & "')"
            Dim mydatatable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
            myreader.Fill(mydatatable)
        End Try

        Return newid
    End Function
End Class