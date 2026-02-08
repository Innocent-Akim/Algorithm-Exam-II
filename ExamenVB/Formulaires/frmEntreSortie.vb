Public Class frmEntreSortie
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If comboNoms.Text = "" Or comboProduit.Text = "" Or txtDateOp.Text = "" Or txtQte.Text = "" Then
                MessageBox.Show("Complétez tous les champs SVP")
            Else

                ''  cls = New clsCmd_Approv
                ''     cls.CodeCl_Fss1 = txtCodeNom.Text.Trim
                ''     cls.CodeProduit1 = txtCodeProd.Text.Trim
                ''    cls.Qte1 = txtQte.Text.Trim
                ''   cls.Dte1 = txtDateOp.Text.Trim

                If btnClient.Checked = True Then
                    If CInt(txtQte.Text) > CInt(labStock.Text) Then
                        MessageBox.Show("Le stock est inufisant,Songez à l'approvisionnement", "Alerte Stock")
                    Else
                        ''     clsGlossiaire.getInstance().insertCmd_Approv("tCommande", cls)
                        clsGlossiaire.getInstance().selectAllCmdApprov("reqCommande", DataGridView1)
                    End If

                    ''  ElseIf btnFournisseur.Checked = True
                    ''     clsGlossiaire.getInstance().insertCmd_Approv("tApprov", cls)
                    clsGlossiaire.getInstance().selectAllCmdApprov("reqApprov", DataGridView1)
                End If
                clsGlossiaire.getInstance().selectQuteProduit("reqCommande", comboProduit, labCommande)
                clsGlossiaire.getInstance().selectQuteProduit("reqApprov", comboProduit, labApprov)
                ''  labStock.Text = stockFinal(CInt(labApprov.Text), CInt(labCommande.Text))
                ''   dep = 0
                ''   deplacer(dep)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Avertissement")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If comboNoms.Text = "" Or comboProduit.Text = "" Or txtDateOp.Text = "" Or txtQte.Text = "" Then
                MessageBox.Show("Complétez tous les champs SVP")
            Else

                ''   cls = New clsCmd_Approv
                '' cls.CodeCl_Fss1 = txtCodeNom.Text.Trim
                ''cls.CodeProduit1 = txtCodeProd.Text.Trim
                '' cls.Qte1 = txtQte.Text.Trim
                ''cls.Dte1 = txtDateOp.Text.Trim

                If btnClient.Checked = True Then

                    If CInt(txtQte.Text) > CInt(labStock.Text) Then
                        MessageBox.Show("Le stock est inufisant,Songez à l'approvisionnement", "Alerte Stock")
                    Else
                        ''     clsGlossiaire.getInstance().updateCmd_Approv("tCommande", cls, txtCode)
                        clsGlossiaire.getInstance().selectAllCmdApprov("reqCommande", DataGridView1)
                    End If
                ElseIf btnFournisseur.Checked = True
                    ''    clsGlossiaire.getInstance().updateCmd_Approv("tApprov", cls, txtCode)
                    clsGlossiaire.getInstance().selectAllCmdApprov("reqApprov", DataGridView1)
                End If
                ' dep = 0
                '' deplacer(dep)
                clsGlossiaire.getInstance().selectQuteProduit("reqCommande", comboProduit, labCommande)
                clsGlossiaire.getInstance().selectQuteProduit("reqApprov", comboProduit, labApprov)
                '' labStock.Text = stockFinal(CInt(labApprov.Text), CInt(labCommande.Text))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Avertissement")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If txtCode.Text = "" Then
                MessageBox.Show("Complétez tous les champs SVP")
            Else
                Dim dialog = MessageBox.Show("Voulez-vous supprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    If btnClient.Checked = True Then
                        clsGlossiaire.getInstance().deleteAllMouvemnt("tCommande", "num", txtCode)
                        clsGlossiaire.getInstance().selectAllCmdApprov("reqCommande", DataGridView1)
                    ElseIf btnFournisseur.Checked = True
                        clsGlossiaire.getInstance().deleteAllMouvemnt("tApprov", "num", txtCode)
                        clsGlossiaire.getInstance().selectAllCmdApprov("reqApprov", DataGridView1)
                    Else
                        MessageBox.Show("Suppression annulée")
                    End If
                End If
                clsGlossiaire.getInstance().selectQuteProduit("reqCommande", comboProduit, labCommande)
                clsGlossiaire.getInstance().selectQuteProduit("reqApprov", comboProduit, labApprov)
                ' labStock.Text = stockFinal(CInt(labApprov.Text), CInt(labCommande.Text))
                '' dep = 0
                ''' deplacer(dep)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Avertissement")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        comboNoms.Text = Nothing
        comboProduit.Text = Nothing
        txtDateOp.Text = ""
        txtQte.Text = ""
        txtCode.Text = ""
        txtCodeNom.Text = ""
        txtCodeProd.Text = ""
    End Sub

    Private Sub frmEntreSortie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClient_CheckedChanged(sender As Object, e As EventArgs) Handles btnClient.CheckedChanged
       
        Try
            clsGlossiaire.getInstance().selectAllCmdApprov("reqCommande", DataGridView1)
            clsGlossiaire.getInstance().ComboxUsingClFss("tClient", comboNoms, "noms")
            ' dep = 0
            '' deplacer(dep)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnFournisseur_CheckedChanged(sender As Object, e As EventArgs) Handles btnFournisseur.CheckedChanged

    End Sub
End Class