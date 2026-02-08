<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProduit
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduit))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dateExipiration = New System.Windows.Forms.DateTimePicker()
        Me.txtPrix = New System.Windows.Forms.TextBox()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.Bd_RudolfDataSet = New ExamenVB.bd_RudolfDataSet()
        Me.TProduitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TProduitTableAdapter = New ExamenVB.bd_RudolfDataSetTableAdapters.tProduitTableAdapter()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateExpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImageBarDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Bd_RudolfDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TProduitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.dateExipiration)
        Me.GroupBox1.Controls.Add(Me.txtPrix)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.txtDesignation)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(822, 407)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opérations"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(409, 88)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(131, 34)
        Me.Button6.TabIndex = 48
        Me.Button6.Text = "ENCODER"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(560, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 163)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'dateExipiration
        '
        Me.dateExipiration.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateExipiration.Location = New System.Drawing.Point(215, 74)
        Me.dateExipiration.Name = "dateExipiration"
        Me.dateExipiration.Size = New System.Drawing.Size(136, 21)
        Me.dateExipiration.TabIndex = 46
        '
        'txtPrix
        '
        Me.txtPrix.Location = New System.Drawing.Point(215, 47)
        Me.txtPrix.Name = "txtPrix"
        Me.txtPrix.Size = New System.Drawing.Size(170, 21)
        Me.txtPrix.TabIndex = 45
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(102, 82)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl9.TabIndex = 43
        Me.LabelControl9.Text = "DATE D'EPIRATION"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(102, 55)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl8.TabIndex = 42
        Me.LabelControl8.Text = "PRIX UNITAIRE"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(102, 28)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl7.TabIndex = 41
        Me.LabelControl7.Text = "DESIGNATION"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.CodeDataGridViewTextBoxColumn, Me.DesignationDataGridViewTextBoxColumn, Me.PrixPDataGridViewTextBoxColumn, Me.DateExpDataGridViewTextBoxColumn, Me.ImageBarDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.TProduitBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-16, 169)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(837, 180)
        Me.DataGridView1.TabIndex = 40
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Designation"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 500
        '
        'Column3
        '
        Me.Column3.HeaderText = "Prix Unitaire"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Date Expiration"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(143, 109)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl6.TabIndex = 37
        Me.LabelControl6.Text = "CODE"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(215, 101)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(170, 21)
        Me.txtCode.TabIndex = 36
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(409, 128)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 31)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "NEW"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(352, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 31)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(287, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 31)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "EDIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(213, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 31)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(-71, 147)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl4.TabIndex = 30
        Me.LabelControl4.Text = "Adresse"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(-74, 100)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl3.TabIndex = 29
        Me.LabelControl3.Text = "Contact"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(-74, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl2.TabIndex = 28
        Me.LabelControl2.Text = "Sexe"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(-68, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl1.TabIndex = 27
        Me.LabelControl1.Text = "Nom"
        '
        'txtDesignation
        '
        Me.txtDesignation.Location = New System.Drawing.Point(215, 20)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(170, 21)
        Me.txtDesignation.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LabelControl11)
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.LabelControl5)
        Me.Panel2.Location = New System.Drawing.Point(12, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(822, 64)
        Me.Panel2.TabIndex = 5
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(538, 24)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl11.TabIndex = 38
        Me.LabelControl11.Text = "Recherche"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(607, 21)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(185, 21)
        Me.txtSearch.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Location = New System.Drawing.Point(65, 21)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(318, 25)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "ENREGISTREMENT DES PRODUITS"
        '
        'Bd_RudolfDataSet
        '
        Me.Bd_RudolfDataSet.DataSetName = "bd_RudolfDataSet"
        Me.Bd_RudolfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TProduitBindingSource
        '
        Me.TProduitBindingSource.DataMember = "tProduit"
        Me.TProduitBindingSource.DataSource = Me.Bd_RudolfDataSet
        '
        'TProduitTableAdapter
        '
        Me.TProduitTableAdapter.ClearBeforeFill = True
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        '
        'DesignationDataGridViewTextBoxColumn
        '
        Me.DesignationDataGridViewTextBoxColumn.DataPropertyName = "designation"
        Me.DesignationDataGridViewTextBoxColumn.HeaderText = "designation"
        Me.DesignationDataGridViewTextBoxColumn.Name = "DesignationDataGridViewTextBoxColumn"
        '
        'PrixPDataGridViewTextBoxColumn
        '
        Me.PrixPDataGridViewTextBoxColumn.DataPropertyName = "prixP"
        Me.PrixPDataGridViewTextBoxColumn.HeaderText = "prixP"
        Me.PrixPDataGridViewTextBoxColumn.Name = "PrixPDataGridViewTextBoxColumn"
        '
        'DateExpDataGridViewTextBoxColumn
        '
        Me.DateExpDataGridViewTextBoxColumn.DataPropertyName = "dateExp"
        Me.DateExpDataGridViewTextBoxColumn.HeaderText = "dateExp"
        Me.DateExpDataGridViewTextBoxColumn.Name = "DateExpDataGridViewTextBoxColumn"
        '
        'ImageBarDataGridViewImageColumn
        '
        Me.ImageBarDataGridViewImageColumn.DataPropertyName = "ImageBar"
        Me.ImageBarDataGridViewImageColumn.HeaderText = "ImageBar"
        Me.ImageBarDataGridViewImageColumn.Name = "ImageBarDataGridViewImageColumn"
        '
        'frmProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 332)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProduit"
        Me.Text = "frmProduit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Bd_RudolfDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TProduitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDesignation As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrix As TextBox
    Friend WithEvents dateExipiration As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Button6 As Button
    Friend WithEvents Bd_RudolfDataSet As bd_RudolfDataSet
    Friend WithEvents TProduitBindingSource As BindingSource
    Friend WithEvents TProduitTableAdapter As bd_RudolfDataSetTableAdapters.tProduitTableAdapter
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DesignationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrixPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateExpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImageBarDataGridViewImageColumn As DataGridViewImageColumn
End Class
