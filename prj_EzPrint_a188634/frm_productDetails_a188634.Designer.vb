<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productDetails_a188634
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
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.txt_weight = New System.Windows.Forms.TextBox()
        Me.txt_printSpeed = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.lbl_message = New System.Windows.Forms.Label()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmb_brand = New System.Windows.Forms.ComboBox()
        Me.cmb_funcType = New System.Windows.Forms.ComboBox()
        Me.cmb_ink = New System.Windows.Forms.ComboBox()
        Me.cmb_conn = New System.Windows.Forms.ComboBox()
        Me.lbl_printSpeed = New System.Windows.Forms.Label()
        Me.lbl_weight = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_rm = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(208, 114)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(278, 254)
        Me.pic_product.TabIndex = 11
        Me.pic_product.TabStop = False
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(536, 171)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(93, 22)
        Me.txt_price.TabIndex = 10
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(501, 143)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(278, 22)
        Me.txt_name.TabIndex = 9
        '
        'lst_id
        '
        Me.lst_id.BackColor = System.Drawing.Color.DarkKhaki
        Me.lst_id.ForeColor = System.Drawing.SystemColors.Window
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.ItemHeight = 16
        Me.lst_id.Location = New System.Drawing.Point(28, 114)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(135, 196)
        Me.lst_id.TabIndex = 7
        '
        'txt_weight
        '
        Me.txt_weight.Location = New System.Drawing.Point(605, 318)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Size = New System.Drawing.Size(47, 22)
        Me.txt_weight.TabIndex = 17
        '
        'txt_printSpeed
        '
        Me.txt_printSpeed.Location = New System.Drawing.Point(501, 318)
        Me.txt_printSpeed.Name = "txt_printSpeed"
        Me.txt_printSpeed.Size = New System.Drawing.Size(47, 22)
        Me.txt_printSpeed.TabIndex = 16
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Olive
        Me.lbl_title.Location = New System.Drawing.Point(21, 58)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(181, 37)
        Me.lbl_title.TabIndex = 18
        Me.lbl_title.Text = "PRODUCT"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(326, 475)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(110, 34)
        Me.btn_delete.TabIndex = 73
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(208, 475)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(112, 34)
        Me.btn_update.TabIndex = 72
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(208, 515)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(228, 34)
        Me.btn_insert.TabIndex = 71
        Me.btn_insert.Text = "INSERT AS NEW PRODUCT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(684, 515)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(95, 34)
        Me.btn_refresh.TabIndex = 74
        Me.btn_refresh.Text = "REFRESH"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'lbl_message
        '
        Me.lbl_message.AutoSize = True
        Me.lbl_message.BackColor = System.Drawing.Color.Transparent
        Me.lbl_message.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_message.Location = New System.Drawing.Point(205, 416)
        Me.lbl_message.Name = "lbl_message"
        Me.lbl_message.Size = New System.Drawing.Size(470, 16)
        Me.lbl_message.TabIndex = 75
        Me.lbl_message.Text = "The form is editable, please click the buttons below to save changes"
        '
        'btn_picture
        '
        Me.btn_picture.Location = New System.Drawing.Point(208, 379)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(124, 30)
        Me.btn_picture.TabIndex = 76
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cmb_brand
        '
        Me.cmb_brand.FormattingEnabled = True
        Me.cmb_brand.Location = New System.Drawing.Point(501, 198)
        Me.cmb_brand.Name = "cmb_brand"
        Me.cmb_brand.Size = New System.Drawing.Size(278, 24)
        Me.cmb_brand.TabIndex = 77
        '
        'cmb_funcType
        '
        Me.cmb_funcType.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.cmb_funcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_funcType.FormattingEnabled = True
        Me.cmb_funcType.Location = New System.Drawing.Point(501, 228)
        Me.cmb_funcType.Name = "cmb_funcType"
        Me.cmb_funcType.Size = New System.Drawing.Size(278, 24)
        Me.cmb_funcType.TabIndex = 78
        '
        'cmb_ink
        '
        Me.cmb_ink.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.cmb_ink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ink.FormattingEnabled = True
        Me.cmb_ink.Location = New System.Drawing.Point(501, 258)
        Me.cmb_ink.Name = "cmb_ink"
        Me.cmb_ink.Size = New System.Drawing.Size(278, 24)
        Me.cmb_ink.TabIndex = 79
        '
        'cmb_conn
        '
        Me.cmb_conn.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.cmb_conn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_conn.FormattingEnabled = True
        Me.cmb_conn.Location = New System.Drawing.Point(501, 288)
        Me.cmb_conn.Name = "cmb_conn"
        Me.cmb_conn.Size = New System.Drawing.Size(278, 24)
        Me.cmb_conn.TabIndex = 80
        '
        'lbl_printSpeed
        '
        Me.lbl_printSpeed.AutoSize = True
        Me.lbl_printSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lbl_printSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_printSpeed.Location = New System.Drawing.Point(552, 319)
        Me.lbl_printSpeed.Name = "lbl_printSpeed"
        Me.lbl_printSpeed.Size = New System.Drawing.Size(35, 15)
        Me.lbl_printSpeed.TabIndex = 81
        Me.lbl_printSpeed.Text = "ppm"
        '
        'lbl_weight
        '
        Me.lbl_weight.AutoSize = True
        Me.lbl_weight.BackColor = System.Drawing.Color.Transparent
        Me.lbl_weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_weight.Location = New System.Drawing.Point(658, 321)
        Me.lbl_weight.Name = "lbl_weight"
        Me.lbl_weight.Size = New System.Drawing.Size(22, 15)
        Me.lbl_weight.TabIndex = 82
        Me.lbl_weight.Text = "kg"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Franklin Gothic Demi", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(502, 114)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(61, 21)
        Me.lbl_id.TabIndex = 83
        Me.lbl_id.Text = "Label1"
        '
        'lbl_rm
        '
        Me.lbl_rm.AutoSize = True
        Me.lbl_rm.BackColor = System.Drawing.Color.Transparent
        Me.lbl_rm.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rm.Location = New System.Drawing.Point(502, 175)
        Me.lbl_rm.Name = "lbl_rm"
        Me.lbl_rm.Size = New System.Drawing.Size(29, 15)
        Me.lbl_rm.TabIndex = 84
        Me.lbl_rm.Text = "RM"
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(704, 345)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 85
        Me.btn_clear.Text = "clear all"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.BackgroundImage = Global.prj_EzPrint_a188634.My.Resources.Resources.ezprintt
        Me.btn_back.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_back.Location = New System.Drawing.Point(12, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(35, 31)
        Me.btn_back.TabIndex = 86
        Me.btn_back.Text = "<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'frm_productDetails_a188634
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_EzPrint_a188634.My.Resources.Resources.ezprintt
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(824, 583)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.lbl_rm)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_weight)
        Me.Controls.Add(Me.lbl_printSpeed)
        Me.Controls.Add(Me.cmb_conn)
        Me.Controls.Add(Me.cmb_ink)
        Me.Controls.Add(Me.cmb_funcType)
        Me.Controls.Add(Me.cmb_brand)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.lbl_message)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.txt_weight)
        Me.Controls.Add(Me.txt_printSpeed)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lst_id)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "frm_productDetails_a188634"
        Me.Text = "Product Details"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lst_id As ListBox
    Friend WithEvents txt_weight As TextBox
    Friend WithEvents txt_printSpeed As TextBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents lbl_message As Label
    Friend WithEvents btn_picture As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cmb_brand As ComboBox
    Friend WithEvents cmb_funcType As ComboBox
    Friend WithEvents cmb_ink As ComboBox
    Friend WithEvents cmb_conn As ComboBox
    Friend WithEvents lbl_printSpeed As Label
    Friend WithEvents lbl_weight As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_rm As Label
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_back As Button
End Class
