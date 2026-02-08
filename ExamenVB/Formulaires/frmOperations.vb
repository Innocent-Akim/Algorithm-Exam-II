Public Class frmOperations
    Private op As Object
    Public Property dep As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataGridView1.Rows.Add(txtCode.Text, txtDesignation.Text, txtNumCompt.Text)

        Try
            If txtCode.Text = "" Or txtDesignation.Text = "" Or txtNumCompt.Text = "" Then
                MessageBox.Show("Complétez tous les champs SVP")
            Else
                op = New clsOpDebitCredit
                op.Code1 = txtCode.Text.Trim
                op.Designation1 = txtDesignation.Text.Trim.ToLower
                op.NumCompt1 = txtNumCompt.Text.Trim

                If btnDebit.Checked = True Then
                    clsGlossiaire.getInstance().insertOperation("TOpDebit", op)
                    clsGlossiaire.getInstance().selectAll("TOpDebit", DataGridView1)
                ElseIf btnCredit.Checked = True
                    clsGlossiaire.getInstance().insertOperation("TOpCredit", op)
                    clsGlossiaire.getInstance().selectAll("TOpCredit", DataGridView1)
                End If
                dep = 0
                deplacer(dep)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtCode.Text = "" Or txtDesignation.Text = "" Or txtNumCompt.Text = "" Then
                MessageBox.Show("Complétez tous les champs SVP")
            Else
                op = New clsOpDebitCredit
                op.Code1 = txtCode.Text.Trim()
                op.Designation1 = txtDesignation.Text.Trim.ToLower()
                op.NumCompt1 = txtNumCompt.Text.Trim()

                If btnDebit.Checked = True Then
                    clsGlossiaire.getInstance().updateOperation("TOpDebit", op)
                    clsGlossiaire.getInstance().selectAll("TOpDebit", DataGridView1)
                ElseIf btnCredit.Checked = True
                    clsGlossiaire.getInstance().updateOperation("TOpCredit", op)
                    clsGlossiaire.getInstance().selectAll("TOpCredit", DataGridView1)
                End If
                dep = 0
                deplacer(dep)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If txtCode.Text = "" Then
                MessageBox.Show("Complétez le champs code SVP")
            Else
                op = New clsOpDebitCredit
                op.Code1 = txtCode.Text.Trim
                Dim dial = MessageBox.Show("Voulez-vous supprimer cette Opération?", "Confirmation Supression", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If dial = DialogResult.Yes Then
                    If btnDebit.Checked = True Then
                        clsGlossiaire.getInstance().deleteAll("TOpDebit", op)
                        clsGlossiaire.getInstance().selectAll("TOpDebit", DataGridView1)
                    ElseIf btnCredit.Checked = True
                        clsGlossiaire.getInstance().deleteAll("TOpCredit", op)
                        clsGlossiaire.getInstance().selectAll("TOpCredit", DataGridView1)
                    End If
                    dep = 0
                    deplacer(dep)
                Else
                    MessageBox.Show("suppression annulée")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub deplacer(dep As Object)
        Throw New NotImplementedException()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtCode.Text = ""
        txtDesignation.Text = ""
        txtNumCompt.Text = ""
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmOperations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class