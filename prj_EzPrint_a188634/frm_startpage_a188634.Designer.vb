<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_startpage_a188634
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
        Me.lbl_menutitle = New System.Windows.Forms.Label()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_menutitle
        '
        Me.lbl_menutitle.AutoSize = True
        Me.lbl_menutitle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_menutitle.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menutitle.Location = New System.Drawing.Point(80, 90)
        Me.lbl_menutitle.Name = "lbl_menutitle"
        Me.lbl_menutitle.Size = New System.Drawing.Size(285, 49)
        Me.lbl_menutitle.TabIndex = 14
        Me.lbl_menutitle.Text = "Easy printing,"
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.Bisque
        Me.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_start.Location = New System.Drawing.Point(89, 214)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(135, 33)
        Me.btn_start.TabIndex = 13
        Me.btn_start.Text = "START"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 49)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Easy Life"
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.BackColor = System.Drawing.Color.Transparent
        Me.lbl_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.Location = New System.Drawing.Point(30, 407)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(220, 17)
        Me.lbl_info.TabIndex = 16
        Me.lbl_info.Text = "YUSRIN ZULFA BINTI ZUBER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 433)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "(A188634), EzPrint"
        '
        'frm_startpage_a188634
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_EzPrint_a188634.My.Resources.Resources.ezprint_banner
        Me.ClientSize = New System.Drawing.Size(1055, 477)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_menutitle)
        Me.Controls.Add(Me.btn_start)
        Me.Name = "frm_startpage_a188634"
        Me.Text = "frm_startpage_a188634"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_menutitle As Label
    Friend WithEvents btn_start As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_info As Label
    Friend WithEvents Label3 As Label
End Class
