Imports ByteBank.Classes.Funcionarios
Imports ByteBank.Classes.Bibliotecas

Public Class Frm_Secundario
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Cálculo Bonificação"
        lbl_Secundario.Text = "Cálculo Bonificação"
        btm_Bonificacao.Text = "Calcular Bonificação"

    End Sub

    Private Sub btm_Bonificacao_Click(sender As Object, e As EventArgs) Handles btm_Bonificacao.Click

        Dim totalBonificacao As New GerenciadorBonificacao

        Dim Matheus As New Diretor("21598746325", 7000)
        Dim Lucinda As New Gerente("41587496532", 4000)
        Dim Ester As New Designer("45685412336", 2500)
        Dim Otavio As New Auxiliar("12543274563", 1500)

        totalBonificacao.Registrar(Matheus)
        totalBonificacao.Registrar(Lucinda)
        totalBonificacao.Registrar(Ester)
        totalBonificacao.Registrar(Otavio)

        MsgBox($"O valor total da bonificação será de: {totalBonificacao.getBonificacao().ToString}")

    End Sub
End Class