﻿Imports MySql.Data.MySqlClient
Public Class Banco
    Private conexao As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String



    Public Function verificarNumero(cliente As Cliente) As Boolean
        conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123;")
        strSQL = "SELECT * FROM CAD_CLIENTE WHERE NUMERO = @NUMERO"

        comando = New MySqlCommand(strSQL, conexao)

        comando.Parameters.AddWithValue("@NUMERO", cliente.Numero)

        conexao.Open()
        dr = comando.ExecuteReader()

        If dr.HasRows Then
            dr.Close()
            conexao.Close()
            Return True

        Else
            dr.Close()
            conexao.Close()
            Return False
        End If

    End Function

    Public Sub add(cliente As Cliente)
        conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123;")
        strSQL = "INSERT INTO CAD_CLIENTE (NOME, NUMERO) VALUES (@NOME, @NUMERO)"

        comando = New MySqlCommand(strSQL, conexao)

        comando.Parameters.AddWithValue("@NOME", cliente.Nome)
        comando.Parameters.AddWithValue("@NUMERO", cliente.Numero)

        conexao.Open()
        dr = comando.ExecuteReader()

        dr.Close()
        conexao.Close()

    End Sub

    Public Function verificarId(cliente As Cliente) As Boolean
        conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123;")
        strSQL = "SELECT ID FROM CAD_CLIENTE WHERE ID = @ID"

        comando = New MySqlCommand(strSQL, conexao)

        comando.Parameters.AddWithValue("@ID", cliente.Id)

        conexao.Open()
        dr = comando.ExecuteReader()

        If dr.HasRows Then
            dr.Close()
            conexao.Close()
            Return True

        Else
            dr.Close()
            conexao.Close()
            Return False
        End If
    End Function

    Public Sub editar(cliente As Cliente)
        conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123;")
        strSQL = "UPDATE CAD_CLIENTE SET NOME = @NOME, NUMERO = @NUMERO WHERE ID = @ID"

        comando = New MySqlCommand(strSQL, conexao)

        comando.Parameters.AddWithValue("@ID", cliente.Id)
        comando.Parameters.AddWithValue("@NOME", cliente.Nome)
        comando.Parameters.AddWithValue("@NUMERO", cliente.Numero)

        conexao.Open()
        dr = comando.ExecuteReader()

        dr.Close()
        conexao.Close()
    End Sub

    Public Sub deletar(cliente As Cliente)
        conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123;")
        strSQL = "DELETE FROM CAD_CLIENTE WHERE ID = @ID"

        comando = New MySqlCommand(strSQL, conexao)
        comando.Parameters.AddWithValue("@ID", cliente.Id)

        conexao.Open()
        dr = comando.ExecuteReader()

        dr.Close()
        conexao.Close()
    End Sub

    Public Function getCliente(id) As Cliente
        conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123;")
        strSQL = "SELECT ID, NOME, NUMERO FROM CAD_CLIENTE WHERE ID = @ID"

        comando = New MySqlCommand(strSQL, conexao)

        comando.Parameters.AddWithValue("@ID", id)

        conexao.Open()
        dr = comando.ExecuteReader()

        Dim cliente As New Cliente

        Do While dr.Read
            cliente.Nome = dr("nome")
            cliente.Numero = dr("numero")
        Loop

        If Not dr.HasRows Then
            Return Nothing
        End If

        Return cliente
    End Function

    Public Function exibir() As ArrayList
        Dim lista As New ArrayList

        conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123;")
        strSQL = "SELECT ID, NOME, NUMERO FROM CAD_CLIENTE"

        comando = New MySqlCommand(strSQL, conexao)

        conexao.Open()
        dr = comando.ExecuteReader()

        While dr.Read
            Dim cliente As New Cliente
            cliente.Id = dr("id")
            cliente.Nome = dr("nome")
            cliente.Numero = dr("numero")
            lista.Add(cliente)
        End While

        conexao.Close()
        conexao = Nothing

        Return lista
    End Function
End Class
