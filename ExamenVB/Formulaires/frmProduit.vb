Imports ExamenVB

Public Class frmProduit
    Private cls As clsProduit

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtCode.Text = "" Or txtDesignation.Text = "" Or txtPrix.Text = "" Or dateExipiration.Text = "" Or PictureBox1.Image Is Nothing Then
                MessageBox.Show("Complétez tous les champs SVP! ou Photo")
            Else
                If Not IsNumeric(txtPrix.Text.Trim) Then
                    MessageBox.Show("Le Prix entré est invalide")
                Else
                    cls = New clsProduit
                    cls.Code1 = txtCode.Text.Trim
                    cls.Designation1 = txtDesignation.Text.Trim.ToUpper
                    cls.Prix1 = txtPrix.Text
                    cls.Dte1 = CDate(dateExipiration.Text.Trim)
                    clsGlossiaire.getInstance().insertPro("tProduit", cls, PictureBox1)
                    clsGlossiaire.getInstance.selectPro("tProduit", DataGridView1)

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClient_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If txtDesignation.Text = "" Or txtPrix.Text = "" Or dateExipiration.Text = "" Then
                MessageBox.Show("Completer les champs, Designation,Prix,Date", "Obligatoire")
            Else
                Dim des As String = txtDesignation.Text.Trim
                Dim prixU As String = txtPrix.Text.Trim
                Dim dateEP As String = dateExipiration.Text.Trim
                Dim encodage As String = des + ", Prix Unitaire: " + prixU + ", Date Expiration: " + dateEP
                Dim cls As New clsImabar

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bd_RudolfDataSet.tProduit' table. You can move, or remove it, as needed.
        Me.TProduitTableAdapter.Fill(Me.Bd_RudolfDataSet.tProduit)

    End Sub
End Class