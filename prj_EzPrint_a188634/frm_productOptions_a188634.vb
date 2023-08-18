Public Class frm_productOptions_a188634
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        frm_productView_a188634.Show()
        Me.Hide()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        frm_productDetails_a188634.Show()
        Me.Hide()
    End Sub
End Class