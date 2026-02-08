Imports ExamenVB

Public Class frmMouvement
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtMontDebit_TextChanged(sender As Object, e As EventArgs) Handles txtMontDebit.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtDebit.Text = "" Or txtMontDebit.Text = "" Or txtMontCredit.Text = "" Or txtCredit.Text = "" Or txtDateOp.Text = "" Or comboCredit.Text = "" Or comboDebit.Text = "" Or comboProduit.Text = "" Or txtLibelle.Text = "" Then
                MessageBox.Show("Completer tous les champs SVP")
            Else
                If comboDebit.Text.Equals(comboCredit.Text) Or CInt(txtMontDebit.Text) <> CInt(txtMontCredit.Text) Then
                    MessageBox.Show("Opération impossible")
                Else
                    If Not IsNumeric(txtMontCredit.Text.Trim) Or Not IsNumeric(txtMontDebit.Text.Trim) Then
                        MessageBox.Show("Le montant est invalide")
                    Else

                        cls.CodeDebit1 = txtDebit.Text.Trim
                        cls.MontDebit1 = CDbl(txtMontDebit.Text.Trim)
                        cls.CodeCredit1 = txtCredit.Text.Trim
                        cls.MontCredit1 = CDbl(txtMontCredit.Text.Trim)
                        cls.Dte1 = CDate(txtDateOp.Text.Trim)
                        cls.CodeProduit1 = txtProduit.Text.Trim
                        cls.Libelle1 = txtLibelle.Text.Trim.ToLower
                        clsGlossiaire.getInstance().insertMouvement(cls)
                        clsGlossiaire.getInstance().selectAllMouv("reqMouvement", DataGridView1)

                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function cls() As clsMouvementCompt
        Throw New NotImplementedException()
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtDebit.Text = "" Or txtMontDebit.Text = "" Or txtMontCredit.Text = "" Or txtCredit.Text = "" Or txtDateOp.Text = "" Or txtLibelle.Text = "" Then
                MessageBox.Show("Completer tous les champs SVP")
            Else
                If Not IsNumeric(txtMontCredit.Text.Trim) Or Not IsNumeric(txtMontDebit.Text.Trim) Then
                    MessageBox.Show("Le montant est invalide")
                Else
                    If comboDebit.Text.Equals(comboCredit.Text) Or CInt(txtMontDebit.Text) <> CInt(txtMontCredit.Text) Then
                        MessageBox.Show("Opération impossible")
                    Else


                        cls.CodeDebit1 = txtDebit.Text.Trim
                        cls.MontDebit1 = CDbl(txtMontDebit.Text.Trim)
                        cls.CodeCredit1 = txtCredit.Text.Trim
                        cls.MontCredit1 = CDbl(txtMontCredit.Text.Trim)
                        cls.Dte1 = CDate(txtDateOp.Text.Trim)
                        cls.CodeProduit1 = txtProduit.Text.Trim
                        cls.Libelle1 = txtLibelle.Text.Trim.ToLower
                        clsGlossiaire.getInstance().updatemouv(cls, txtnum)
                        clsGlossiaire.getInstance().selectAllMouv("reqMouvement", DataGridView1)

                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If txtnum.Text = "" Then
                MessageBox.Show("Complétez tous les champs code", "Obligatoire")
            Else
                Dim dialog = MessageBox.Show("Voulez-vous supprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    clsGlossiaire.getInstance().deleteAllMouvemnt("tConcerne", "numOp", txtnum)
                    clsGlossiaire.getInstance().selectAllMouv("reqMouvement", DataGridView1)
                Else
                    MessageBox.Show("Suppression annulée")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function dep() As Integer
        Throw New NotImplementedException()
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        comboProduit.Text = Nothing
        comboCredit.Text = Nothing
        comboDebit.Text = Nothing
        txtCredit.Text = ""
        txtDateOp.Text = ""
        txtDebit.Text = ""
        txtProduit.Text = ""
        txtMontCredit.Text = ""
        txtMontDebit.Text = ""
        txtLibelle.Text = ""
    End Sub

    Private Sub txtDebit_TextChanged(sender As Object, e As EventArgs) Handles txtDebit.TextChanged

    End Sub

    Private Sub frmMouvement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class