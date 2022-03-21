Public Class Casa
    Implements IAbrirPorta

    Public Function AbrirPorta() As String Implements IAbrirPorta.AbrirPorta
        Return "Estou abrindo a porta da casa"
    End Function
End Class
