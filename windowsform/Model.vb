Public Class Model
    Public Function add(cliente As Cliente) As Boolean
        Dim banco As New Banco

        Dim numeroExiste As Boolean = banco.verificarNumero(cliente)

        If numeroExiste = True Then
            Return False

        Else
            banco.add(cliente)
            Return True
        End If

    End Function
End Class
