<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffView_a188634
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
        Me.pic_staff = New System.Windows.Forms.PictureBox()
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.lbl_inputPosition = New System.Windows.Forms.Label()
        Me.lbl_inputPhoneNo = New System.Windows.Forms.Label()
        Me.lbl_inputName = New System.Windows.Forms.Label()
        Me.lbl_inputID = New System.Windows.Forms.Label()
        Me.lbl_position = New System.Windows.Forms.Label()
        Me.lbl_phone_no = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        CType(Me.pic_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.BackgroundImage = Global.prj_EzPrint_a188634.My.Resources.Resources.ezprintt
        Me.btn_back.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_back.Location = New System.Drawing.Point(12, 16)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(35, 31)
        Me.btn_back.TabIndex = 113
        Me.btn_back.Text = "<"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Olive
        Me.lbl_title.Location = New System.Drawing.Point(21, 62)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(118, 37)
        Me.lbl_title.TabIndex = 112
        Me.lbl_title.Text = "STAFF"
        '
        'pic_staff
        '
        Me.pic_staff.BackColor = System.Drawing.Color.Transparent
        Me.pic_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_staff.Location = New System.Drawing.Point(208, 118)
        Me.pic_staff.Name = "pic_staff"
        Me.pic_staff.Size = New System.Drawing.Size(278, 254)
        Me.pic_staff.TabIndex = 111
        Me.pic_staff.TabStop = False
        '
        'lst_id
        '
        Me.lst_id.BackColor = System.Drawing.Color.DarkKhaki
        Me.lst_id.ForeColor = System.Drawing.SystemColors.Window
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.ItemHeight = 16
        Me.lst_id.Location = New System.Drawing.Point(28, 118)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(117, 148)
        Me.lst_id.TabIndex = 110
        '
        'lbl_inputPosition
        '
        Me.lbl_inputPosition.AutoSize = True
        Me.lbl_inputPosition.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputPosition.Location = New System.Drawing.Point(636, 249)
        Me.lbl_inputPosition.Name = "lbl_inputPosition"
        Me.lbl_inputPosition.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputPosition.TabIndex = 132
        Me.lbl_inputPosition.Text = "Label4"
        '
        'lbl_inputPhoneNo
        '
        Me.lbl_inputPhoneNo.AutoSize = True
        Me.lbl_inputPhoneNo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputPhoneNo.Location = New System.Drawing.Point(636, 208)
        Me.lbl_inputPhoneNo.Name = "lbl_inputPhoneNo"
        Me.lbl_inputPhoneNo.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputPhoneNo.TabIndex = 131
        Me.lbl_inputPhoneNo.Text = "Label3"
        '
        'lbl_inputName
        '
        Me.lbl_inputName.AutoSize = True
        Me.lbl_inputName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputName.Location = New System.Drawing.Point(636, 170)
        Me.lbl_inputName.Name = "lbl_inputName"
        Me.lbl_inputName.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputName.TabIndex = 130
        Me.lbl_inputName.Text = "Label2"
        '
        'lbl_inputID
        '
        Me.lbl_inputID.AutoSize = True
        Me.lbl_inputID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_inputID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputID.Location = New System.Drawing.Point(636, 134)
        Me.lbl_inputID.Name = "lbl_inputID"
        Me.lbl_inputID.Size = New System.Drawing.Size(51, 18)
        Me.lbl_inputID.TabIndex = 129
        Me.lbl_inputID.Text = "Label1"
        '
        'lbl_position
        '
        Me.lbl_position.AutoSize = True
        Me.lbl_position.BackColor = System.Drawing.Color.Transparent
        Me.lbl_position.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_position.Location = New System.Drawing.Point(551, 249)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(70, 18)
        Me.lbl_position.TabIndex = 128
        Me.lbl_position.Text = "Position"
        '
        'lbl_phone_no
        '
        Me.lbl_phone_no.AutoSize = True
        Me.lbl_phone_no.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phone_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone_no.Location = New System.Drawing.Point(533, 207)
        Me.lbl_phone_no.Name = "lbl_phone_no"
        Me.lbl_phone_no.Size = New System.Drawing.Size(88, 18)
        Me.lbl_phone_no.TabIndex = 127
        Me.lbl_phone_no.Text = "Phone No."
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(569, 169)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(52, 18)
        Me.lbl_name.TabIndex = 126
        Me.lbl_name.Text = "Name"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(557, 134)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(64, 18)
        Me.lbl_id.TabIndex = 125
        Me.lbl_id.Text = "Staff ID"
        '
        'frm_staffView_a188634
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_EzPrint_a188634.My.Resources.Resources.ezprintt
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(870, 427)
        Me.Controls.Add(Me.lbl_inputPosition)
        Me.Controls.Add(Me.lbl_inputPhoneNo)
        Me.Controls.Add(Me.lbl_inputName)
        Me.Controls.Add(Me.lbl_inputID)
        Me.Controls.Add(Me.lbl_position)
        Me.Controls.Add(Me.lbl_phone_no)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_staff)
        Me.Controls.Add(Me.lst_id)
        Me.Name = "frm_staffView_a188634"
        Me.Text = "frm_staffView_a188634"
        CType(Me.pic_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_staff As PictureBox
    Friend WithEvents lst_id As ListBox
    Friend WithEvents lbl_inputPosition As Label
    Friend WithEvents lbl_inputPhoneNo As Label
    Friend WithEvents lbl_inputName As Label
    Friend WithEvents lbl_inputID As Label
    Friend WithEvents lbl_position As Label
    Friend WithEvents lbl_phone_no As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
End Class
