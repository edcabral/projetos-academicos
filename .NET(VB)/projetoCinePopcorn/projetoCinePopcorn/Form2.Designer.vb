<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_dataNasc = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_celular = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.txt_rsenha = New System.Windows.Forms.MaskedTextBox()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_editar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_deletar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_salvar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_cargo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(31, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CPF:"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(33, 142)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(365, 20)
        Me.txt_nome.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(31, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nome:"
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(33, 93)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(154, 20)
        Me.txt_cpf.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(31, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "E-mail:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(33, 191)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(217, 20)
        Me.txt_email.TabIndex = 4
        '
        'txt_dataNasc
        '
        Me.txt_dataNasc.Checked = False
        Me.txt_dataNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_dataNasc.Location = New System.Drawing.Point(265, 93)
        Me.txt_dataNasc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_dataNasc.Name = "txt_dataNasc"
        Me.txt_dataNasc.Size = New System.Drawing.Size(133, 20)
        Me.txt_dataNasc.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(263, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Data de Nascimento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(264, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Celular"
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(266, 191)
        Me.txt_celular.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_celular.Mask = "(99) 99999-9999"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(133, 20)
        Me.txt_celular.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(32, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Senha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(200, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Repita a senha:"
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(33, 241)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_senha.Size = New System.Drawing.Size(154, 20)
        Me.txt_senha.TabIndex = 6
        '
        'txt_rsenha
        '
        Me.txt_rsenha.Location = New System.Drawing.Point(203, 242)
        Me.txt_rsenha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_rsenha.Name = "txt_rsenha"
        Me.txt_rsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_rsenha.Size = New System.Drawing.Size(157, 20)
        Me.txt_rsenha.TabIndex = 7
        '
        'img_foto
        '
        Me.img_foto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(417, 86)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(100, 125)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 24
        Me.img_foto.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btn_editar)
        Me.Panel1.Controls.Add(Me.btn_deletar)
        Me.Panel1.Controls.Add(Me.btn_salvar)
        Me.Panel1.Controls.Add(Me.cmb_status)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cmb_cargo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.img_foto)
        Me.Panel1.Controls.Add(Me.txt_rsenha)
        Me.Panel1.Controls.Add(Me.txt_senha)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_celular)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_dataNasc)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_email)
        Me.Panel1.Controls.Add(Me.txt_cpf)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_nome)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(26, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 365)
        Me.Panel1.TabIndex = 28
        '
        'btn_editar
        '
        Me.btn_editar.AnimationHoverSpeed = 0.07!
        Me.btn_editar.AnimationSpeed = 0.03!
        Me.btn_editar.BaseColor = System.Drawing.Color.Navy
        Me.btn_editar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_editar.BorderSize = 1
        Me.btn_editar.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_editar.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_editar.CheckedForeColor = System.Drawing.Color.White
        Me.btn_editar.CheckedImage = CType(resources.GetObject("btn_editar.CheckedImage"), System.Drawing.Image)
        Me.btn_editar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_editar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_editar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_editar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_editar.LineColor = System.Drawing.Color.Blue
        Me.btn_editar.Location = New System.Drawing.Point(401, 258)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_editar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_editar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_editar.OnHoverImage = Nothing
        Me.btn_editar.OnHoverLineColor = System.Drawing.Color.Blue
        Me.btn_editar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_editar.Size = New System.Drawing.Size(116, 24)
        Me.btn_editar.TabIndex = 35
        Me.btn_editar.Text = "EDITAR"
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
        Me.btn_deletar.Location = New System.Drawing.Point(401, 288)
        Me.btn_deletar.Name = "btn_deletar"
        Me.btn_deletar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_deletar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_deletar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_deletar.OnHoverImage = Nothing
        Me.btn_deletar.OnHoverLineColor = System.Drawing.Color.Red
        Me.btn_deletar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_deletar.Size = New System.Drawing.Size(116, 24)
        Me.btn_deletar.TabIndex = 34
        Me.btn_deletar.Text = "DELETAR"
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
        Me.btn_salvar.Location = New System.Drawing.Point(401, 228)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_salvar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_salvar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_salvar.OnHoverImage = Nothing
        Me.btn_salvar.OnHoverLineColor = System.Drawing.Color.Lime
        Me.btn_salvar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_salvar.Size = New System.Drawing.Size(116, 24)
        Me.btn_salvar.TabIndex = 33
        Me.btn_salvar.Text = "SALVAR"
        '
        'cmb_status
        '
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Location = New System.Drawing.Point(203, 291)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(154, 21)
        Me.cmb_status.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(202, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Status da conta:"
        '
        'cmb_cargo
        '
        Me.cmb_cargo.FormattingEnabled = True
        Me.cmb_cargo.Location = New System.Drawing.Point(33, 291)
        Me.cmb_cargo.Name = "cmb_cargo"
        Me.cmb_cargo.Size = New System.Drawing.Size(154, 21)
        Me.cmb_cargo.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(32, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Cargo:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(149, -17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(250, 126)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(594, 422)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GERENCIAR CADASTRO"
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_dataNasc As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_celular As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents txt_rsenha As MaskedTextBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmb_cargo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_salvar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_deletar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_editar As Guna.UI.WinForms.GunaAdvenceButton
End Class
