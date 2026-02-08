Public Class frmCli_Fss
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtnoms.Text = "" Or cmbSexe.Text = "" Or txtContact.Text = "" Or txtAdresse.Text = "" Then

            End If
            MessageBox.Show("Complétez tous les champs SVP")


            Dim testNum As String = Mid(txtContact.Text.Trim, 2, txtContact.Text.Length - 1)
            If Not IsNumeric(testNum) Then
                MessageBox.Show("Numero de téléphone invalide")
            Else
                Dim n1 As String = Mid(txtnoms.Text.Trim, 1, 2)
                Dim n2 As String = Mid(txtContact.Text.Trim, testNum.Length - 3, 2)
                Dim n3 As String = Mid(txtAdresse.Text.Trim, 3, 2)
                Dim codeClf = n1 + n2 + n3


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Avertissement")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtnoms.Text = "" Or cmbSexe.Text = "" Or txtContact.Text = "" Or txtAdresse.Text = "" Then
                MessageBox.Show("Complétez tous les champs SVP")



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If txtCode.Text = "" Then
                MessageBox.Show("Complétez tous les champs code", "Obligatoire")
            Else
                Dim dialog = MessageBox.Show("Voulez-vous supprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then


                Else
                    MessageBox.Show("Suppression annulée")
                End If


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtCode.Text = ""
        txtnoms.Text = ""
        txtContact.Text = ""
        cmbSexe.Text = ""
        txtAdresse.Text = ""
    End Sub

    Private Sub frmCli_Fss_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If btnClient.Checked = True Then
                clsGlossiaire.getInstance().SearchClFss("tClient", DataGridView1, txtSearch)
            ElseIf btnFournisseur.Checked = True
                clsGlossiaire.getInstance().SearchClFss("tfournisseur", DataGridView1, txtSearch)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClient_CheckedChanged(sender As Object, e As EventArgs) Handles btnClient.CheckedChanged

    End Sub

    Private Sub btnFournisseur_CheckedChanged(sender As Object, e As EventArgs) Handles btnFournisseur.CheckedChanged

    End Sub
End Class