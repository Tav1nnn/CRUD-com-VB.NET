Imports MySql.Data.MySqlClient
Public Class FrmWindows
    Private conexao As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Try
            conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123;")

            strSQL = "INSERT INTO CAD_CLIENTE (NOME, NUMERO) VALUES (@NOME, @NUMERO)"

            comando = New MySqlCommand(strSQL, conexao)

            comando.Parameters.AddWithValue("@NOME", boxNome.Text)
            comando.Parameters.AddWithValue("@NUMERO", boxNumero.Text)

            conexao.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Usuário Cadastrado", "Sucesso", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            conexao.Close()
            conexao = Nothing
            conexao = Nothing
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123;")

            strSQL = "UPDATE CAD_CLIENTE SET NOME = @NOME, NUMERO = @NUMERO WHERE ID = @ID"

            comando = New MySqlCommand(strSQL, conexao)

            comando.Parameters.AddWithValue("@ID", boxIdd.Text)
            comando.Parameters.AddWithValue("@NOME", boxNome.Text)
            comando.Parameters.AddWithValue("@NUMERO", boxNumero.Text)

            conexao.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Usuário Editado", "Sucesso", MessageBoxButtons.OK)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            conexao = Nothing
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            conexao = New MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=123;")

            strSQL = "DELETE FROM CAD_CLIENTE WHERE ID = @ID"

            comando = New MySqlCommand(strSQL, conexao)

            comando.Parameters.AddWithValue("@ID", boxIdd.Text)

            conexao.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Usuário Deletado", "Sucesso", MessageBoxButtons.OK)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            conexao = Nothing
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
