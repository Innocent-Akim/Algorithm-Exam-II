Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.IO
Imports CrystalDecisions.Windows.Forms

Public Class clsGlossiaire

    Private Shared glos As clsGlossiaire
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dta As OleDbDataAdapter
    Dim cnx As New clsConnexion

    Shared Function getInstance() As clsGlossiaire

        If (IsNothing(glos)) Then
            glos = New clsGlossiaire()
        End If
        Return glos

    End Function
    Private Sub initialiseConn()
        cnx.readFilePath("C:\tpVb\conFileExamen.txt")
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + cnx.chemin)
    End Sub


    'Code pour toute les classes
    Public Sub selectAll(nomTable As String, dataGridOp As DataGridView)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM " + nomTable + " ", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")
            dataGridOp.DataSource = ds.Tables("operation")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub deleteAll(nomTable As String, cb As clsBase)

        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("DELETE FROM " + nomTable + " WHERE code=@code", con)
            cmd.Parameters.Add("@code", OleDbType.VarChar, 10, "code").Value = cb.Code1
            cmd.ExecuteNonQuery()
            MessageBox.Show("Suppression réussie!")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub deleteAllMouvemnt(nomTable As String, id As String, txt As TextBox)

        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("DELETE FROM " + nomTable + " WHERE " + id + "=" + txt.Text, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Suppression réussie!")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub SearchAll(nomTable As String, dataGridOp As DataGridView, txt As TextBox)

        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM " + nomTable + " WHERE code LIKE '%" + txt.Text + "%' OR designation LIKE '%" + txt.Text + "%' ", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")
            dataGridOp.DataSource = ds.Tables("operation")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub ComboxUsingClFss(nomTable As String, combo As ComboBox, txt As String)
        Try
            combo.Items.Clear()
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("SELECT DISTINCT " + txt + " FROM " + nomTable + " ", con)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader
            While (dr.Read)
                combo.Items.Add(dr(txt).ToString())
            End While

        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub ComboxUsing(nomTable As String, combo As ComboBox)
        Try
            combo.Items.Clear()
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("SELECT DISTINCT designation FROM " + nomTable + " ", con)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader
            While (dr.Read)
                combo.Items.Add(dr("designation").ToString())
            End While

        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub comboChanged(nomTable As String, combo As ComboBox, txt As TextBox)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("SELECT * FROM " + nomTable + " WHERE designation = '" + combo.Text + "' ", con)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader
            While (dr.Read)
                txt.Text = dr("code").ToString()
            End While

        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub comboChangedCodeClFss(nomTable As String, combo As ComboBox, txt As TextBox)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("SELECT * FROM " + nomTable + " WHERE noms = '" + combo.Text + "' ", con)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader
            While (dr.Read)
                txt.Text = dr("code").ToString()
            End While

        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub selectQuteProduit(nomTable As String, combo As ComboBox, txt As Label)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("SELECT SUM(qte) FROM " + nomTable + " WHERE designation = '" + combo.Text + "' ", con)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader
            While (dr.Read)
                Dim somme, sumQute As String
                somme = dr(0).ToString()
                If somme = Nothing Then
                    sumQute = 0
                Else
                    sumQute = somme
                End If
                txt.Text = sumQute
            End While

        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    'Ici commence les requetes Sur les opérations Crédit et Débit
    Public Sub insertOperation(nomTable As String, op As clsOpDebitCredit)

        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("INSERT INTO " + nomTable + " (code,designation,numCompte)  VALUES (@code,@designation,@numCompte)", con)
            cmd.Parameters.Add("@code", OleDbType.VarChar, 10, "code").Value = op.Code1
            cmd.Parameters.Add("@designation", OleDbType.VarChar, 100, "designation").Value = op.Designation1
            cmd.Parameters.Add("@numCompte", OleDbType.VarChar, 5, "numCompte").Value = op.NumCompt1
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sauvegarde réussie!")
        Catch ex As Exception
            Throw New Exception("Cette opération existe déjà")
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub updateOperation(nomTable As String, op As clsOpDebitCredit)

        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("UPDATE " + nomTable + "  SET designation=@designation,numCompte=@numCompte WHERE code=@code", con)
            cmd.Parameters.Add("@designation", OleDbType.VarChar, 100, "designation").Value = op.Designation1
            cmd.Parameters.Add("@numCompte", OleDbType.VarChar, 5, "numCompte").Value = op.NumCompt1
            cmd.Parameters.Add("@code", OleDbType.VarChar, 10, "code").Value = op.Code1
            cmd.ExecuteNonQuery()
            MessageBox.Show("Modification réussie!")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    'Ici commence les requetes sur les tables Client et Fournisseurs
    Public Sub insertClFss(nomTable As String, cl As clsClientFss)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("INSERT INTO " + nomTable + " (code,noms,sexe,adresse,contact)  VALUES (@code,@noms,@sexe,@adresse,@contact)", con)
            cmd.Parameters.Add("@code", OleDbType.VarChar, 10, "code").Value = cl.Code1
            cmd.Parameters.Add("@noms", OleDbType.VarChar, 50, "noms").Value = cl.Noms1
            cmd.Parameters.Add("@sexe", OleDbType.VarChar, 10, "sexe").Value = cl.Sexe1
            cmd.Parameters.Add("@adresse", OleDbType.VarChar, 100, "adresse").Value = cl.Adresse1
            cmd.Parameters.Add("@contact", OleDbType.VarChar, 20, "contact").Value = cl.Contact1
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sauvegarde réussie!")
        Catch ex As Exception
            Throw New Exception("Cette personne existe deja!")
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub updateClFss(nomTable As String, cl As clsClientFss)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("UPDATE " + nomTable + " SET noms=@noms,sexe=@sexe,adresse=@adresse,contact=@contact WHERE code=@code", con)
            cmd.Parameters.Add("@noms", OleDbType.VarChar, 50, "noms").Value = cl.Noms1
            cmd.Parameters.Add("@sexe", OleDbType.VarChar, 10, "sexe").Value = cl.Sexe1
            cmd.Parameters.Add("@adresse", OleDbType.VarChar, 100, "adresse").Value = cl.Adresse1
            cmd.Parameters.Add("@contact", OleDbType.VarChar, 20, "contact").Value = cl.Contact1
            cmd.Parameters.Add("@code", OleDbType.VarChar, 10, "code").Value = cl.Code1
            cmd.ExecuteNonQuery()
            MessageBox.Show("Modification réussie!")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub SearchClFss(nomTable As String, dataGridOp As DataGridView, txt As TextBox)

        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM " + nomTable + " WHERE code LIKE '%" + txt.Text + "%' OR noms LIKE '%" + txt.Text + "%' ", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")
            dataGridOp.DataSource = ds.Tables("operation")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'Ici commence les Requetes pour la table Produit
    Public Sub insertPro(nomTable As String, pr As clsProduit, picture As PictureBox)
        Try
            initialiseConn()
            Dim ms As New System.IO.MemoryStream
            Dim bmpImage As New Bitmap(picture.Image)
            Dim bytImage As Byte()
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            bytImage = ms.ToArray()
            ms.Close()

            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("INSERT INTO " + nomTable + " (code,designation,prixP,dateExp,imageBar)  VALUES (@code,@designation,@prixP,@dateExp,@imageBar)", con)
            cmd.Parameters.Add("@code", OleDbType.VarChar, 10, "code").Value = pr.Code1
            cmd.Parameters.Add("@designation", OleDbType.VarChar, 50, "designation").Value = pr.Designation1
            cmd.Parameters.Add("@prixP", OleDbType.Double, 10, "prixP").Value = pr.Prix1
            cmd.Parameters.Add("@dateExp", OleDbType.VarChar, 15, "dateExp").Value = pr.Dte1
            cmd.Parameters.Add("@imageBar", OleDbType.Binary, Int32.MaxValue, "imageBar").Value = bytImage
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sauvegarde réussie!")
        Catch ex As Exception
            Throw New Exception("Ce produit existe déjà")
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub updatePro(nomTable As String, pr As clsProduit, picture As PictureBox)
        Try
            initialiseConn()
            Dim ms As New System.IO.MemoryStream
            Dim bmpImage As New Bitmap(picture.Image)
            Dim bytImage As Byte()
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            bytImage = ms.ToArray()
            ms.Close()

            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("UPDATE " + nomTable + " SET designation=@designation,prixP=@prixP,dateExp=@dateExp,imageBar=@imageBar WHERE code=@code", con)
            cmd.Parameters.Add("@designation", OleDbType.VarChar, 50, "designation").Value = pr.Designation1
            cmd.Parameters.Add("@prixP", OleDbType.Double, 10, "prixP").Value = pr.Prix1
            cmd.Parameters.Add("@dateExp", OleDbType.VarChar, 15, "dateExp").Value = pr.Dte1
            cmd.Parameters.Add("@imageBar", OleDbType.Binary, Int32.MaxValue, "imageBar").Value = bytImage
            cmd.Parameters.Add("@code", OleDbType.VarChar, 10, "code").Value = pr.Code1
            cmd.ExecuteNonQuery()
            MessageBox.Show("Modification réussie!")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub SelectPicture(cp As clsProduit, picture As PictureBox)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If

            cmd = New OleDbCommand("select imageBar from tProduit where code=@code", con)
            cmd.Parameters.Add("@code", OleDbType.VarChar, 10, "@code").Value = cp.Code1
            Dim da As New OleDbDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "img")
            Dim c As Integer = ds.Tables("img").Rows.Count
            If (c > 0) Then
                Dim tab() As Byte = ds.Tables("img").Rows(c - 1)("imageBar")
                Dim stm As New MemoryStream(tab)
                picture.Image = Image.FromStream(stm)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub selectPro(nomTable As String, dataGridOp As DataGridView)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT code,designation,prixP,dateExp FROM " + nomTable + " ", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")
            dataGridOp.DataSource = ds.Tables("operation")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub SearchPro(dataGridOp As DataGridView, txt As TextBox)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT code,designation,prixP,dateExp FROM tProduit WHERE code LIKE '%" + txt.Text + "%' OR designation LIKE '%" + txt.Text + "%' ", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")
            dataGridOp.DataSource = ds.Tables("operation")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'Ici commence les requetes pour la table concerne
    Public Sub insertMouvement(mv As clsMouvementCompt)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("INSERT INTO  tConcerne (codeDebit,montDebit,codeCredit,montCredit,dateOp,codePro,libelle)  VALUES (@codeDebit,@montDebit,@codeCredit,@montCredit,@dateOp,@codePro,@libelle)", con)
            cmd.Parameters.Add("@codeDebit", OleDbType.VarChar, 10, "codeDebit").Value = mv.CodeDebit1
            cmd.Parameters.Add("@montDebit", OleDbType.Double, 10, "montDebit").Value = mv.MontDebit1
            cmd.Parameters.Add("@codeCredit", OleDbType.VarChar, 10, "codeCredit").Value = mv.CodeCredit1
            cmd.Parameters.Add("@montCredit", OleDbType.Double, 10, "montCredit").Value = mv.MontCredit1
            cmd.Parameters.Add("@dateOp", OleDbType.Date, 15, "dateOp").Value = mv.Dte1
            cmd.Parameters.Add("@codePro", OleDbType.VarChar, 10, "codePro").Value = mv.CodeProduit1
            cmd.Parameters.Add("@libelle", OleDbType.VarChar, 255, "libelle").Value = mv.Libelle1
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sauvegarde réussie!")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub updatemouv(mv As clsMouvementCompt, txt As TextBox)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("UPDATE tConcerne SET codeDebit=@codeDebit,montDebit=@montDebit,codeCredit=@codeCredit,montCredit=@montCredit,dateOp=@dateOp,codePro=@codePro,libelle=@libelle WHERE numOp = @numOp ", con)
            cmd.Parameters.Add("@codeDebit", OleDbType.VarChar, 10, "codeDebit").Value = mv.CodeDebit1
            cmd.Parameters.Add("@montDebit", OleDbType.Double, 10, "montDebit").Value = mv.MontDebit1
            cmd.Parameters.Add("@codeCredit", OleDbType.VarChar, 10, "codeCredit").Value = mv.CodeCredit1
            cmd.Parameters.Add("@montCredit", OleDbType.Double, 10, "montCredit").Value = mv.MontCredit1
            cmd.Parameters.Add("@dateOp", OleDbType.Date, 15, "dateOp").Value = mv.Dte1
            cmd.Parameters.Add("@codePro", OleDbType.VarChar, 10, "codePro").Value = mv.CodeProduit1
            cmd.Parameters.Add("@libelle", OleDbType.VarChar, 255, "libelle").Value = mv.Libelle1
            cmd.Parameters.Add("@numOp", OleDbType.Integer, 10, "numOp").Value = CInt(txt.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Modification réussie!")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub selectAllMouv(nomTable As String, dataGridOp As DataGridView)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM " + nomTable + " ORDER BY numOp Asc ", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")
            dataGridOp.DataSource = ds.Tables("operation")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub SearchMouvement(nomTable As String, dataGridOp As DataGridView, txt1 As DateTimePicker, txt2 As DateTimePicker)

        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM " + nomTable + " WHERE dateOp BETWEEN '" + CDate(txt1.Text) + "' AND '" + CDate(txt2.Text) + "' ORDER BY numOp Asc ", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")
            dataGridOp.DataSource = ds.Tables("operation")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'Ici commence les requetes pour La table commande et Approvisionnement
    Public Sub insertCmd_Approv(nomTable As String, cm As clsCmd_Approv)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("INSERT INTO  " + nomTable + " (codeEt,codePro,qte,dateOp)  VALUES (@codeEt,@codePro,@qte,@dateOp)", con)
            'cmd.Parameters.Add("@num", OleDbType.VarChar, 10, "num").Value = cm.CodeD
            cmd.Parameters.Add("@codeEt", OleDbType.VarChar, 10, "codeEt").Value = cm.CodeCl_Fss1
            cmd.Parameters.Add("@codePro", OleDbType.VarChar, 10, "codePro").Value = cm.CodeProduit1
            cmd.Parameters.Add("@qte", OleDbType.Integer, 10, "qte").Value = cm.Qte1
            cmd.Parameters.Add("@dateOp", OleDbType.Date, 15, "dateOp").Value = cm.Dte1
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sauvegarde réussie!")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub updateCmd_Approv(nomTable As String, cm As clsCmd_Approv, txt As TextBox)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            cmd = New OleDbCommand("UPDATE " + nomTable + " SET codeEt=@codeEt,codePro=@codePro,qte=@qte,dateOp=@dateOp WHERE num=@num ", con)
            cmd.Parameters.Add("@codeEt", OleDbType.VarChar, 10, "codeEt").Value = cm.CodeCl_Fss1
            cmd.Parameters.Add("@codePro", OleDbType.VarChar, 10, "codePro").Value = cm.CodeProduit1
            cmd.Parameters.Add("@qte", OleDbType.Integer, 10, "qte").Value = cm.Qte1
            cmd.Parameters.Add("@dateOp", OleDbType.Date, 15, "dateOp").Value = cm.Dte1
            cmd.Parameters.Add("@num", OleDbType.Integer, 10, "num").Value = CInt(txt.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Modification réussie!")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub selectAllCmdApprov(nomTable As String, dataGridOp As DataGridView)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM " + nomTable + " ORDER BY num ", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")
            dataGridOp.DataSource = ds.Tables("operation")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub SearchCmd_Approv(nomTable As String, dataGridOp As DataGridView, date2 As DateTimePicker)

        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM " + nomTable + " WHERE dateOp LIKE '%" + date2.Text + "%'", con)
            Dim ds As New DataSet
            dta.Fill(ds, "op")
            dataGridOp.DataSource = ds.Tables("op")
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'Ici commence les Etats de sortie
    Public Sub EtatJournal(rep As CrystalReportViewer)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM reqJournal ORDER BY numOp ", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")
            Dim rpt As New journalEtat

            rep.ReportSource = rpt
            rep.Refresh()
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub SearchJournal(rep As CrystalReportViewer, date1 As DateTimePicker, date2 As DateTimePicker)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM reqJournal WHERE dateOp BETWEEN '" + CDate(date1.Text) + "' AND '" + CDate(date2.Text) + "' ORDER BY numOp ", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")
            Dim rpt As New journalEtat

            rep.ReportSource = rpt
            rep.Refresh()
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub EtatGrandLivre(rep As CrystalReportViewer)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM GradnLivre_Balance", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")

            rep.Refresh()
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub SearchEtatGrandLivre(rep As CrystalReportViewer, txt As ComboBox)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM GradnLivre_Balance WHERE designation='" + txt.Text + "'", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")


            rep.Refresh()
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub EtatFacture(rep As CrystalReportViewer)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM reqFactureCl WHERE num=1", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")


            rep.Refresh()
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub EtatFactureSearch(rep As CrystalReportViewer, txt As TextBox, dateFact As DateTimePicker)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM reqFactureCl WHERE noms LIKE '%" + txt.Text + "%' AND  dateOp LIKE '%" + CDate(dateFact.Text) + "%' ", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")

            rep.Refresh()
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub EtatBalance(rep As CrystalReportViewer)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM GradnLivre_Balance", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")

            rep.Refresh()
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub EtatBonRequsition(rep As CrystalReportViewer)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM bonRequisition WHERE num=1", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")

            rep.Refresh()
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub EtatBonRequisitionSearch(rep As CrystalReportViewer, txt As TextBox, dateFact As DateTimePicker)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM bonRequisition WHERE noms LIKE '%" + txt.Text + "%' AND  dateOp LIKE '%" + CDate(dateFact.Text) + "%' ", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")

            rep.Refresh()
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub EtatQRcode(rep As CrystalReportViewer, combo As ComboBox)
        Try
            initialiseConn()
            If (Not con.State.ToString().ToLower().Trim().Equals("open")) Then
                con.Open()
            End If
            dta = New OleDbDataAdapter("SELECT * FROM tProduit WHERE designation='" + combo.Text + "'", con)
            Dim ds As New DataSet
            dta.Fill(ds, "operation")

            rep.Refresh()
        Catch ex As Exception
            Throw New Exception("Erreur " + ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
