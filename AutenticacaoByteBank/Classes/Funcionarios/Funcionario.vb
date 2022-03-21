Namespace Classes.Funcionarios

    'Definindo a classe Funcionarios como um exemplo para ser usado por outras classes (NÃO PODENDO INSTANCIAR FUNCIONARIOS) 
    'MustInherit: Agora funcionarios é uma classe que só serve para herança
    Public MustInherit Class Funcionario

        'Uma classe possui PROPRIEDADES, FUNÇÕES E MÉTODOS
        'PROPRIEDADES: suas caracteristicas
        'FUNÇÕES: sao comandos que RETORNAM
        'MÉTODOS: comandos que fazem alguma coisa, mas não retornam valor
        'Se precisar usar processamento(conta, validação, etc...)
        'SEMPRE preferir usar uma função do que uma READONLY PROPERTY

#Region "Propriedades"

        Public Property nome As String

        'criando propriedades que sao privados. Não pode ser mudado no codigo principal
        'primeiro cria a propriedade como PRIVATE
        Private Property m_cpf As String
        'depois cria um propriedade PUBLICA SOMENTO LEITURA 
        Public ReadOnly Property cpf As String
            Get
                Return m_cpf
            End Get

        End Property

        'criando propriedades que sao privados. Não pode ser mudado no codigo principal
        'primeiro cria a propriedade como PRIVATE
        Private Property m_salario As String
        'depois cria um propriedade PUBLICA SOMENTO LEITURA 
        Public Property salario As Double

            Get
                Return m_salario
            End Get
            'Protected deixa que a propriedade salario seja modifica nas outras classes, mas não no form principal
            Protected Set(value As Double)
                m_salario = value
            End Set

        End Property


        'Criando uma solução para calcular o total de funcionarios na empresa
        Private Shared m_TotalDeFuncionarios As Integer
        Public Shared ReadOnly Property TotalDeFuncionarios() As Integer
            Get
                Return m_TotalDeFuncionarios
            End Get
        End Property

#End Region

#Region "Construtores"

        Public Sub New(_cpf As String, _salario As Integer)
            m_salario = _salario
            m_cpf = _cpf
            m_TotalDeFuncionarios += 1
        End Sub

#End Region

#Region "Funções"

#End Region

#Region "Métodos"

        'Overridable = substituivel
        Public MustOverride Function GetBonificacao() As Double

        Public MustOverride Sub AumentarSalario()


#End Region
    End Class

End Namespace


