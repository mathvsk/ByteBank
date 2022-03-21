Public Class ExemploInterface
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        ''Me.Text = "Exemplo Interface"
        lbl_Principal.Text = "Exemplo Interface"
        btm_Interface.Text = "Clique Aqui"

    End Sub

    Private Sub btm_Interface_Click(sender As Object, e As EventArgs) Handles btm_Interface.Click

        Dim vX As New Imovel

        MsgBox(vX.AbrirPorta(New Casa))
        MsgBox(vX.AbrirPorta(New Predio))

    End Sub
End Class
