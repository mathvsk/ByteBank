Imports AutenticacaoByteBank.Classes.Bibliotecas
Imports AutenticacaoByteBank.Classes.Externos
Imports AutenticacaoByteBank.Classes.Funcionarios

Public Class Form1
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Autenticação ByteBank"
        lbl_Principal.Text = "Autenticação ByteBank"
        btm_Autentica.Text = "Autenticar"
        btm_Autentica2.Text = "Autentica com representante"

    End Sub

    Private Sub btm_Autentica_Click(sender As Object, e As EventArgs) Handles btm_Autentica.Click

        Dim Matheus As New Diretor("45698745632", 5000)
        Matheus.senha = "abc"

        Dim vLoga As Boolean
        Dim SistemaInterno As New SistemaInterno
        vLoga = SistemaInterno.Logar(Matheus, "123")
        MsgBox($"Tentativa de logar no sistema {vLoga}")

        vLoga = SistemaInterno.Logar(Matheus, "abc")
        MsgBox($"Tentativa de logar no sistema {vLoga}")

    End Sub

    Private Sub btm_Autentica2_Click(sender As Object, e As EventArgs) Handles btm_Autentica2.Click

        Dim Matheus As New Diretor("45698745632", 5000)
        Matheus.senha = "abc"

        Dim Igor As New Representante
        Igor.senha = "999"

        Dim vLoga As Boolean
        Dim SistemaInterno As New SistemaInterno

        vLoga = SistemaInterno.Logar(Matheus, "abc")
        MsgBox($"Tentativa de logar no sistema {vLoga}")

        vLoga = SistemaInterno.Logar(Igor, "999")
        MsgBox($"Tentativa de logar no sistema {vLoga}")
    End Sub
End Class
