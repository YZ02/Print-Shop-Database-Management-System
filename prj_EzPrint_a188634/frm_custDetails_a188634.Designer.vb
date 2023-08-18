<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_custDetails_a188634
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
        Me.pic_customer = New System.Windows.Forms.PictureBox()
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.lbl_message = New System.Windows.Forms.Label()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_phoneNo = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.RichTextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        CType(Me.pic_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_customer
        '
        Me.pic_customer.BackColor = System.Drawing.Color.Transparent
        Me.pic_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_customer.Location = New System.Drawing.Point(183, 117)
        Me.pic_customer.Name = "pic_customer"
        Me.pic_customer.Size = New System.Drawing.Size(201, 225)
        Me.pic_customer.TabIndex = 23
        Me.pic_customer.TabStop = False
        '
        'lst_id
        '
        Me.lst_id.BackColor = System.Drawing.Color.DarkKhaki
        Me.lst_id.ForeColor = System.Drawing.SystemColors.Window
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.ItemHeight = 16
        Me.lst_id.Location = New System.Drawing.Point(25, 117)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(112, 132)
        Me.lst_id.TabIndex = 19
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Olive
        Me.lbl_title.Location = New System.Drawing.Point(18, 59)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(208, 37)
        Me.lbl_title.TabIndex = 24
        Me.lbl_title.Text = "CUSTOMER"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Me.btn_back.TabIndex = 88
        Me.btn_back.Text = "<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(183, 505)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(228, 34)
        Me.btn_insert.TabIndex = 77
        Me.btn_insert.Text = "INSERT AS NEW CUSTOMER"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(183, 465)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(112, 34)
        Me.btn_update.TabIndex = 78
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(301, 465)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(110, 34)
        Me.btn_delete.TabIndex = 79
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(659, 505)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(95, 34)
        Me.btn_refresh.TabIndex = 80
        Me.btn_refresh.Text = "REFRESH"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'lbl_message
        '
        Me.lbl_message.AutoSize = True
        Me.lbl_message.BackColor = System.Drawing.Color.Transparent
        Me.lbl_message.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_message.Location = New System.Drawing.Point(180, 406)
        Me.lbl_message.Name = "lbl_message"
        Me.lbl_message.Size = New System.Drawing.Size(485, 16)
        Me.lbl_message.TabIndex = 81
        Me.lbl_message.Text = "The form is editable please click the buttons below to save changes"
        '
        'btn_picture
        '
        Me.btn_picture.Location = New System.Drawing.Point(183, 369)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(124, 30)
        Me.btn_picture.TabIndex = 82
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(402, 149)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(170, 22)
        Me.txt_name.TabIndex = 20
        '
        'txt_phoneNo
        '
        Me.txt_phoneNo.Location = New System.Drawing.Point(402, 181)
        Me.txt_phoneNo.Name = "txt_phoneNo"
        Me.txt_phoneNo.Size = New System.Drawing.Size(170, 22)
        Me.txt_phoneNo.TabIndex = 21
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Franklin Gothic Demi", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(408, 117)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(61, 21)
        Me.lbl_id.TabIndex = 90
        Me.lbl_id.Text = "Label1"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(402, 218)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(170, 83)
        Me.txt_address.TabIndex = 126
        Me.txt_address.Text = ""
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(497, 319)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 127
        Me.btn_clear.Text = "clear all"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'frm_custDetails_a188634
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_EzPrint_a188634.My.Resources.Resources.ezprintt
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.lbl_message)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_customer)
        Me.Controls.Add(Me.txt_phoneNo)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lst_id)
        Me.Name = "frm_custDetails_a188634"
        Me.Text = "Customer Details"
        CType(Me.pic_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_customer As PictureBox
    Friend WithEvents lst_id As ListBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents lbl_message As Label
    Friend WithEvents btn_picture As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_phoneNo As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_address As RichTextBox
    Friend WithEvents btn_clear As Button
End Class
