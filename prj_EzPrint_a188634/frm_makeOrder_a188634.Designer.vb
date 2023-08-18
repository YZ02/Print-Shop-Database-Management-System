<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder_a188634
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_makeOrder = New System.Windows.Forms.Button()
        Me.lbl_inputSubtotal = New System.Windows.Forms.Label()
        Me.lbl_inputQty = New System.Windows.Forms.Label()
        Me.lbl_inputPrice = New System.Windows.Forms.Label()
        Me.lbl_inputName = New System.Windows.Forms.Label()
        Me.lbl_inputID = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.lbl_qty = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_cart = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_inputOrderID = New System.Windows.Forms.Label()
        Me.lbl_orderID = New System.Windows.Forms.Label()
        Me.cmb_custID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_staffID = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_payMethod = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.btn_minus = New System.Windows.Forms.Button()
        Me.btn_plus = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_makeOrder
        '
        Me.btn_makeOrder.Location = New System.Drawing.Point(207, 638)
        Me.btn_makeOrder.Name = "btn_makeOrder"
        Me.btn_makeOrder.Size = New System.Drawing.Size(171, 32)
        Me.btn_makeOrder.TabIndex = 21
        Me.btn_makeOrder.Text = "MAKE ORDER"
        Me.btn_makeOrder.UseVisualStyleBackColor = True
        '
        'lbl_inputSubtotal
        '
        Me.lbl_inputSubtotal.AutoSize = True
        Me.lbl_inputSubtotal.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputSubtotal.Location = New System.Drawing.Point(637, 302)
        Me.lbl_inputSubtotal.Name = "lbl_inputSubtotal"
        Me.lbl_inputSubtotal.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputSubtotal.TabIndex = 127
        Me.lbl_inputSubtotal.Text = "Label5"
        '
        'lbl_inputQty
        '
        Me.lbl_inputQty.AutoSize = True
        Me.lbl_inputQty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputQty.Location = New System.Drawing.Point(637, 264)
        Me.lbl_inputQty.Name = "lbl_inputQty"
        Me.lbl_inputQty.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputQty.TabIndex = 126
        Me.lbl_inputQty.Text = "Label4"
        '
        'lbl_inputPrice
        '
        Me.lbl_inputPrice.AutoSize = True
        Me.lbl_inputPrice.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputPrice.Location = New System.Drawing.Point(637, 223)
        Me.lbl_inputPrice.Name = "lbl_inputPrice"
        Me.lbl_inputPrice.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputPrice.TabIndex = 125
        Me.lbl_inputPrice.Text = "Label3"
        '
        'lbl_inputName
        '
        Me.lbl_inputName.AutoSize = True
        Me.lbl_inputName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputName.Location = New System.Drawing.Point(637, 185)
        Me.lbl_inputName.Name = "lbl_inputName"
        Me.lbl_inputName.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputName.TabIndex = 124
        Me.lbl_inputName.Text = "Label2"
        '
        'lbl_inputID
        '
        Me.lbl_inputID.AutoSize = True
        Me.lbl_inputID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputID.Location = New System.Drawing.Point(637, 149)
        Me.lbl_inputID.Name = "lbl_inputID"
        Me.lbl_inputID.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputID.TabIndex = 123
        Me.lbl_inputID.Text = "Label1"
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.Location = New System.Drawing.Point(552, 302)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(70, 18)
        Me.lbl_subtotal.TabIndex = 118
        Me.lbl_subtotal.Text = "Subtotal"
        '
        'lbl_qty
        '
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qty.Location = New System.Drawing.Point(552, 264)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(70, 18)
        Me.lbl_qty.TabIndex = 117
        Me.lbl_qty.Text = "Quantity"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(575, 223)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(47, 18)
        Me.lbl_price.TabIndex = 116
        Me.lbl_price.Text = "Price"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(570, 185)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(52, 18)
        Me.lbl_name.TabIndex = 115
        Me.lbl_name.Text = "Name"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(534, 149)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(88, 18)
        Me.lbl_id.TabIndex = 114
        Me.lbl_id.Text = "Product ID"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.BackgroundImage = Global.prj_EzPrint_a188634.My.Resources.Resources.ezprintt
        Me.btn_back.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_back.Location = New System.Drawing.Point(11, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(35, 31)
        Me.btn_back.TabIndex = 113
        Me.btn_back.Text = "<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_cart
        '
        Me.lbl_cart.AutoSize = True
        Me.lbl_cart.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cart.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cart.ForeColor = System.Drawing.Color.Olive
        Me.lbl_cart.Location = New System.Drawing.Point(20, 58)
        Me.lbl_cart.Name = "lbl_cart"
        Me.lbl_cart.Size = New System.Drawing.Size(109, 37)
        Me.lbl_cart.TabIndex = 112
        Me.lbl_cart.Text = "CART"
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(207, 138)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(278, 254)
        Me.pic_product.TabIndex = 111
        Me.pic_product.TabStop = False
        '
        'lbl_inputOrderID
        '
        Me.lbl_inputOrderID.AutoSize = True
        Me.lbl_inputOrderID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputOrderID.Location = New System.Drawing.Point(111, 108)
        Me.lbl_inputOrderID.Name = "lbl_inputOrderID"
        Me.lbl_inputOrderID.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputOrderID.TabIndex = 133
        Me.lbl_inputOrderID.Text = "Label1"
        '
        'lbl_orderID
        '
        Me.lbl_orderID.AutoSize = True
        Me.lbl_orderID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderID.Location = New System.Drawing.Point(24, 108)
        Me.lbl_orderID.Name = "lbl_orderID"
        Me.lbl_orderID.Size = New System.Drawing.Size(82, 18)
        Me.lbl_orderID.TabIndex = 132
        Me.lbl_orderID.Text = "Order ID :"
        '
        'cmb_custID
        '
        Me.cmb_custID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_custID.FormattingEnabled = True
        Me.cmb_custID.Location = New System.Drawing.Point(216, 424)
        Me.cmb_custID.Name = "cmb_custID"
        Me.cmb_custID.Size = New System.Drawing.Size(171, 24)
        Me.cmb_custID.TabIndex = 134
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 425)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 466)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Staff ID"
        '
        'cmb_staffID
        '
        Me.cmb_staffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_staffID.FormattingEnabled = True
        Me.cmb_staffID.Location = New System.Drawing.Point(216, 464)
        Me.cmb_staffID.Name = "cmb_staffID"
        Me.cmb_staffID.Size = New System.Drawing.Size(171, 24)
        Me.cmb_staffID.TabIndex = 136
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(151, 505)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 18)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 546)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 18)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "Payment Method"
        '
        'cmb_payMethod
        '
        Me.cmb_payMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_payMethod.FormattingEnabled = True
        Me.cmb_payMethod.Location = New System.Drawing.Point(216, 545)
        Me.cmb_payMethod.Name = "cmb_payMethod"
        Me.cmb_payMethod.Size = New System.Drawing.Size(171, 24)
        Me.cmb_payMethod.TabIndex = 140
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(134, 588)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 18)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "TOTAL"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(216, 589)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(100, 22)
        Me.txt_total.TabIndex = 144
        '
        'dtp_date
        '
        Me.dtp_date.Location = New System.Drawing.Point(216, 506)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(171, 22)
        Me.dtp_date.TabIndex = 146
        '
        'lst_id
        '
        Me.lst_id.BackColor = System.Drawing.Color.DarkKhaki
        Me.lst_id.ForeColor = System.Drawing.SystemColors.Window
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.ItemHeight = 16
        Me.lst_id.Location = New System.Drawing.Point(27, 138)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(135, 164)
        Me.lst_id.TabIndex = 147
        '
        'btn_minus
        '
        Me.btn_minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minus.Location = New System.Drawing.Point(708, 264)
        Me.btn_minus.Name = "btn_minus"
        Me.btn_minus.Size = New System.Drawing.Size(25, 23)
        Me.btn_minus.TabIndex = 148
        Me.btn_minus.Text = "-"
        Me.btn_minus.UseVisualStyleBackColor = True
        '
        'btn_plus
        '
        Me.btn_plus.Location = New System.Drawing.Point(739, 264)
        Me.btn_plus.Name = "btn_plus"
        Me.btn_plus.Size = New System.Drawing.Size(25, 23)
        Me.btn_plus.TabIndex = 149
        Me.btn_plus.Text = "+"
        Me.btn_plus.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(555, 346)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(80, 31)
        Me.btn_delete.TabIndex = 150
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(739, 638)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(98, 33)
        Me.btn_refresh.TabIndex = 157
        Me.btn_refresh.Text = "REFRESH"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'frm_makeorder_a188634
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 692)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_plus)
        Me.Controls.Add(Me.btn_minus)
        Me.Controls.Add(Me.lst_id)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_payMethod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_staffID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_custID)
        Me.Controls.Add(Me.lbl_inputOrderID)
        Me.Controls.Add(Me.lbl_orderID)
        Me.Controls.Add(Me.lbl_inputSubtotal)
        Me.Controls.Add(Me.lbl_inputQty)
        Me.Controls.Add(Me.lbl_inputPrice)
        Me.Controls.Add(Me.lbl_inputName)
        Me.Controls.Add(Me.lbl_inputID)
        Me.Controls.Add(Me.lbl_subtotal)
        Me.Controls.Add(Me.lbl_qty)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_cart)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.btn_makeOrder)
        Me.Name = "frm_makeorder_a188634"
        Me.Text = "frm_makeorder_a188634"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_makeOrder As Button
    Friend WithEvents lbl_inputSubtotal As Label
    Friend WithEvents lbl_inputQty As Label
    Friend WithEvents lbl_inputPrice As Label
    Friend WithEvents lbl_inputName As Label
    Friend WithEvents lbl_inputID As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents lbl_qty As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_cart As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_inputOrderID As Label
    Friend WithEvents lbl_orderID As Label
    Friend WithEvents cmb_custID As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_payMethod As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents cmb_staffID As ComboBox
    Friend WithEvents lst_id As ListBox
    Friend WithEvents btn_minus As Button
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_refresh As Button
End Class
