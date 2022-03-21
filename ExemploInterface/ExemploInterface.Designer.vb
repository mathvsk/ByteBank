<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExemploInterface
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
        Me.btm_Interface = New System.Windows.Forms.Button()
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
        'btm_Interface
        '
        Me.btm_Interface.Location = New System.Drawing.Point(14, 38)
        Me.btm_Interface.Name = "btm_Interface"
        Me.btm_Interface.Size = New System.Drawing.Size(147, 93)
        Me.btm_Interface.TabIndex = 1
        Me.btm_Interface.Text = "Button1"
        Me.btm_Interface.UseVisualStyleBackColor = True
        '
        'ExemploInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btm_Interface)
        Me.Controls.Add(Me.lbl_Principal)
        Me.Name = "ExemploInterface"
        Me.Text = "\"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Principal As Label
    Friend WithEvents btm_Interface As Button
End Class
