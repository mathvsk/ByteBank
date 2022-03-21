
Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Principal"
        lbl_Principal.Text = "Principal"
        btm_Click.Text = "Clique aqui"
        btm_AumentoSalario.Text = "Aumento de Salario"

    End Sub

    Private Sub brm_Click_Click(sender As Object, e As EventArgs) Handles btm_Click.Click

        Dim gerenciadoBonificacao As New GerenciadorBonificacao


        Dim Carlos As New Gerente("14785236598", 2000)
        Carlos.nome = "Carlos Jose"
        gerenciadoBonificacao.Registrar(Carlos)

        Dim Matheus As New Diretor("14785236457", 5000)
        Matheus.nome = "Matheus Igor"
        gerenciadoBonificacao.Registrar(Matheus)


        MsgBox($"Salario do {Carlos.nome} é de: {Carlos.salario.ToString}")
        'Usar Parenteses para chamada de funcao
        MsgBox($"A bonificacao de {Carlos.nome} será de {Carlos.GetBonificacao()}")

        MsgBox($"Salario do {Matheus.nome} é de: {Matheus.salario.ToString}")
        'Usar Parenteses para chamada de funcao
        MsgBox($"A bonificacao de {Matheus.nome} será de {Matheus.GetBonificacao()}")



    End Sub

    Private Sub btm_AumentoSalario_Click(sender As Object, e As EventArgs) Handles btm_AumentoSalario.Click

        Dim vGerente As New Gerente("12454785214", 2000)
        Dim vDiretor As New Diretor("12454785214", 5000)

        MsgBox($"Gerente salario = {vGerente.salario} Diretor salario = {vDiretor.salario}")

        vGerente.AumentarSalario()
        vDiretor.AumentarSalario()

        MsgBox($"Gerente aumento salario = {vGerente.salario} Diretor aumento salario = {vDiretor.salario}")

    End Sub
End Class
