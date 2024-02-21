<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoFilmeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmCartazToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_1 = New System.Windows.Forms.DataGridView()
        Me.btn_fechar = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_fechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(487, 325)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoToolStripMenuItem, Me.ProdutosToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(511, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatalogoToolStripMenuItem
        '
        Me.CatalogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoFilmeToolStripMenuItem})
        Me.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        Me.CatalogoToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.CatalogoToolStripMenuItem.Text = "Catálogo"
        '
        'NovoFilmeToolStripMenuItem
        '
        Me.NovoFilmeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmCartazToolStripMenuItem})
        Me.NovoFilmeToolStripMenuItem.Name = "NovoFilmeToolStripMenuItem"
        Me.NovoFilmeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NovoFilmeToolStripMenuItem.Text = "Filmes"
        '
        'EmCartazToolStripMenuItem
        '
        Me.EmCartazToolStripMenuItem.Name = "EmCartazToolStripMenuItem"
        Me.EmCartazToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EmCartazToolStripMenuItem.Text = "Em cartaz"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaVendaToolStripMenuItem})
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ProdutosToolStripMenuItem.Text = "Vendas"
        '
        'NovaVendaToolStripMenuItem
        '
        Me.NovaVendaToolStripMenuItem.Name = "NovaVendaToolStripMenuItem"
        Me.NovaVendaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NovaVendaToolStripMenuItem.Text = "Nova venda"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncerrarSeToolStripMenuItem, Me.FecharProgramaToolStripMenuItem})
        Me.SairToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SairToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'EncerrarSeToolStripMenuItem
        '
        Me.EncerrarSeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EncerrarSeToolStripMenuItem.Name = "EncerrarSeToolStripMenuItem"
        Me.EncerrarSeToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EncerrarSeToolStripMenuItem.Text = "Encerrar sessão"
        '
        'FecharProgramaToolStripMenuItem
        '
        Me.FecharProgramaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecharProgramaToolStripMenuItem.Name = "FecharProgramaToolStripMenuItem"
        Me.FecharProgramaToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.FecharProgramaToolStripMenuItem.Text = "Fechar programa"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.DGV_1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(12, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 317)
        Me.Panel1.TabIndex = 3
        '
        'DGV_1
        '
        Me.DGV_1.AllowUserToAddRows = False
        Me.DGV_1.AllowUserToDeleteRows = False
        Me.DGV_1.BackgroundColor = System.Drawing.Color.Silver
        Me.DGV_1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DGV_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGV_1.Location = New System.Drawing.Point(0, 0)
        Me.DGV_1.Name = "DGV_1"
        Me.DGV_1.ReadOnly = True
        Me.DGV_1.Size = New System.Drawing.Size(487, 317)
        Me.DGV_1.TabIndex = 3
        Me.DGV_1.Visible = False
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.Image = CType(resources.GetObject("btn_fechar.Image"), System.Drawing.Image)
        Me.btn_fechar.Location = New System.Drawing.Point(472, 0)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(27, 23)
        Me.btn_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btn_fechar.TabIndex = 4
        Me.btn_fechar.TabStop = False
        Me.btn_fechar.Visible = False
        '
        'Column1
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "FILMES"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "GÊNERO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "DURAÇÃO (min)"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "SALA"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(511, 364)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU OPERADOR"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_fechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatalogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoFilmeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FecharProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EmCartazToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovaVendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGV_1 As DataGridView
    Friend WithEvents btn_fechar As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
