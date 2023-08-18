Public Class frm_productDetails_a188634
    Dim current_id As String
    Dim pic_directory As String
    Dim defaultpicture As String = "pictures\nophoto.jpg"
    Private Sub frm_productDetails_a188634_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_list()
        cmb1()
        cmb2()
        cmb3()
        cmb4()
    End Sub
    Private Sub cmb1()
        Dim mysql As String = "SELECT FLD_BRAND FROM QRY_BRAND_LIST"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_brand.DataSource = mydatatable
        cmb_brand.DisplayMember = "FLD_BRAND"
    End Sub
    Private Sub cmb2()
        Dim mysql As String = "SELECT FLD_FUNCTION_TYPE FROM QRY_FUNCTYPE_LIST"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_funcType.DataSource = mydatatable
        cmb_funcType.DisplayMember = "FLD_FUNCTION_TYPE"
    End Sub
    Private Sub cmb3()
        Dim mysql As String = "SELECT FLD_INK_SYSTEM FROM QRY_INK_LIST"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_ink.DataSource = mydatatable
        cmb_ink.DisplayMember = "FLD_INK_SYSTEM"
    End Sub
    Private Sub cmb4()
        Dim mysql As String = "SELECT FLD_CONNECTIVITY FROM QRY_CONN_LIST"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_conn.DataSource = mydatatable
        cmb_conn.DisplayMember = "FLD_CONNECTIVITY"
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

        current_id = id
        lbl_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        cmb_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        cmb_funcType.Text = mydatatable.Rows(0).Item("FLD_FUNCTION_TYPE")
        cmb_ink.Text = mydatatable.Rows(0).Item("FLD_INK_SYSTEM")
        cmb_conn.Text = mydatatable.Rows(0).Item("FLD_CONNECTIVITY")
        txt_printSpeed.Text = mydatatable.Rows(0).Item("FLD_PRINTING_SPEED")
        txt_weight.Text = mydatatable.Rows(0).Item("FLD_WEIGHT")
        pic_product.BackgroundImage = Image.FromFile("pictures/" & lbl_id.Text & ".png")
        pic_directory = Nothing

    End Sub

    Private Sub lst_id_MouseClick(sender As Object, e As EventArgs) Handles lst_id.MouseClick
        refresh_text(lst_id.Text)
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            Dim mysql As String = "DELETE FROM TBL_PRODUCT_A188634 WHERE FLD_PRODUCT_ID='" & current_id & "'"
            Dim mydatatable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

            Try
                myreader.Fill(mydatatable)
                'My.Computer.FileSystem.MoveFile("C:\a188634_EzPrint\prj_EzPrint_a188634\prj_EzPrint_a188634\bin\Debug\pictures\" & current_id & ".png", "C:\Users\PC\Downloads\picframe", FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                'My.Computer.FileSystem.DeleteFile("C:\a188634_EzPrint\prj_EzPrint_a188634\prj_EzPrint_a188634\bin\Debug\pictures\" & current_id & ".png")
                'My.Computer.FileSystem.CopyFile(defaultpicture, "pictures\" & current_id & ".png")
                'My.Computer.FileSystem.DeleteFile("pictures\" & current_id & ".png")
                Beep()
                MsgBox("The product """ & current_id & """ has been successfully deleted.")
            Catch ex As Exception
                Beep()
                MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)
            End Try

            refresh_list()

        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim mysql As String = "UPDATE TBL_PRODUCT_A188634 SET FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_PRICE='" & txt_price.Text & "', FLD_BRAND='" & cmb_brand.Text & "', FLD_FUNCTION_TYPE='" & cmb_funcType.Text & "', FLD_INK_SYSTEM='" & cmb_ink.Text & "', FLD_CONNECTIVITY='" & cmb_conn.Text & "', FLD_PRINTING_SPEED='" & txt_printSpeed.Text & "', FLD_WEIGHT='" & txt_weight.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try
            myreader.Fill(mydatatable)
            Beep()
            MsgBox("You have successfully updated the product """ & current_id & """.")

            If Len(pic_directory) = 0 Then
            Else
                ' Update can save new pic but can't delete old photo CANNNN EDYY
                My.Computer.FileSystem.DeleteFile("pictures\" & current_id & ".png")
                My.Computer.FileSystem.CopyFile(pic_directory, "pictures\" & current_id & ".png")
            End If

        Catch ex As Exception
            Beep()
            MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)
        End Try

        refresh_list()
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "PNG files (*.png)|*.png"
        OpenFileDialog1.ShowDialog()

        pic_directory = OpenFileDialog1.FileName
        pic_product.BackgroundImage = Image.FromFile(pic_directory) ' dah click xleh pangkah nnti error

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim newid As String = generate_id()
        Dim mysql As String = "INSERT INTO TBL_PRODUCT_A188634 VALUES ('" & newid & "', '" & txt_name.Text & "', '" & txt_price.Text & "', '" & cmb_brand.Text & "', '" & cmb_funcType.Text & "', '" & cmb_ink.Text & "', '" & cmb_conn.Text & "', '" & txt_printSpeed.Text & "', '" & txt_weight.Text & "')"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try
            myreader.Fill(mydatatable)
            Dim mes As String = "New product has been inserted. Product ID : '" & newid & "'"
            MsgBox(mes)

            ' if pic_directory empty then use nophoto, if not empty then add in new one.
            If Len(pic_directory) = 0 Then
                My.Computer.FileSystem.CopyFile(defaultpicture, "pictures\" & newid & ".png")
            Else
                My.Computer.FileSystem.CopyFile(pic_directory, "pictures\" & newid & ".png")
            End If

        Catch ex As Exception
            Beep()
            MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)
        End Try

        refresh_list()

    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCT_A188634").Rows(0).Item("LASTID")
        Dim newid As String = "P" & Mid(lastid, 2) + 1

        Return newid
    End Function

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        refresh_list()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        lbl_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        cmb_brand.Text = ""
        cmb_funcType.Text = ""
        cmb_ink.Text = ""
        cmb_conn.Text = ""
        txt_printSpeed.Text = ""
        txt_weight.Text = ""
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)
        pic_directory = Nothing
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a188634.Show()
        Me.Hide()
    End Sub
End Class