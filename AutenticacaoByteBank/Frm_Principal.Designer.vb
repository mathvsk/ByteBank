<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btm_Autentica = New System.Windows.Forms.Button()
        Me.btm_Autentica2 = New System.Windows.Forms.Button()
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
        'btm_Autentica
        '
        Me.btm_Autentica.Location = New System.Drawing.Point(12, 40)
        Me.btm_Autentica.Name = "btm_Autentica"
        Me.btm_Autentica.Size = New System.Drawing.Size(151, 87)
        Me.btm_Autentica.TabIndex = 1
        Me.btm_Autentica.Text = "Button1"
        Me.btm_Autentica.UseVisualStyleBackColor = True
        '
        'btm_Autentica2
        '
        Me.btm_Autentica2.Location = New System.Drawing.Point(195, 40)
        Me.btm_Autentica2.Name = "btm_Autentica2"
        Me.btm_Autentica2.Size = New System.Drawing.Size(151, 87)
        Me.btm_Autentica2.TabIndex = 2
        Me.btm_Autentica2.Text = "Button1"
        Me.btm_Autentica2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btm_Autentica2)
        Me.Controls.Add(Me.btm_Autentica)
        Me.Controls.Add(Me.lbl_Principal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Principal As Label
    Friend WithEvents btm_Autentica As Button
    Friend WithEvents btm_Autentica2 As Button
End Class
