Imports System.Data.OleDb

Imports DevExpress.XtraReports.UI
Imports System.IO

Public Class Acceuil

    Dim cnx As clsConnexion = New clsConnexion
    Dim con As OleDbConnection
    Private Sub NavBarItem1_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkPressed

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub
    Private Sub NavBarItem9_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem9.LinkClicked

    End Sub

    Private Sub NavBarItem5_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem5.LinkClicked

    End Sub

    Private Sub NavBarItem10_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem10.LinkClicked
        For Each child In MdiChildren
            child.Close()
        Next
        Dim frm As New frmCli_Fss
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''  Dim ligne As String
        ''  Dim SR As New StreamReader("D:\ExamenVB\connexion.txt")
        ''  Do Until (SR.Peek = -1)
        ''   'ligne = SR.ReadLine
        ''  ModuleConnexion.varconnexion = ligne
        ''  Loop

        ''  SR.Close()

    End Sub

    Private Sub ComptesList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ComptesList.ItemClick


    End Sub

    Private Sub RapportOperation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles RapportOperation.ItemClick
        For Each child In MdiChildren
            child.Close()
        Next
        Dim frm As New frmOperations
        frm.MdiParent = Me
        frm.Show()


    End Sub

    Private Sub Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Journal.ItemClick
        For Each child In MdiChildren
            child.Close()
        Next
        Dim frm As New frmMouvement
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub LivreCaisse_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles LivreCaisse.ItemClick



    End Sub

    Private Sub Connexion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Connexion.ItemClick
        Dim ligne As String
        Dim SR As New StreamReader("C:\Users\Eugene Tondeka\Documents\bd_Rudolf.accdb")
        Do Until (SR.Peek = -1)
            ligne = SR.ReadLine
            ModuleConnexion.varconnexion = ligne
        Loop


    End Sub

    Private Sub UtilisationCompte_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UtilisationCompte.ItemClick
        For Each child In MdiChildren
            child.Close()
        Next
        Dim frm As New frmCli_Fss
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub Recu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Recu.ItemClick


    End Sub

    Private Sub ComptesClient_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ComptesClient.ItemClick

    End Sub

    Private Sub Rapports_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Rapports.ItemClick

    End Sub

    Private Sub Acces_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Acces.ItemClick

    End Sub

    Private Sub NavBarControl1_Click(sender As Object, e As EventArgs) Handles NavBarControl1.Click

    End Sub
End Class