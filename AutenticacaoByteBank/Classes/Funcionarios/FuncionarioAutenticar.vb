Namespace Classes.Funcionarios

    Public MustInherit Class FuncionarioAutenticar
        Inherits Funcionario
        Implements IAutentica

        Public Property senha As String

#Region "Construtores"

        Public Sub New(_cpf As String, _salario As Double)
            MyBase.New(_cpf, _salario)
        End Sub

#End Region

#Region "Funções"

#End Region

#Region "Métodos"

        Public Function Autenticar(senhaTentativa As String) As Boolean Implements IAutentica.Autenticar
            If senha = senhaTentativa Then
                Return True
            Else
                Return False

            End If
        End Function

#End Region

    End Class

End Namespace

