Public Class Predio
    Implements IAbrirPorta
    Public Function AbrirPorta() As String Implements IAbrirPorta.AbrirPorta
        Return "Estou abrindo a porta do prédio"
    End Function

End Class
