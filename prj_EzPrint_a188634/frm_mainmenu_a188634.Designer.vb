<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_mainmenu_a188634
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainmenu_a188634))
        Me.btn_product = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.lbl_menutitle = New System.Windows.Forms.Label()
        Me.lbl_exit = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_welcome = New System.Windows.Forms.Label()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_product
        '
        Me.btn_product.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_product.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_product.Location = New System.Drawing.Point(72, 156)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(135, 33)
        Me.btn_product.TabIndex = 1
        Me.btn_product.Text = "PRODUCTS"
        Me.btn_product.UseVisualStyleBackColor = False
        '
        'btn_customer
        '
        Me.btn_customer.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_customer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_customer.Location = New System.Drawing.Point(72, 205)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(135, 37)
        Me.btn_customer.TabIndex = 2
        Me.btn_customer.Text = "CUSTOMER"
        Me.btn_customer.UseVisualStyleBackColor = False
        '
        'btn_staff
        '
        Me.btn_staff.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_staff.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_staff.Location = New System.Drawing.Point(72, 257)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(135, 37)
        Me.btn_staff.TabIndex = 3
        Me.btn_staff.Text = "STAFF"
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'lbl_menutitle
        '
        Me.lbl_menutitle.AutoSize = True
        Me.lbl_menutitle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_menutitle.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menutitle.Location = New System.Drawing.Point(58, 46)
        Me.lbl_menutitle.Name = "lbl_menutitle"
        Me.lbl_menutitle.Size = New System.Drawing.Size(272, 49)
        Me.lbl_menutitle.TabIndex = 5
        Me.lbl_menutitle.Text = "WELCOME!"
        '
        'lbl_exit
        '
        Me.lbl_exit.AutoSize = True
        Me.lbl_exit.BackColor = System.Drawing.Color.Transparent
        Me.lbl_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_exit.Location = New System.Drawing.Point(43, 438)
        Me.lbl_exit.Name = "lbl_exit"
        Me.lbl_exit.Size = New System.Drawing.Size(164, 15)
        Me.lbl_exit.TabIndex = 11
        Me.lbl_exit.Text = "click here to exit the program"
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_exit.Location = New System.Drawing.Point(40, 407)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(81, 30)
        Me.btn_exit.TabIndex = 10
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'lbl_welcome
        '
        Me.lbl_welcome.AutoSize = True
        Me.lbl_welcome.BackColor = System.Drawing.Color.Transparent
        Me.lbl_welcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_welcome.Location = New System.Drawing.Point(68, 106)
        Me.lbl_welcome.Name = "lbl_welcome"
        Me.lbl_welcome.Size = New System.Drawing.Size(327, 20)
        Me.lbl_welcome.TabIndex = 12
        Me.lbl_welcome.Text = "Your one stop center for easy printing"
        '
        'btn_order
        '
        Me.btn_order.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_order.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_order.Location = New System.Drawing.Point(72, 309)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(135, 37)
        Me.btn_order.TabIndex = 13
        Me.btn_order.Text = "ORDER"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'frm_mainmenu_a188634
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1059, 476)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.lbl_welcome)
        Me.Controls.Add(Me.lbl_exit)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_menutitle)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_product)
        Me.Name = "frm_mainmenu_a188634"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_product As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents lbl_menutitle As Label
    Friend WithEvents lbl_exit As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_welcome As Label
    Friend WithEvents btn_order As Button
End Class
