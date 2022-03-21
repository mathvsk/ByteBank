Namespace Classes.Funcionarios
    Public Class Designer
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
            Return salario * 0.17

        End Function

        Public Overrides Sub AumentarSalario()
            salario *= 1.11
        End Sub

#End Region



    End Class

End Namespace

