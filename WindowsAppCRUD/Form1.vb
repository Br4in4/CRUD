Public Class Form1
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Try
            Create("INSERT INTO Utilizadores(nome, utilizador, senha, nivel) VALUES 
                    ('" & TxtNome.Text & "','" &
                    TxtUtilizador.Text & "','" &
                    TxtSenha.Text & "','" &
                    CbNivel.SelectedIndex + 1 & ")")
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message,
                            "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        Try
            Reload("SELECT * FROM Utilizadores ORDER BY ID ASC", DgLista)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message,
                            "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Updates("UPDATE Utilizadores SET nome='" & TxtNome.Text & "', " &
                    "utilizador='" & TxtUtilizador.Text & "', " &
                    "senha='" & TxtSenha.Text & "', " &
                    "nivel=" & CbNivel.SelectedIndex & " WHERE ID=" & LblID.Text)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message,
                            "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            Delete("DELETE FROM Utilizadores WHERE ID=" & LblID.Text)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message,
                            "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DgLista_DoubleClick(sender As Object, e As EventArgs) Handles DgLista.DoubleClick
        LblID.Text = DgLista.CurrentRow.Cells(0).Value
        TxtNome.Text = DgLista.CurrentRow.Cells(1).Value
        TxtUtilizador.Text = DgLista.CurrentRow.Cells(2).Value
        TxtSenha.Text = DgLista.CurrentRow.Cells(3).Value
        CbNivel.SelectedIndex = DgLista.CurrentRow.Cells(4).Value
    End Sub
End Class
