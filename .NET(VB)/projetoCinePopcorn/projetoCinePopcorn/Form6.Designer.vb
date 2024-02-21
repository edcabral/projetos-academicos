<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_salvar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_deletar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.cmb_sala = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_genero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_duracao = New System.Windows.Forms.TextBox()
        Me.txt_nomeFilme = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btn_salvar)
        Me.Panel1.Controls.Add(Me.btn_deletar)
        Me.Panel1.Controls.Add(Me.cmb_sala)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_genero)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_duracao)
        Me.Panel1.Controls.Add(Me.txt_nomeFilme)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 259)
        Me.Panel1.TabIndex = 0
        '
        'btn_salvar
        '
        Me.btn_salvar.AnimationHoverSpeed = 0.07!
        Me.btn_salvar.AnimationSpeed = 0.03!
        Me.btn_salvar.BaseColor = System.Drawing.Color.Green
        Me.btn_salvar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_salvar.BorderSize = 1
        Me.btn_salvar.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_salvar.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_salvar.CheckedForeColor = System.Drawing.Color.White
        Me.btn_salvar.CheckedImage = CType(resources.GetObject("btn_salvar.CheckedImage"), System.Drawing.Image)
        Me.btn_salvar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_salvar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_salvar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_salvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_salvar.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_salvar.Location = New System.Drawing.Point(200, 200)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_salvar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_salvar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_salvar.OnHoverImage = Nothing
        Me.btn_salvar.OnHoverLineColor = System.Drawing.Color.Lime
        Me.btn_salvar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_salvar.Size = New System.Drawing.Size(116, 24)
        Me.btn_salvar.TabIndex = 44
        Me.btn_salvar.Text = "SALVAR"
        '
        'btn_deletar
        '
        Me.btn_deletar.AnimationHoverSpeed = 0.07!
        Me.btn_deletar.AnimationSpeed = 0.03!
        Me.btn_deletar.BaseColor = System.Drawing.Color.Maroon
        Me.btn_deletar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_deletar.BorderSize = 1
        Me.btn_deletar.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_deletar.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_deletar.CheckedForeColor = System.Drawing.Color.White
        Me.btn_deletar.CheckedImage = CType(resources.GetObject("btn_deletar.CheckedImage"), System.Drawing.Image)
        Me.btn_deletar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_deletar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_deletar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_deletar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deletar.ForeColor = System.Drawing.Color.White
        Me.btn_deletar.Image = CType(resources.GetObject("btn_deletar.Image"), System.Drawing.Image)
        Me.btn_deletar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_deletar.LineColor = System.Drawing.Color.RosyBrown
        Me.btn_deletar.Location = New System.Drawing.Point(59, 200)
        Me.btn_deletar.Name = "btn_deletar"
        Me.btn_deletar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_deletar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_deletar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_deletar.OnHoverImage = Nothing
        Me.btn_deletar.OnHoverLineColor = System.Drawing.Color.Red
        Me.btn_deletar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_deletar.Size = New System.Drawing.Size(116, 24)
        Me.btn_deletar.TabIndex = 43
        Me.btn_deletar.Text = "DELETAR"
        '
        'cmb_sala
        '
        Me.cmb_sala.FormattingEnabled = True
        Me.cmb_sala.Location = New System.Drawing.Point(200, 160)
        Me.cmb_sala.Name = "cmb_sala"
        Me.cmb_sala.Size = New System.Drawing.Size(148, 21)
        Me.cmb_sala.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(197, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Sala:"
        '
        'txt_genero
        '
        Me.txt_genero.Location = New System.Drawing.Point(200, 113)
        Me.txt_genero.Name = "txt_genero"
        Me.txt_genero.Size = New System.Drawing.Size(148, 20)
        Me.txt_genero.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(197, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Gênero:"
        '
        'txt_duracao
        '
        Me.txt_duracao.Location = New System.Drawing.Point(27, 160)
        Me.txt_duracao.Name = "txt_duracao"
        Me.txt_duracao.Size = New System.Drawing.Size(148, 20)
        Me.txt_duracao.TabIndex = 37
        '
        'txt_nomeFilme
        '
        Me.txt_nomeFilme.Location = New System.Drawing.Point(27, 113)
        Me.txt_nomeFilme.Name = "txt_nomeFilme"
        Me.txt_nomeFilme.Size = New System.Drawing.Size(148, 20)
        Me.txt_nomeFilme.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Duração:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Nome do filme:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(92, -24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(195, 118)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(397, 285)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDITAR CATÁLOGO"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_duracao As TextBox
    Friend WithEvents txt_nomeFilme As TextBox
    Friend WithEvents cmb_sala As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_genero As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_deletar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_salvar As Guna.UI.WinForms.GunaAdvenceButton
End Class
