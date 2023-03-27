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

    Public Function verificarId(cliente As Cliente) As Boolean
        Dim banco As New Banco

        Dim idExiste As Boolean = banco.verificarId(cliente)

        If idExiste = True Then
            Return True

        Else
            Return False
        End If

    End Function

    Public Function editar(cliente As Cliente) As Boolean
        Dim banco As New Banco

        Dim verificarNumero As Boolean = banco.verificarNumero(cliente)

        If verificarNumero = True Then
            Return False
        Else
            banco.editar(cliente)
            Return True
        End If
    End Function

    Public Function deletar(cliente As Cliente) As Boolean
        Dim banco As New Banco

        Dim verificarId As Boolean = banco.verificarId(cliente)

        If verificarId = True Then
            banco.deletar(cliente)
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getCliente(id As Integer) As Cliente
        Dim banco As New Banco

        Return banco.getCliente(id)

    End Function

    Public Function exibir() As ArrayList
        Dim banco As New Banco

        Return banco.exibir()
    End Function
End Class
