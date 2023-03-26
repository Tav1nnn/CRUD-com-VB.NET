Imports MySql.Data.MySqlClient
Public Class FrmWindows
    Private conexao As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Try
            Dim nome As String = CStr(boxNome.Text)
            Dim numero As Integer = CInt(boxNumero.Text)

            Dim cliente As New Cliente
            cliente.Nome = nome
            cliente.Numero = numero

            Dim model As New Model

            Dim add As Boolean = model.add(cliente)

            If add = True Then
                MessageBox.Show("Cliente Cadastrado", "Sucesso", MessageBoxButtons.OK)
                boxNome.Text = ""
                boxNumero.Text = ""

            Else
                MessageBox.Show("Esse Numero já existe", "Erro", MessageBoxButtons.OK)
                boxNumero.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro")
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim id As Integer = CInt(boxIdd.Text)
            Dim nome As String = CStr(boxNome.Text)
            Dim numero As Integer = CInt(boxNumero.Text)

            Dim cliente As New Cliente
            cliente.Id = id
            cliente.Nome = nome
            cliente.Numero = numero

            Dim model As New Model
            Dim verificarId As Boolean = model.verificarId(cliente)

            If verificarId = True Then
                Dim editar As Boolean = model.editar(cliente)

                If editar = True Then
                    MessageBox.Show("Cliente Editado", "Sucesso", MessageBoxButtons.OK)
                    boxIdd.Text = ""
                    boxNome.Text = ""
                    boxNumero.Text = ""
                Else
                    MessageBox.Show("Esse Numero já existe", "Erro", MessageBoxButtons.OK)
                End If
            Else
                MessageBox.Show("Não existe cliente com este id", "Erro", MessageBoxButtons.OK)
                boxNumero.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro")
        End Try


    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            Dim id As Integer = CInt(boxIdd.Text)

            Dim cliente As New Cliente
            cliente.Id = id

            Dim model As New Model

            Dim deletar As Boolean = model.deletar(cliente)

            If deletar = True Then
                MessageBox.Show("Usuario Deletado", "Sucesso", MessageBoxButtons.OK)
                boxNome.Text = ""
                boxNumero.Text = ""

            Else
                MessageBox.Show("Este Id não existe", "Erro", MessageBoxButtons.OK)
                boxIdd.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro")
        End Try
    End Sub

    Private Sub Consultar_Click(sender As Object, e As EventArgs) Handles Consultar.Click
        Try
            conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123;")

            strSQL = "SELECT * FROM CAD_CLIENTE WHERE ID = @ID"

            comando = New MySqlCommand(strSQL, conexao)

            comando.Parameters.AddWithValue("@ID", boxIdd.Text)

            conexao.Open()
            dr = comando.ExecuteReader()

            Do While dr.Read
                boxNome.Text = dr("nome")
                boxNumero.Text = dr("numero")
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            conexao = Nothing
        End Try
    End Sub

    Private Sub Exibir_Click(sender As Object, e As EventArgs) Handles Exibir.Click
        Try
            conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123;")

            strSQL = "SELECT * FROM CAD_CLIENTE"

            Dim dt As New DataTable

            da = New MySqlDataAdapter(strSQL, conexao)

            da.Fill(dt)

            grid.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            conexao = Nothing
        End Try
    End Sub
End Class
