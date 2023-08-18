<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productOptions_a188634
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
        Me.btn_view = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_view
        '
        Me.btn_view.Location = New System.Drawing.Point(59, 36)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(128, 40)
        Me.btn_view.TabIndex = 0
        Me.btn_view.Text = "View Product"
        Me.btn_view.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(59, 95)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(128, 40)
        Me.btn_edit.TabIndex = 1
        Me.btn_edit.Text = "Edit Product"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'frm_productOptions_a188634
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_EzPrint_a188634.My.Resources.Resources.ezprintt
        Me.ClientSize = New System.Drawing.Size(256, 172)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_view)
        Me.Name = "frm_productOptions_a188634"
        Me.Text = "frm_productOptions_a188634"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_view As Button
    Friend WithEvents btn_edit As Button
End Class
