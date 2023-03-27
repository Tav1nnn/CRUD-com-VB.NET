Imports MySql.Data.MySqlClient
Public Class FrmWindows
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
            Dim id As Integer = CInt(boxIdd.Text)

            Dim model As New Model

            Dim cliente As Cliente = model.getCliente(id)

            If cliente Is Nothing Then
                MessageBox.Show("Não existe cliente com esse id", "Erro", MessageBoxButtons.OK)
                boxIdd.Text = ""
            Else
                boxNome.Text = cliente.Nome
                boxNumero.Text = cliente.Numero
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro")
        End Try
    End Sub

    Private Sub Exibir_Click(sender As Object, e As EventArgs) Handles Exibir.Click
        Try
            Dim model As New Model

            Dim lista As ArrayList = model.exibir()

            grid.DataSource = lista

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class
