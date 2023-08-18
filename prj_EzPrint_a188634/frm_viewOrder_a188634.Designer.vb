<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_viewOrder_a188634
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_inputStaffID = New System.Windows.Forms.Label()
        Me.lbl_inputCustID = New System.Windows.Forms.Label()
        Me.lbl_inputPrice = New System.Windows.Forms.Label()
        Me.lbl_inputDate = New System.Windows.Forms.Label()
        Me.lbl_staffID = New System.Windows.Forms.Label()
        Me.lbl_custID = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_cart = New System.Windows.Forms.Label()
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_inputPayMethod = New System.Windows.Forms.Label()
        Me.lbl_payMethod = New System.Windows.Forms.Label()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.lbl_inputID = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_inputStaffID
        '
        Me.lbl_inputStaffID.AutoSize = True
        Me.lbl_inputStaffID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputStaffID.Location = New System.Drawing.Point(380, 83)
        Me.lbl_inputStaffID.Name = "lbl_inputStaffID"
        Me.lbl_inputStaffID.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputStaffID.TabIndex = 148
        Me.lbl_inputStaffID.Text = "Label5"
        '
        'lbl_inputCustID
        '
        Me.lbl_inputCustID.AutoSize = True
        Me.lbl_inputCustID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputCustID.Location = New System.Drawing.Point(419, 47)
        Me.lbl_inputCustID.Name = "lbl_inputCustID"
        Me.lbl_inputCustID.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputCustID.TabIndex = 147
        Me.lbl_inputCustID.Text = "Label4"
        '
        'lbl_inputPrice
        '
        Me.lbl_inputPrice.AutoSize = True
        Me.lbl_inputPrice.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputPrice.Location = New System.Drawing.Point(691, 83)
        Me.lbl_inputPrice.Name = "lbl_inputPrice"
        Me.lbl_inputPrice.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputPrice.TabIndex = 146
        Me.lbl_inputPrice.Text = "Label3"
        '
        'lbl_inputDate
        '
        Me.lbl_inputDate.AutoSize = True
        Me.lbl_inputDate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputDate.Location = New System.Drawing.Point(80, 83)
        Me.lbl_inputDate.Name = "lbl_inputDate"
        Me.lbl_inputDate.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputDate.TabIndex = 145
        Me.lbl_inputDate.Text = "Label2"
        '
        'lbl_staffID
        '
        Me.lbl_staffID.AutoSize = True
        Me.lbl_staffID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffID.Location = New System.Drawing.Point(310, 83)
        Me.lbl_staffID.Name = "lbl_staffID"
        Me.lbl_staffID.Size = New System.Drawing.Size(64, 18)
        Me.lbl_staffID.TabIndex = 143
        Me.lbl_staffID.Text = "Staff ID"
        '
        'lbl_custID
        '
        Me.lbl_custID.AutoSize = True
        Me.lbl_custID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_custID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custID.Location = New System.Drawing.Point(310, 47)
        Me.lbl_custID.Name = "lbl_custID"
        Me.lbl_custID.Size = New System.Drawing.Size(103, 18)
        Me.lbl_custID.TabIndex = 142
        Me.lbl_custID.Text = "Customer ID"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(586, 83)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(90, 18)
        Me.lbl_price.TabIndex = 141
        Me.lbl_price.Text = "Total Price"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(31, 83)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(43, 18)
        Me.lbl_date.TabIndex = 140
        Me.lbl_date.Text = "Date"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.BackgroundImage = Global.prj_EzPrint_a188634.My.Resources.Resources.ezprintt
        Me.btn_back.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_back.Location = New System.Drawing.Point(14, 16)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(35, 31)
        Me.btn_back.TabIndex = 138
        Me.btn_back.Text = "<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_cart
        '
        Me.lbl_cart.AutoSize = True
        Me.lbl_cart.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cart.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cart.ForeColor = System.Drawing.Color.Olive
        Me.lbl_cart.Location = New System.Drawing.Point(23, 62)
        Me.lbl_cart.Name = "lbl_cart"
        Me.lbl_cart.Size = New System.Drawing.Size(161, 37)
        Me.lbl_cart.TabIndex = 137
        Me.lbl_cart.Text = "INVOICE"
        '
        'lst_id
        '
        Me.lst_id.BackColor = System.Drawing.Color.DarkKhaki
        Me.lst_id.ForeColor = System.Drawing.SystemColors.Window
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.ItemHeight = 16
        Me.lst_id.Location = New System.Drawing.Point(30, 111)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(135, 244)
        Me.lst_id.TabIndex = 135
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_inputPayMethod)
        Me.GroupBox1.Controls.Add(Me.lbl_payMethod)
        Me.GroupBox1.Controls.Add(Me.grd_order)
        Me.GroupBox1.Controls.Add(Me.lbl_inputID)
        Me.GroupBox1.Controls.Add(Me.lbl_inputStaffID)
        Me.GroupBox1.Controls.Add(Me.lbl_id)
        Me.GroupBox1.Controls.Add(Me.lbl_staffID)
        Me.GroupBox1.Controls.Add(Me.lbl_inputCustID)
        Me.GroupBox1.Controls.Add(Me.lbl_date)
        Me.GroupBox1.Controls.Add(Me.lbl_inputPrice)
        Me.GroupBox1.Controls.Add(Me.lbl_custID)
        Me.GroupBox1.Controls.Add(Me.lbl_inputDate)
        Me.GroupBox1.Controls.Add(Me.lbl_price)
        Me.GroupBox1.Location = New System.Drawing.Point(201, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(887, 314)
        Me.GroupBox1.TabIndex = 150
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Details"
        '
        'lbl_inputPayMethod
        '
        Me.lbl_inputPayMethod.AutoSize = True
        Me.lbl_inputPayMethod.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputPayMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputPayMethod.Location = New System.Drawing.Point(737, 47)
        Me.lbl_inputPayMethod.Name = "lbl_inputPayMethod"
        Me.lbl_inputPayMethod.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputPayMethod.TabIndex = 153
        Me.lbl_inputPayMethod.Text = "Label3"
        '
        'lbl_payMethod
        '
        Me.lbl_payMethod.AutoSize = True
        Me.lbl_payMethod.BackColor = System.Drawing.Color.Transparent
        Me.lbl_payMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_payMethod.Location = New System.Drawing.Point(586, 47)
        Me.lbl_payMethod.Name = "lbl_payMethod"
        Me.lbl_payMethod.Size = New System.Drawing.Size(134, 18)
        Me.lbl_payMethod.TabIndex = 152
        Me.lbl_payMethod.Text = "Payment Method"
        '
        'grd_order
        '
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(34, 127)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(816, 150)
        Me.grd_order.TabIndex = 151
        '
        'lbl_inputID
        '
        Me.lbl_inputID.AutoSize = True
        Me.lbl_inputID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputID.Location = New System.Drawing.Point(109, 47)
        Me.lbl_inputID.Name = "lbl_inputID"
        Me.lbl_inputID.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputID.TabIndex = 144
        Me.lbl_inputID.Text = "Label1"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(31, 47)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(72, 18)
        Me.lbl_id.TabIndex = 139
        Me.lbl_id.Text = "Order ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(580, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "INVOICE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(559, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "EzPrint Sdn. Bhd."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(377, 17)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "Lot 10, Kulim Hi-Tech Industrial Park, 09600, Kulim, Kedah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(463, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 17)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Tel : 088-1234567"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(628, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 17)
        Me.Label5.TabIndex = 155
        Me.Label5.Text = "Fax : 088-12941145"
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(990, 590)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(98, 33)
        Me.btn_refresh.TabIndex = 156
        Me.btn_refresh.Text = "REFRESH"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'frm_viewOrder_a188634
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_EzPrint_a188634.My.Resources.Resources.ezprintt
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1130, 650)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_cart)
        Me.Controls.Add(Me.lst_id)
        Me.Name = "frm_viewOrder_a188634"
        Me.Text = "Order Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_inputStaffID As Label
    Friend WithEvents lbl_inputCustID As Label
    Friend WithEvents lbl_inputPrice As Label
    Friend WithEvents lbl_inputDate As Label
    Friend WithEvents lbl_staffID As Label
    Friend WithEvents lbl_custID As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_cart As Label
    Friend WithEvents lst_id As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents lbl_inputID As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_inputPayMethod As Label
    Friend WithEvents lbl_payMethod As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_refresh As Button
End Class
