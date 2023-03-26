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

    Friend Function verificarId(cliente As Cliente) As Boolean
        Dim banco As New Banco

        Dim idExiste As Boolean = banco.verificarId(cliente)

        If idExiste = True Then
            Return True

        Else
            Return False
        End If

    End Function

    Friend Function editar(cliente As Cliente) As Boolean
        Dim banco As New Banco

        Dim verificarNumero As Boolean = banco.verificarNumero(cliente)

        If verificarNumero = True Then
            Return False
        Else
            banco.editar(cliente)
            Return True
        End If
    End Function
End Class
