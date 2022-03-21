<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal
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
        Me.lbl_Principal = New System.Windows.Forms.Label()
        Me.btm_Click = New System.Windows.Forms.Button()
        Me.btm_AumentoSalario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Principal
        '
        Me.lbl_Principal.AutoSize = True
        Me.lbl_Principal.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Principal.Name = "lbl_Principal"
        Me.lbl_Principal.Size = New System.Drawing.Size(41, 15)
        Me.lbl_Principal.TabIndex = 0
        Me.lbl_Principal.Text = "Label1"
        '
        'btm_Click
        '
        Me.btm_Click.Location = New System.Drawing.Point(17, 44)
        Me.btm_Click.Name = "btm_Click"
        Me.btm_Click.Size = New System.Drawing.Size(137, 72)
        Me.btm_Click.TabIndex = 1
        Me.btm_Click.Text = "Button1"
        Me.btm_Click.UseVisualStyleBackColor = True
        '
        'btm_AumentoSalario
        '
        Me.btm_AumentoSalario.Location = New System.Drawing.Point(171, 44)
        Me.btm_AumentoSalario.Name = "btm_AumentoSalario"
        Me.btm_AumentoSalario.Size = New System.Drawing.Size(137, 72)
        Me.btm_AumentoSalario.TabIndex = 2
        Me.btm_AumentoSalario.Text = "Button1"
        Me.btm_AumentoSalario.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 522)
        Me.Controls.Add(Me.btm_AumentoSalario)
        Me.Controls.Add(Me.btm_Click)
        Me.Controls.Add(Me.lbl_Principal)
        Me.Name = "Frm_Principal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Principal As Label
    Friend WithEvents btm_Click As Button
    Friend WithEvents btm_AumentoSalario As Button
End Class
