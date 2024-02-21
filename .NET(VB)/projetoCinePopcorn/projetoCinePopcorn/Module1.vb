Imports System.Data.SqlClient
Imports ADODB

Module Module1
    'conexão do banco de dados
    Public db As ADODB.Connection 'variavel do banco de dados
    Public rs As ADODB.Recordset 'variavel da tabela
    Public sql, diretorio, resp As String          'variavel querys (C.R.U.D)
    Public caminho = Application.StartupPath & "\banco\cadastro.mdb"
    Public cont As Integer
    Sub carregar_catalogo()
        Try
            With Form4.DGV_1
                cont = 1
                sql = "select * from tb_filmes order by Filmes asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
        End Try
    End Sub
    Sub carrega_usuários()
        Try
            With Form7.DGV_1
                cont = 1
                sql = "select * from tb_usuarios order by nome asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(6).Value, rs.Fields(7).Value)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
        End Try
    End Sub
    Sub carregar_vendas()
        Try
            With Form8.DGV_1
                cont = 1
                sql = "select * from tb_vendas"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
        End Try
    End Sub
    Sub carregar_catalogo1()
        Try
            With Form3.DGV_1
                cont = 1
                sql = "select * from tb_filmes order by Filmes asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
        End Try
    End Sub

    Sub conectar_banco()
        'conexão SQL Server
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB; Data Source=DESKTOP-0HGIUCF;initial catalog=projetoCinePopcorn;trusted_connection=yes;")
            'MsgBox("Conexão realizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro de conexão!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub conectar_banco_access()
        'conexão de testes
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & caminho)
            'MsgBox("Conexão realizada com sucesso!", MsgBoxStyle.Information + vbOKOnly, "AVISO")

        Catch ex As Exception
            MsgBox("Erro de conexão!", MsgBoxStyle.Critical + vbOKOnly, "AVISO")

        End Try
    End Sub
    Sub limpar_cadastro()
        Try
            With Form2
                .txt_cpf.Clear()
                .txt_nome.Clear()
                .txt_dataNasc.ResetText()
                .txt_email.Clear()
                .txt_celular.Clear()
                .cmb_cargo.ResetText()
                .txt_senha.Clear()
                .txt_rsenha.Clear()
                .cmb_status.ResetText()
                .img_foto.Load(Application.StartupPath & "\imagens\new_user.png")
                .txt_cpf.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro na execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub combobox_cargo()
        With Form2
            .cmb_cargo.Items.Add("GERENTE")
            .cmb_cargo.Items.Add("OPERADOR DE CAIXA")
        End With
    End Sub
    Sub combobox_status()
        With Form2
            .cmb_status.Items.Add("ATIVO")
            .cmb_status.Items.Add("BLOQUEADO")
        End With
    End Sub
    Sub limpar_venda()
        With Form5
            .cmb_filmes.ResetText()
            .txt_sala.Clear()
            .cmb_secao.ResetText()
            .cmb_ingresso.ResetText()
            .txt_valor.Clear()
            .cmb_filmes.Focus()
        End With
    End Sub
    Sub carregar_salas()
        With Form6
            .cmb_sala.Items.Add("Sala1")
            .cmb_sala.Items.Add("Sala2")
            .cmb_sala.Items.Add("Sala3")
            .cmb_sala.Items.Add("Sala4")
        End With
    End Sub
End Module
