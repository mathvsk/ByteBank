Namespace Classes.Funcionarios
    Public Class Diretor
        'Herdando prop e metho de outra class
        Inherits Funcionario

#Region "Propriedades"



#End Region

#Region "Construtores"

        Public Sub New(_cpf As String, _salario As Double)
            MyBase.New(_cpf, _salario)
        End Sub

#End Region

#Region "Funções"

#End Region

#Region "Métodos"

        'Overrides = substitui
        Public Overrides Function GetBonificacao() As Double
            Return salario * 0.5

        End Function

        Public Overrides Sub AumentarSalario()
            salario *= 1.15
        End Sub

#End Region

    End Class

End Namespace
