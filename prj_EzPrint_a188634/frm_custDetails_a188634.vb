Public Class frm_custDetails_a188634
    Dim current_id As String
    Dim pic_directory As String
    Dim defaultpicture As String = "pictures\nophoto.jpg"
    Private Sub frm_custDetails_a188634_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_list()
    End Sub
    Private Sub refresh_list()
        Dim mysql As String = "SELECT FLD_ID FROM TBL_CUSTOMER_A188634"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_id.DataSource = mydatatable
        lst_id.DisplayMember = "FLD_ID"

        refresh_text(lst_id.Text)
    End Sub
    Private Sub refresh_text(id As String)
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A188634 WHERE FLD_ID='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        current_id = id
        lbl_id.Text = current_id
        txt_name.Text = mydatatable.Rows(0).Item("FLD_NAME")
        txt_phoneNo.Text = "0" & mydatatable.Rows(0).Item("FLD_PHONE_NO")
        txt_address.Text = mydatatable.Rows(0).Item("FLD_ADDRESS")
        pic_customer.BackgroundImage = Image.FromFile("pictures/" & id & ".jpg")
        pic_directory = Nothing

    End Sub
    Private Sub lst_name_MouseClick(sender As Object, e As EventArgs) Handles lst_id.MouseClick
        refresh_text(lst_id.Text)
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the customer """ & current_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            Dim mysql As String = "DELETE FROM TBL_CUSTOMER_A188634 WHERE FLD_ID='" & current_id & "'"
            Dim mydatatable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

            Try
                myreader.Fill(mydatatable)
                'My.Computer.FileSystem.DeleteFile("pictures\" & current_id & ".jpg")   CANNOT DELETE PIC
                Beep()
                MsgBox("The customer """ & current_id & """ has been successfully deleted.")
            Catch ex As Exception
                Beep()
                MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)
            End Try

            refresh_list()

        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim mysql As String = "UPDATE TBL_CUSTOMER_A188634 SET FLD_NAME='" & txt_name.Text & "', FLD_PHONE_NO='" & txt_phoneNo.Text & "', FLD_ADDRESS='" & txt_address.Text & "' WHERE FLD_ID='" & current_id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try
            myreader.Fill(mydatatable)
            Beep()
            MsgBox("You have successfully updated the customer """ & current_id & """.")

            If Len(pic_directory) = 0 Then
            Else
                ' Update can save new pic but can't delete old photo
                My.Computer.FileSystem.DeleteFile("pictures\" & current_id & ".jpg")
                My.Computer.FileSystem.CopyFile(pic_directory, "pictures\" & current_id & ".jpg")
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
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_directory = OpenFileDialog1.FileName
        pic_customer.BackgroundImage = Image.FromFile(pic_directory)

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim newid As String = generate_id()
        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A188634 VALUES ('" & newid & "', '" & txt_name.Text & "', '" & txt_phoneNo.Text & "', '" & txt_address.Text & "')"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try
            myreader.Fill(mydatatable)
            Dim mes As String = "New customer has been inserted. Customer ID : '" & newid & "'"
            MsgBox(mes)

            'if pic_directory empty then use nophoto, if not empty then add in new one.
            If Len(pic_directory) = 0 Then
                My.Computer.FileSystem.CopyFile(defaultpicture, "pictures\" & newid & ".jpg")
            Else
                My.Computer.FileSystem.CopyFile(pic_directory, "pictures\" & newid & ".jpg")
            End If

        Catch ex As Exception
            Beep()
            MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)
        End Try



        refresh_list()

    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_ID) AS LASTID FROM TBL_CUSTOMER_A188634").Rows(0).Item("LASTID")
        Dim newid As String = "C" & Mid(lastid, 2) + 1

        Return newid
    End Function

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        refresh_list()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a188634.Show()
        Me.Hide()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        lbl_id.Text = ""
        txt_name.Text = ""
        txt_phoneNo.Text = ""
        txt_address.Text = ""
        pic_customer.BackgroundImage = Image.FromFile(defaultpicture)
        pic_directory = Nothing
    End Sub
End Class