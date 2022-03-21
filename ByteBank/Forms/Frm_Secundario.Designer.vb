<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Secundario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_Secundario = New System.Windows.Forms.Label()
        Me.btm_Bonificacao = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Secundario
        '
        Me.lbl_Secundario.AutoSize = True
        Me.lbl_Secundario.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Secundario.Name = "lbl_Secundario"
        Me.lbl_Secundario.Size = New System.Drawing.Size(41, 15)
        Me.lbl_Secundario.TabIndex = 0
        Me.lbl_Secundario.Text = "Label1"
        '
        'btm_Bonificacao
        '
        Me.btm_Bonificacao.Location = New System.Drawing.Point(13, 49)
        Me.btm_Bonificacao.Name = "btm_Bonificacao"
        Me.btm_Bonificacao.Size = New System.Drawing.Size(231, 107)
        Me.btm_Bonificacao.TabIndex = 1
        Me.btm_Bonificacao.Text = "Button1"
        Me.btm_Bonificacao.UseVisualStyleBackColor = True
        '
        'Frm_Secundario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 556)
        Me.Controls.Add(Me.btm_Bonificacao)
        Me.Controls.Add(Me.lbl_Secundario)
        Me.Name = "Frm_Secundario"
        Me.Text = "Frm_Secundario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Secundario As Label
    Friend WithEvents btm_Bonificacao As Button
End Class
