<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productView_a188634
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.btn_cart = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_funcType = New System.Windows.Forms.Label()
        Me.lbl_ink = New System.Windows.Forms.Label()
        Me.lbl_conn = New System.Windows.Forms.Label()
        Me.lbl_printSpeed = New System.Windows.Forms.Label()
        Me.lbl_weight = New System.Windows.Forms.Label()
        Me.lbl_inputID = New System.Windows.Forms.Label()
        Me.lbl_inputName = New System.Windows.Forms.Label()
        Me.lbl_inputPrice = New System.Windows.Forms.Label()
        Me.lbl_inputBrand = New System.Windows.Forms.Label()
        Me.lbl_inputFuncType = New System.Windows.Forms.Label()
        Me.lbl_inputInk = New System.Windows.Forms.Label()
        Me.lbl_inputWeight = New System.Windows.Forms.Label()
        Me.lbl_inputPrintSpeed = New System.Windows.Forms.Label()
        Me.lbl_inputConn = New System.Windows.Forms.Label()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btn_back.TabIndex = 90
        Me.btn_back.Text = "<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Olive
        Me.lbl_title.Location = New System.Drawing.Point(20, 58)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(181, 37)
        Me.lbl_title.TabIndex = 89
        Me.lbl_title.Text = "PRODUCT"
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(207, 114)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(278, 254)
        Me.pic_product.TabIndex = 88
        Me.pic_product.TabStop = False
        '
        'lst_id
        '
        Me.lst_id.BackColor = System.Drawing.Color.DarkKhaki
        Me.lst_id.ForeColor = System.Drawing.SystemColors.Window
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.ItemHeight = 16
        Me.lst_id.Location = New System.Drawing.Point(27, 114)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(135, 244)
        Me.lst_id.TabIndex = 87
        '
        'btn_cart
        '
        Me.btn_cart.Location = New System.Drawing.Point(975, 381)
        Me.btn_cart.Name = "btn_cart"
        Me.btn_cart.Size = New System.Drawing.Size(128, 33)
        Me.btn_cart.TabIndex = 91
        Me.btn_cart.Text = "ADD TO CART"
        Me.btn_cart.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(534, 125)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(88, 18)
        Me.lbl_id.TabIndex = 92
        Me.lbl_id.Text = "Product ID"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(570, 161)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(52, 18)
        Me.lbl_name.TabIndex = 93
        Me.lbl_name.Text = "Name"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(575, 199)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(47, 18)
        Me.lbl_price.TabIndex = 94
        Me.lbl_price.Text = "Price"
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(570, 240)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(52, 18)
        Me.lbl_brand.TabIndex = 95
        Me.lbl_brand.Text = "Brand"
        '
        'lbl_funcType
        '
        Me.lbl_funcType.AutoSize = True
        Me.lbl_funcType.BackColor = System.Drawing.Color.Transparent
        Me.lbl_funcType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_funcType.Location = New System.Drawing.Point(508, 278)
        Me.lbl_funcType.Name = "lbl_funcType"
        Me.lbl_funcType.Size = New System.Drawing.Size(114, 18)
        Me.lbl_funcType.TabIndex = 96
        Me.lbl_funcType.Text = "Function Type"
        '
        'lbl_ink
        '
        Me.lbl_ink.AutoSize = True
        Me.lbl_ink.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ink.Location = New System.Drawing.Point(531, 320)
        Me.lbl_ink.Name = "lbl_ink"
        Me.lbl_ink.Size = New System.Drawing.Size(91, 18)
        Me.lbl_ink.TabIndex = 97
        Me.lbl_ink.Text = "Ink System"
        '
        'lbl_conn
        '
        Me.lbl_conn.AutoSize = True
        Me.lbl_conn.BackColor = System.Drawing.Color.Transparent
        Me.lbl_conn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_conn.Location = New System.Drawing.Point(882, 125)
        Me.lbl_conn.Name = "lbl_conn"
        Me.lbl_conn.Size = New System.Drawing.Size(100, 18)
        Me.lbl_conn.TabIndex = 98
        Me.lbl_conn.Text = "Connectivity"
        '
        'lbl_printSpeed
        '
        Me.lbl_printSpeed.AutoSize = True
        Me.lbl_printSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lbl_printSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_printSpeed.Location = New System.Drawing.Point(865, 161)
        Me.lbl_printSpeed.Name = "lbl_printSpeed"
        Me.lbl_printSpeed.Size = New System.Drawing.Size(117, 18)
        Me.lbl_printSpeed.TabIndex = 99
        Me.lbl_printSpeed.Text = "Printing Speed"
        '
        'lbl_weight
        '
        Me.lbl_weight.AutoSize = True
        Me.lbl_weight.BackColor = System.Drawing.Color.Transparent
        Me.lbl_weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_weight.Location = New System.Drawing.Point(922, 199)
        Me.lbl_weight.Name = "lbl_weight"
        Me.lbl_weight.Size = New System.Drawing.Size(60, 18)
        Me.lbl_weight.TabIndex = 100
        Me.lbl_weight.Text = "Weight"
        '
        'lbl_inputID
        '
        Me.lbl_inputID.AutoSize = True
        Me.lbl_inputID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputID.Location = New System.Drawing.Point(637, 125)
        Me.lbl_inputID.Name = "lbl_inputID"
        Me.lbl_inputID.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputID.TabIndex = 101
        Me.lbl_inputID.Text = "Label1"
        '
        'lbl_inputName
        '
        Me.lbl_inputName.AutoSize = True
        Me.lbl_inputName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputName.Location = New System.Drawing.Point(637, 161)
        Me.lbl_inputName.Name = "lbl_inputName"
        Me.lbl_inputName.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputName.TabIndex = 102
        Me.lbl_inputName.Text = "Label2"
        '
        'lbl_inputPrice
        '
        Me.lbl_inputPrice.AutoSize = True
        Me.lbl_inputPrice.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputPrice.Location = New System.Drawing.Point(637, 199)
        Me.lbl_inputPrice.Name = "lbl_inputPrice"
        Me.lbl_inputPrice.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputPrice.TabIndex = 103
        Me.lbl_inputPrice.Text = "Label3"
        '
        'lbl_inputBrand
        '
        Me.lbl_inputBrand.AutoSize = True
        Me.lbl_inputBrand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputBrand.Location = New System.Drawing.Point(637, 240)
        Me.lbl_inputBrand.Name = "lbl_inputBrand"
        Me.lbl_inputBrand.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputBrand.TabIndex = 104
        Me.lbl_inputBrand.Text = "Label4"
        '
        'lbl_inputFuncType
        '
        Me.lbl_inputFuncType.AutoSize = True
        Me.lbl_inputFuncType.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputFuncType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputFuncType.Location = New System.Drawing.Point(637, 278)
        Me.lbl_inputFuncType.Name = "lbl_inputFuncType"
        Me.lbl_inputFuncType.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputFuncType.TabIndex = 105
        Me.lbl_inputFuncType.Text = "Label5"
        '
        'lbl_inputInk
        '
        Me.lbl_inputInk.AutoSize = True
        Me.lbl_inputInk.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputInk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputInk.Location = New System.Drawing.Point(637, 320)
        Me.lbl_inputInk.Name = "lbl_inputInk"
        Me.lbl_inputInk.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputInk.TabIndex = 106
        Me.lbl_inputInk.Text = "Label6"
        '
        'lbl_inputWeight
        '
        Me.lbl_inputWeight.AutoSize = True
        Me.lbl_inputWeight.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputWeight.Location = New System.Drawing.Point(1001, 199)
        Me.lbl_inputWeight.Name = "lbl_inputWeight"
        Me.lbl_inputWeight.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputWeight.TabIndex = 109
        Me.lbl_inputWeight.Text = "Label9"
        '
        'lbl_inputPrintSpeed
        '
        Me.lbl_inputPrintSpeed.AutoSize = True
        Me.lbl_inputPrintSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputPrintSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputPrintSpeed.Location = New System.Drawing.Point(1001, 161)
        Me.lbl_inputPrintSpeed.Name = "lbl_inputPrintSpeed"
        Me.lbl_inputPrintSpeed.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputPrintSpeed.TabIndex = 108
        Me.lbl_inputPrintSpeed.Text = "Label8"
        '
        'lbl_inputConn
        '
        Me.lbl_inputConn.AutoSize = True
        Me.lbl_inputConn.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputConn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputConn.Location = New System.Drawing.Point(1001, 125)
        Me.lbl_inputConn.Name = "lbl_inputConn"
        Me.lbl_inputConn.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputConn.TabIndex = 107
        Me.lbl_inputConn.Text = "Label7"
        '
        'frm_productView_a188634
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_EzPrint_a188634.My.Resources.Resources.ezprintt
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1139, 447)
        Me.Controls.Add(Me.lbl_inputWeight)
        Me.Controls.Add(Me.lbl_inputPrintSpeed)
        Me.Controls.Add(Me.lbl_inputConn)
        Me.Controls.Add(Me.lbl_inputInk)
        Me.Controls.Add(Me.lbl_inputFuncType)
        Me.Controls.Add(Me.lbl_inputBrand)
        Me.Controls.Add(Me.lbl_inputPrice)
        Me.Controls.Add(Me.lbl_inputName)
        Me.Controls.Add(Me.lbl_inputID)
        Me.Controls.Add(Me.lbl_weight)
        Me.Controls.Add(Me.lbl_printSpeed)
        Me.Controls.Add(Me.lbl_conn)
        Me.Controls.Add(Me.lbl_ink)
        Me.Controls.Add(Me.lbl_funcType)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_cart)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lst_id)
        Me.DoubleBuffered = True
        Me.Name = "frm_productView_a188634"
        Me.Text = "frm_viewProduct_a188634"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lst_id As ListBox
    Friend WithEvents btn_cart As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_funcType As Label
    Friend WithEvents lbl_ink As Label
    Friend WithEvents lbl_conn As Label
    Friend WithEvents lbl_printSpeed As Label
    Friend WithEvents lbl_weight As Label
    Friend WithEvents lbl_inputID As Label
    Friend WithEvents lbl_inputName As Label
    Friend WithEvents lbl_inputPrice As Label
    Friend WithEvents lbl_inputBrand As Label
    Friend WithEvents lbl_inputFuncType As Label
    Friend WithEvents lbl_inputInk As Label
    Friend WithEvents lbl_inputWeight As Label
    Friend WithEvents lbl_inputPrintSpeed As Label
    Friend WithEvents lbl_inputConn As Label
End Class
