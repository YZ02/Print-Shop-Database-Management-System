Public Class frm_mainmenu_a188634

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        MsgBox("Goodbye!")
        End
    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_productOptions_a188634.Show()
        Me.Hide()
    End Sub

    Private Sub btn_product_Hover(sender As Object, e As EventArgs) Handles btn_product.MouseEnter
        btn_product.Text = ("See list")
    End Sub

    Private Sub btn_product_MouseLeave(sender As Object, e As EventArgs) Handles btn_product.MouseLeave
        btn_product.Text = ("PRODUCTS")
    End Sub

    'Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
    'frm_orderOptions_a188634.Show()
    'End Sub

    'Private Sub btn_order_Hover(sender As Object, e As EventArgs) Handles btn_order.MouseEnter
    '   btn_order.Text = ("See list")
    'End Sub

    'Private Sub btn_order_MouseLeave(sender As Object, e As EventArgs) Handles btn_order.MouseLeave
    '   btn_order.Text = ("ORDERS")
    'End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_custOptions_a188634.Show()
        Me.Hide()
    End Sub

    Private Sub btn_customer_Hover(sender As Object, e As EventArgs) Handles btn_customer.MouseEnter
        btn_customer.Text = ("See list")
    End Sub

    Private Sub btn_customer_MouseLeave(sender As Object, e As EventArgs) Handles btn_customer.MouseLeave
        btn_customer.Text = ("CUSTOMER")
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staffOptions_a188634.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staff_Hover(sender As Object, e As EventArgs) Handles btn_staff.MouseEnter
        btn_staff.Text = ("See list")
    End Sub

    Private Sub btn_staff_MouseLeave(sender As Object, e As EventArgs) Handles btn_staff.MouseLeave
        btn_staff.Text = ("STAFF")
    End Sub

    Private Sub frm_mainmenu_a188634_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_orderOptions_a188634.Show()
    End Sub

    Private Sub btn_order_desc_Hover(sender As Object, e As EventArgs) Handles btn_order.MouseEnter
        btn_order.Text = ("See list")
    End Sub

    Private Sub btn_order_desc_MouseLeave(sender As Object, e As EventArgs) Handles btn_order.MouseLeave
        btn_order.Text = ("ORDER")
    End Sub
End Class
