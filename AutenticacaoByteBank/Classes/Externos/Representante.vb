Namespace Classes.Externos
    Public Class Representante
        Implements IAutentica

        Public Property senha As String

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


