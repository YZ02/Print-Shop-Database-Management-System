<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffDetails_a188634
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
        Me.pic_staff = New System.Windows.Forms.PictureBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.txt_phoneNo = New System.Windows.Forms.TextBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.lbl_message = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_position = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        CType(Me.pic_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_staff
        '
        Me.pic_staff.BackColor = System.Drawing.Color.Transparent
        Me.pic_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_staff.Location = New System.Drawing.Point(204, 114)
        Me.pic_staff.Name = "pic_staff"
        Me.pic_staff.Size = New System.Drawing.Size(205, 254)
        Me.pic_staff.TabIndex = 29
        Me.pic_staff.TabStop = False
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(425, 149)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(170, 22)
        Me.txt_name.TabIndex = 27
        '
        'lst_id
        '
        Me.lst_id.BackColor = System.Drawing.Color.DarkKhaki
        Me.lst_id.ForeColor = System.Drawing.SystemColors.Window
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.ItemHeight = 16
        Me.lst_id.Location = New System.Drawing.Point(24, 114)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(120, 132)
        Me.lst_id.TabIndex = 25
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Olive
        Me.lbl_title.Location = New System.Drawing.Point(17, 55)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(118, 37)
        Me.lbl_title.TabIndex = 30
        Me.lbl_title.Text = "STAFF"
        '
        'txt_phoneNo
        '
        Me.txt_phoneNo.Location = New System.Drawing.Point(425, 186)
        Me.txt_phoneNo.Name = "txt_phoneNo"
        Me.txt_phoneNo.Size = New System.Drawing.Size(170, 22)
        Me.txt_phoneNo.TabIndex = 31
        '
        'btn_picture
        '
        Me.btn_picture.Location = New System.Drawing.Point(204, 374)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(124, 30)
        Me.btn_picture.TabIndex = 82
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'lbl_message
        '
        Me.lbl_message.AutoSize = True
        Me.lbl_message.BackColor = System.Drawing.Color.Transparent
        Me.lbl_message.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_message.Location = New System.Drawing.Point(201, 411)
        Me.lbl_message.Name = "lbl_message"
        Me.lbl_message.Size = New System.Drawing.Size(489, 16)
        Me.lbl_message.TabIndex = 81
        Me.lbl_message.Text = "The form is editable, please click the buttons below to save changes"
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(680, 510)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(95, 34)
        Me.btn_refresh.TabIndex = 80
        Me.btn_refresh.Text = "REFRESH"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(322, 470)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(110, 34)
        Me.btn_delete.TabIndex = 79
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(204, 470)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(112, 34)
        Me.btn_update.TabIndex = 78
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(204, 510)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(228, 34)
        Me.btn_insert.TabIndex = 77
        Me.btn_insert.Text = "INSERT AS NEW STAFF"
        Me.btn_insert.UseVisualStyleBackColor = True
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
        Me.btn_back.TabIndex = 87
        Me.btn_back.Text = "<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Franklin Gothic Demi", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(430, 114)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(61, 21)
        Me.lbl_id.TabIndex = 90
        Me.lbl_id.Text = "Label1"
        '
        'txt_position
        '
        Me.txt_position.Location = New System.Drawing.Point(425, 223)
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(170, 22)
        Me.txt_position.TabIndex = 91
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(520, 271)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 92
        Me.btn_clear.Text = "clear all"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'frm_staffDetails_a188634
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_EzPrint_a188634.My.Resources.Resources.ezprintt
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(801, 568)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txt_position)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.lbl_message)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_phoneNo)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_staff)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lst_id)
        Me.Name = "frm_staffDetails_a188634"
        Me.Text = "Staff Details"
        CType(Me.pic_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_staff As PictureBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lst_id As ListBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents txt_phoneNo As TextBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents lbl_message As Label
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_position As TextBox
    Friend WithEvents btn_clear As Button
End Class
