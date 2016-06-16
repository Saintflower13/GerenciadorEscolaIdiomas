using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace EscolaIdiomas
{
    class GerenciadorBanco
    {
        static string strConexao = "Data Source=.\\SQLEXPRESS; Initial Catalog=MADRELINGUA; Integrated Security=SSPI;";

        struct Prof
        {
            public string cod, nome;
        };

        struct TurmaCurso
        {
            public string codTurma, nomeCurso;
        };


        //Cadastros

        public static bool CadastrarAluno(int codResp, string nomeAluno, string rg, 
                                          string cpf, string nasc, char sexo,
                                          string email, string telefone, string telefoneAlt,
                                          string endereco, string bairro, string cidade,
                                          string nomeMae, string nomePai, string telMae,
                                          string telPai, string foto)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                if (codResp == 0)
                {
                    cmd.CommandText = "SET DATEFORMAT DMY " +
                                      "INSERT INTO Aluno (nome_aluno, rg_aluno, cpf_aluno, " +
                                      "nasc_aluno, sexo_aluno, email_aluno, tel_aluno, tel_alternativo_aluno, " +
                                      "endereco_aluno, bairro_aluno, cidade_aluno, mae, tel_mae, " +
                                      "pai, tel_pai, foto_aluno) VALUES " +
                                      "(@nomeAluno, @rg, @cpf, @nasc, @sexo, @email, @tel, @telAlt, " +
                                      "@endereco, @bairro, @cidade, @mae, @telMae, @pai, @telPai, CONVERT(VARBINARY(MAX), @foto))";

                }
                else
                {
                    cmd.CommandText = "SET DATEFORMAT DMY " +
                                      "INSERT INTO Aluno (cod_responsavel, nome_aluno, rg_aluno, cpf_aluno, " +
                                      "nasc_aluno, sexo_aluno, email_aluno, tel_aluno, tel_alternativo_aluno, " +
                                      "endereco_aluno, bairro_aluno, cidade_aluno, mae, tel_mae, " +
                                      "pai, tel_pai, foto_aluno) VALUES " +
                                      "(@codResp, @nomeAluno, @rg, @cpf, @nasc, @sexo, @email, @tel, @telAlt, " +
                                      "@endereco, @bairro, @cidade, @mae, @telMae, @pai, @telPai, CONVERT(VARBINARY(MAX), @foto))";

                    cmd.Parameters.Add(new SqlParameter("@codResp", codResp));
                }

                cmd.Parameters.Add(new SqlParameter("@nomeAluno", nomeAluno));
                cmd.Parameters.Add(new SqlParameter("@rg", rg));
                cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
                cmd.Parameters.Add(new SqlParameter("@nasc", nasc));
                cmd.Parameters.Add(new SqlParameter("@sexo", sexo));
                cmd.Parameters.Add(new SqlParameter("@email", email));
                cmd.Parameters.Add(new SqlParameter("@tel", telefone));
                cmd.Parameters.Add(new SqlParameter("@telAlt", telefoneAlt));
                cmd.Parameters.Add(new SqlParameter("@endereco", endereco));
                cmd.Parameters.Add(new SqlParameter("@bairro", bairro));
                cmd.Parameters.Add(new SqlParameter("@cidade", cidade));
                cmd.Parameters.Add(new SqlParameter("@mae", nomeMae));
                cmd.Parameters.Add(new SqlParameter("@telMae", telMae));
                cmd.Parameters.Add(new SqlParameter("@pai", nomePai));
                cmd.Parameters.Add(new SqlParameter("@telPai", telPai));
                cmd.Parameters.Add(new SqlParameter("@foto", "SELECT * FROM OPENROWSET(BULK '"+foto+"', SINGLE_BLOB) a"));

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool CadastrarResponsavel(string nome, string rg,
                                                string cpf, string nasc, char sexo,
                                                string telefone, string telefoneAlt,
                                                string endereco, string bairro, string cidade)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SET DATEFORMAT DMY " +
                                  "INSERT INTO Responsavel " +
                                  "(nome_responsavel, rg_responsavel, cpf_responsavel, nasc_responsavel, sexo_responsavel, " +
                                  "tel_responsavel, tel_alternativo_responsavel, endereco_responsavel, bairro_responsavel, " +
                                  "cidade_responsavel) VALUES " +
                                  "(@nome, @rg, @cpf, @nasc, @sexo, @tel, @telAlt, " +
                                  "@endereco, @bairro, @cidade)";

                cmd.Parameters.Add(new SqlParameter("@nome", nome));
                cmd.Parameters.Add(new SqlParameter("@rg", rg));
                cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
                cmd.Parameters.Add(new SqlParameter("@nasc", nasc));
                cmd.Parameters.Add(new SqlParameter("@sexo", sexo));
                cmd.Parameters.Add(new SqlParameter("@tel", telefone));
                cmd.Parameters.Add(new SqlParameter("@telAlt", telefoneAlt));
                cmd.Parameters.Add(new SqlParameter("@endereco", endereco));
                cmd.Parameters.Add(new SqlParameter("@bairro", bairro));
                cmd.Parameters.Add(new SqlParameter("@cidade", cidade));

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool CadastrarProfessor(string nome, string rg, string cpf, string nasc, char sexo,
                                              string email, string telefone, string telefoneAlt,
                                              string endereco, string bairro, string cidade,
                                              string admissao, string foto)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                
                cmd.CommandText =  "SET DATEFORMAT DMY " +
                                   "INSERT INTO Professor (nome_prof, rg_prof, cpf_prof, " +
                                   "nasc_prof, sexo_prof, email_prof, tel_prof, tel_alternativo_prof, " +
                                   "endereco_prof, bairro_prof, cidade_prof, admissao_prof, foto_prof) VALUES " +
                                   "(@nome, @rg, @cpf, @nasc, @sexo, @email, @tel, @telAlt, " +
                                   "@endereco, @bairro, @cidade, @admissao, CONVERT(VARBINARY(MAX), @foto))";
                
                cmd.Parameters.Add(new SqlParameter("@nome", nome));
                cmd.Parameters.Add(new SqlParameter("@rg", rg));
                cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
                cmd.Parameters.Add(new SqlParameter("@nasc", nasc));
                cmd.Parameters.Add(new SqlParameter("@sexo", sexo));
                cmd.Parameters.Add(new SqlParameter("@email", email));
                cmd.Parameters.Add(new SqlParameter("@tel", telefone));
                cmd.Parameters.Add(new SqlParameter("@telAlt", telefoneAlt));
                cmd.Parameters.Add(new SqlParameter("@endereco", endereco));
                cmd.Parameters.Add(new SqlParameter("@bairro", bairro));
                cmd.Parameters.Add(new SqlParameter("@cidade", cidade));
                cmd.Parameters.Add(new SqlParameter("@admissao", admissao));
                cmd.Parameters.Add(new SqlParameter("@foto", "SELECT * FROM OPENROWSET(BULK '" + foto + "', SINGLE_BLOB) a"));

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool CadastrarCurso(string nome, string descricao, string duracaoMeses, string duracaoHoras,  int modulos, 
                                          string aulasSemanais, string matricula, float valorTotal,
                                          float multa, float rescisao)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SET DATEFORMAT DMY " +
                                  "INSERT INTO Curso (nome_curso, descricao_curso, duracao_meses, duracao_horas, qtd_modulos, qtd_aulas_semanais, " +
                                  "valor_matricula, valor_total, valor_multa, valor_rescisao) " +
                                  "VALUES " +
                                  "(@nome, @descricao, @meses, @horas, @modulos, @aSemanais, @vMatricula, @vTotal, @vMulta, @vRescisao)";
                
                cmd.Parameters.Add(new SqlParameter("@nome", nome));
                cmd.Parameters.Add(new SqlParameter("@descricao", descricao));
                cmd.Parameters.Add(new SqlParameter("@meses", duracaoMeses));
                cmd.Parameters.Add(new SqlParameter("@horas", duracaoHoras));
                cmd.Parameters.Add(new SqlParameter("@modulos", modulos));
                cmd.Parameters.Add(new SqlParameter("@aSemanais", aulasSemanais));
                cmd.Parameters.Add(new SqlParameter("@vMatricula", matricula));
                cmd.Parameters.Add(new SqlParameter("@vTotal", valorTotal));
                cmd.Parameters.Add(new SqlParameter("@vMulta", multa));
                cmd.Parameters.Add(new SqlParameter("@vRescisao", rescisao));

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool CadastrarModulo(int codModulo,int codCurso, string descricao)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "INSERT INTO Modulo (cod_moduloVisual, cod_curso, descricao_modulo) VALUES " +
                                  "(@codModulo, @codCurso, @descricao)";

                cmd.Parameters.Add(new SqlParameter("@codModulo", codModulo));
                cmd.Parameters.Add(new SqlParameter("@codCurso", codCurso));
                cmd.Parameters.Add(new SqlParameter("@descricao", descricao));

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool CadastrarTurma(int codMod, int qtdMax, string diasSemana, string horarioInicial, int codProf, string inicioAulas)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SET DATEFORMAT DMY " +
                                  "INSERT INTO Turma(cod_modulo, qtd_max_aluno, dias_semana, inicio_aulas, horario_inicial, cod_prof) " +
                                  "VALUES (@codMod, @qtdMax, @diasSemana, @inicioAulas, @horarioInicial, @codProf)";

                cmd.Parameters.Add(new SqlParameter("@codMod", codMod));
                cmd.Parameters.Add(new SqlParameter("@qtdMax", qtdMax));
                cmd.Parameters.Add(new SqlParameter("@diasSemana", diasSemana));
                cmd.Parameters.Add(new SqlParameter("@inicioAulas", inicioAulas));
                cmd.Parameters.Add(new SqlParameter("@horarioInicial", horarioInicial));
                cmd.Parameters.Add(new SqlParameter("@codProf", codProf));

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool CadastrarMatricula(int codTurma, int codAluno)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "INSERT INTO Matricula (cod_turma, cod_aluno) VALUES (@codTurma, @codAluno) " +
                                  "UPDATE Aluno SET situacao_aluno = 'a' FROM Aluno INNER JOIN Matricula " +
                                  "ON ALuno.cod_aluno = Matricula.cod_aluno " +
                                  "WHERE Matricula.cod_aluno = @codAluno";
                
                cmd.Parameters.Add(new SqlParameter("@codTurma", codTurma));
                cmd.Parameters.Add(new SqlParameter("@codAluno", codAluno));

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool CadastrarPagamento(string dataPagamento, int codMatricula)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SET DATEFORMAT DMY " +
                                  "INSERT INTO Pagamento (data_pagamento, cod_matricula) VALUES " +
                                  "(@dataPagamento, @codMatricula)";

                cmd.Parameters.Add(new SqlParameter("@dataPagamento", dataPagamento));
                cmd.Parameters.Add(new SqlParameter("@codMatricula", codMatricula));

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                conexao.Close();
            }
        }





        public static int GetIdade(string dataNasc, int dias)
        {
            int idade = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SET DATEFORMAT DMY " +
                                  "DECLARE @idade AS INT " +
                                  "DECLARE @dt_nascimento AS DATETIME " +
                                  "SET @dt_nascimento = @dataNasc " +
                                  "DECLARE @dt_atual AS DATE " +
                                  "SET @dt_atual = GETDATE() " +
                                  "DECLARE @dias AS INT " +
                                  "SET @dias = @vDias " +
                                  "IF (SELECT DATEADD(YEAR, @dias, @dt_nascimento)) > @dt_atual " +
                                  " SET @idade = DATEDIFF(YEAR, @dt_nascimento, @dt_atual) - 1 " +
                                  "ELSE " +
                                  " SET @idade = DATEDIFF(YEAR, @dt_nascimento, @dt_atual) " +
                                  "SELECT @idade";

                cmd.Parameters.Add(new SqlParameter("@dataNasc", dataNasc));
                cmd.Parameters.Add(new SqlParameter("@vDias", dias));

                cmd.CommandType = CommandType.Text;
                idade = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return idade;
        }

        public static string GetAno(string DATA)
        {
            string Ano = "";
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT YEAR(DATA)";
                cmd.CommandType = CommandType.Text;
                Ano = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return Ano;
        }

        public static int GetCodResp()
        {
            int cod = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 cod_responsavel FROM Responsavel ORDER BY cod_responsavel DESC";
                cmd.CommandType = CommandType.Text;
                cod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return cod;
        }

        public static int GetCodCurso()
        {
            int id = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 cod_curso FROM Curso ORDER BY cod_curso DESC";
                cmd.CommandType = CommandType.Text;
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return id;
        }

        public static int GetCodAluno()
        {
            int cod = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 cod_aluno FROM Aluno ORDER BY cod_aluno DESC";
                cmd.CommandType = CommandType.Text;
                cod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return cod;
        }

        public static int GetCodProf()
        {
            int cod = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 cod_prof FROM Professor ORDER BY cod_prof DESC";
                cmd.CommandType = CommandType.Text;
                cod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return cod;
        }

        public static string GetCodModuloReal(string codVisual, string nomeCurso)
        {
            string cod = "";
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT cod_modulo FROM Modulo INNER JOIN Curso " +
                                  "ON Curso.cod_curso = Modulo.cod_curso " +
                                  "WHERE cod_moduloVisual = @codVisual AND nome_curso = @nomeCurso";

                cmd.Parameters.Add(new SqlParameter("@codVisual", codVisual));
                cmd.Parameters.Add(new SqlParameter("@nomeCurso", nomeCurso));

                cmd.CommandType = CommandType.Text;
                cod = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return cod;
        }



        public static int GetCodCursoPorNome(string nome)
        {
            int cod = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT cod_curso FROM Curso WHERE nome_curso = @nome";
                cmd.Parameters.Add(new SqlParameter("@codCurso", nome));
                cmd.CommandType = CommandType.Text;
                cod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return cod;
        }

        public static int GetCodProfPorNome(string nome)
        {
            int cod = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT cod_prof FROM Professor WHERE nome_prof = @nome";
                cmd.Parameters.Add(new SqlParameter("@nome", nome));
                cmd.CommandType = CommandType.Text;
                cod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return cod;
        }

        public static int GetDiasPorSemana(string nome)
        {
            int dias = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT qtd_aulas_semanais FROM Curso WHERE nome_curso = @nome";
                cmd.Parameters.Add(new SqlParameter("@nome", nome));
                cmd.CommandType = CommandType.Text;
                dias = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dias;
        }

        public static int GetCodModulo(string CodCurso)
        {
            int cod = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 cod_moduloVisual FROM Modulo WHERE cod_curso = @codCurso ORDER BY cod_moduloVisual DESC";
                cmd.Parameters.Add(new SqlParameter("@codCurso", CodCurso));
                cmd.CommandType = CommandType.Text;
                cod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return cod;
        }

        public static int GetCodTurma(int codCurso)
        {
            int id = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 cod_turma FROM Turma INNER JOIN Curso ON Turma.cod_curso = Curso.cod_curso WHERE Curso.cod_curso = @codCurso ORDER BY cod_turma DESC";
                cmd.Parameters.Add(new SqlParameter("@codCurso", codCurso));
                cmd.CommandType = CommandType.Text;
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return id;
        }

        // Quantidade de matriculas em uma turma
        public static int GetQtdMatriculas(string codTurma)
        {
            int qtdMatriculas = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT COUNT(*) FROM Matricula INNER JOIN Turma " +
                                  "ON Matricula.cod_turma = Turma.cod_turma WHERE Turma.cod_turma = @codCurso";
                cmd.Parameters.Add(new SqlParameter("@codCurso", codTurma));
                cmd.CommandType = CommandType.Text;
                qtdMatriculas = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return qtdMatriculas;
        }

        public static int GetQtdAluno(string codTurma)
        {
            int qtdMod = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT qtd_max_aluno FROM Turma WHERE cod_turma = @codTurma";
                cmd.Parameters.Add(new SqlParameter("@codTurma", codTurma));
                cmd.CommandType = CommandType.Text;
                qtdMod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return qtdMod;
        }

        public static int GetDia(string data)
        {
            int dia = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SET DATEFORMAT DMY " +
                                  "SELECT DAY(@data);";
                cmd.Parameters.Add(new SqlParameter("@data", dia));
                cmd.CommandType = CommandType.Text;
                dia = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return dia;
        }

        
        

        public static List<string> getQtdModulos(string nomeCurso)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            List<string> lista = new List<string>();
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT cod_moduloVisual FROM Modulo INNER JOIN Curso ON Modulo.cod_curso = Curso.cod_curso WHERE nome_curso = @nome";
                cmd.Parameters.Add(new SqlParameter("@nome", nomeCurso));

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    lista.Add(dr.GetString(0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return lista;
        }

        public static List<string> getListaProf(string parte_nome)
        {
            Prof prof;

            SqlConnection conexao = new SqlConnection(strConexao);
            List<string> lista = new List<string>();
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT TOP 5 nome_prof, CONVERT(VARCHAR, cod_prof) FROM Professor WHERE nome_prof LIKE @nome";
                cmd.Parameters.Add(new SqlParameter("@nome", parte_nome + "%"));

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    prof.nome = dr.GetString(0);
                    prof.cod = dr.GetString(1);
                    lista.Add(prof.nome + " (código " + prof.cod + ")");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return lista;
        }

        public static List<string> getListaCursos(string parte_nome)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            List<string> lista = new List<string>();
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT TOP 5 nome_curso FROM Curso " +
                                  "WHERE nome_curso LIKE @nome";
                cmd.Parameters.Add(new SqlParameter("@nome", parte_nome + "%"));

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    lista.Add(dr.GetString(0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return lista;
        }

        public static List<string> getListaTotalProf()
        {
            Prof prof;

            SqlConnection conexao = new SqlConnection(strConexao);
            List<string> lista = new List<string>();
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT nome_prof, CONVERT(VARCHAR, cod_prof) FROM Professor";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    prof.nome = dr.GetString(0);
                    prof.cod = dr.GetString(1);

                    lista.Add(prof.nome + " (código " + prof.cod + ")");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return lista;
        }

        public static List<string> getListaTotalCurso()
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            List<string> lista = new List<string>();
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT TOP 5 nome_curso FROM Curso";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    lista.Add(dr.GetString(0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                conexao.Close();
            }
            return lista;
        }

        public static List<string> getListaTotalTurma()
        {
            TurmaCurso turmacurso;
            SqlConnection conexao = new SqlConnection(strConexao);
            List<string> lista = new List<string>();
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_turma), nome_curso From Curso INNER JOIN Modulo On Curso.cod_curso = Modulo.cod_curso " + 
                                  "INNER JOIN Turma ON Modulo.cod_modulo = Turma.cod_modulo ORDER BY nome_Curso, cod_turma";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    turmacurso.codTurma = dr.GetString(0);
                    turmacurso.nomeCurso = dr.GetString(1);

                    lista.Add(turmacurso.codTurma + " | " + turmacurso.nomeCurso);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            
            return lista;
        }

        public static List<string> getListaTotalNomeCodAluno()
        {
            string codAluno = "",
                   nomeAluno = "",
                   cpfAluno = "";

            SqlConnection conexao = new SqlConnection(strConexao);
            List<string> lista = new List<string>();
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_aluno), nome_aluno, cpf_aluno FROM Aluno";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    codAluno = dr.GetString(0);
                    nomeAluno = dr.GetString(1);
                    cpfAluno = dr.GetString(2);

                    lista.Add(codAluno + " | " + nomeAluno + " | " + cpfAluno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                conexao.Close();
            }
            return lista;
        }

        public static List<string> getListaTotalNomeCodAlunoPorNome(string parte_nome)
        {
            string codAluno = "",
                   nomeAluno = "",
                   cpfAluno = ""; 

            SqlConnection conexao = new SqlConnection(strConexao);
            List<string> lista = new List<string>();
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_aluno), nome_aluno, cpf_aluno FROM Aluno WHERE nome_aluno LIKE @nome";
                cmd.Parameters.Add(new SqlParameter("@nome", parte_nome + "%"));

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    codAluno = dr.GetString(0);
                    nomeAluno = dr.GetString(1);
                    cpfAluno = dr.GetString(2);

                    lista.Add(codAluno + " | " + nomeAluno + " | " + cpfAluno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                conexao.Close();
            }
            return lista;
        }

        public static List<string> getListaMatriculados(string codTurma)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            List<string> lista = new List<string>();
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_aluno) FROM matricula WHERE cod_turma = @codTurma";
                cmd.Parameters.Add(new SqlParameter("@codTurma", codTurma));

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    lista.Add(dr.GetString(0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return lista;
        }


        // Para Pagamentos
        public static List<string> getListaMatriculas()
        {
            string nomeAluno = "", codMatricula = "", nomeCurso = "";

            SqlConnection conexao = new SqlConnection(strConexao);
            List<string> lista = new List<string>();
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT nome_aluno, CONVERT(VARCHAR, cod_matricula), nome_curso FROM Aluno INNER JOIN Matricula " +
                                  "ON Aluno.cod_aluno = Matricula.cod_aluno INNER JOIN Turma " +
                                  "ON Matricula.cod_turma = Turma.cod_turma INNER JOIN Modulo " +
                                  "ON Modulo.cod_modulo = Turma.cod_modulo INNER JOIN Curso " +
                                  "ON Curso.cod_curso = Modulo.cod_curso";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nomeAluno = dr.GetString(0);
                    codMatricula = dr.GetString(1);
                    nomeCurso = dr.GetString(2);

                    lista.Add(nomeAluno + " | " + codMatricula + " | " + nomeCurso);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return lista;
        }

        public static string getParcela(string codMatricula)
        {
            string vParcela = "";

            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT CONVERT(VARCHAR, (valor_total / duracao_meses)) FROM Curso INNER JOIN Modulo " +
                                  "ON Curso.cod_curso = Modulo.cod_curso INNER JOIN Turma " +
                                  "ON Modulo.cod_modulo = Turma.cod_modulo INNER JOIN Matricula " +
                                  "On Matricula.cod_turma = Turma.cod_turma " +
                                  "WHERE Matricula.cod_matricula = @codMatricula";

                cmd.Parameters.Add(new SqlParameter("@codMatricula", codMatricula));


                vParcela = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return vParcela;
        }

        public static string getVencimento(string codMatricula)
        {
            string diaVencimento = "";

            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT CONVERT(VARCHAR, vencimento_parcela) From Matricula " +
                                  "WHERE cod_matricula = @codMatricula";
                cmd.Parameters.Add(new SqlParameter("@codMatricula", codMatricula));

                diaVencimento = Convert.ToString(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return diaVencimento;
        }

        public static string getMulta(string codMatricula)
        {
            string multa = "";

            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT CONVERT(VARCHAR, valor_multa) FROM Matricula INNER JOIN Turma " +
                                  "ON Matricula.cod_turma = Turma.cod_turma INNER JOIN Modulo " +
                                  "ON Modulo.cod_modulo = Turma.cod_modulo INNER JOIN Curso " +
                                  "On Curso.cod_curso = Modulo.cod_curso " +
                                  "WHERE cod_matricula = @codMatricula";
                cmd.Parameters.Add(new SqlParameter("@codMatricula", codMatricula));

                multa = Convert.ToString(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return multa;
        }




        // Consultas
        public static DataTable getMatriculas()
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_matricula) AS 'Código da Matricula', " +
                                  "CONVERT(VARCHAR, cod_curso) AS 'Código do Curso', " +
                                  "vencimento_parcela AS 'Vencimento da Parcela', " +
                                  "nome_aluno AS 'Nome do Aluno' FROM MATRICULA INNER JOIN Aluno " +
                                  "ON Matricula.cod_aluno = Aluno.cod_aluno INNER JOIN Turma " +
                                  "ON Turma.cod_curso = Matricula.cod_turma";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable getResponsavel()
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_responsavel) AS 'Código do Responsavel', " +
                                  "nome_responsavel AS 'Nome do Responsavel', " +
                                  "cpf_responsavel AS 'CPF do Responsavel' FROM Responsavel ORDER BY cod_responsavel";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable getResponsavelPorNome(string nome)
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_responsavel) AS 'Código do Responsavel', " +
                                  "nome_responsavel AS 'Nome do Responsavel', " +
                                  "cpf_responsavel AS 'CPF do Responsavel' FROM Responsavel " +
                                  "WHERE nome_responsavel LIKE @nome ORDER BY cod_responsavel";
                cmd.Parameters.Add(new SqlParameter("@nome", nome + "%"));
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable getAluno()
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_aluno) AS 'Código do Aluno', " +
                                  "nome_aluno AS 'Nome do Aluno', " +
                                  "cpf_aluno AS 'CPF do Aluno', " +
                                  "CONVERT(VARCHAR, cod_responsavel) AS 'Código do Responsavel' " +
                                  "FROM Aluno ORDER BY cod_responsavel";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable getAlunoPorNome(string nome)
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_aluno) AS 'Código do Aluno', " +
                                  "nome_aluno AS 'Nome do Aluno', " +
                                  "cpf_aluno AS 'CPF do Aluno', " +
                                  "CONVERT(VARCHAR, cod_responsavel) AS 'Código do Responsavel' FROM Aluno " +
                                  "WHERE nome_aluno LIKE @nome ORDER BY cod_aluno";
                cmd.Parameters.Add(new SqlParameter("@nome", nome + "%"));
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable getProfessor()
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_prof) AS 'Código do Professor', " +
                                  "nome_prof AS 'Nome do Professor', " +
                                  "cpf_prof AS 'CPF do Professor' FROM Professor ORDER BY cod_prof";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable getProfessorPorNome(string nome)
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_prof) AS 'Código do Professor', " +
                                  "nome_prof AS 'Nome do Professor', " +
                                  "cpf_prof AS 'CPF do Professor' FROM Professor " +
                                  "WHERE nome_prof LIKE @nome ORDER BY cod_prof" ;
                cmd.Parameters.Add(new SqlParameter("@nome", nome + "%"));
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable getCurso()
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_curso) AS 'Código do Curso', " +
                                  "nome_curso AS 'Nome do Curso' FROM Curso ORDER BY cod_curso";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable getCursoPorNome(string nome)
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_curso) AS 'Código do curso', " +
                                  "nome_curso AS 'Nome do Curso' FROM Curso " +
                                  "WHERE nome_curso LIKE @nome ORDER BY cod_curso";
                cmd.Parameters.Add(new SqlParameter("@nome", nome + "%"));
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable getTurma()
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_turma) AS 'Código da Turma', nome_curso AS 'Nome do Curso' FROM Turma INNER JOIN Modulo " +
                                  "ON Turma.cod_modulo = Modulo.cod_modulo INNER JOIN Curso " +
                                  "ON Curso.cod_curso = Modulo.cod_curso " +
                                  "ORDER BY nome_curso, cod_turma";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable getTurmaPorCurso(string nome)
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_turma) AS 'Código da Turma' " +
                                  "FROM Turma INNER JOIN Curso ON Curso.cod_curso = Turma.cod_curso " +
                                  "WHERE nome_curso LIKE @nome ORDER BY cod_turma";
                cmd.Parameters.Add(new SqlParameter("@nome", nome + "%"));
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable getModulo()
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT nome_curso AS 'Curso', " +
                                  "cod_modulo AS 'Código do Módulo', " +
                                  "cod_moduloVisual AS 'Número do Módulo' " +
                                  "FROM Modulo INNER JOIN Curso ON Modulo.cod_curso = Curso.cod_curso " +
                                  "ORDER BY nome_curso";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable getModuloPorCurso(string nome)
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT cod_modulo AS 'Código do Módulo', " +
                                  "cod_moduloVisual AS 'Número do Módulo', " +
                                  "descricao_modulo AS 'Descrição' " +
                                  "FROM Modulo INNER JOIN Curso ON Modulo.cod_curso = Curso.cod_curso " +
                                  "WHERE nome_curso LIKE @nome";

                cmd.Parameters.Add(new SqlParameter("@nome", nome + "%"));
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }



        // Relatórios
        
        // Alunos, lista de todos os cursos e todas as situações
        public static DataTable rAlunoTodosCurso()
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT situacao_aluno AS 'Situação do Aluno', nome_aluno AS 'Nome do Aluno', " +
                                  "cpf_aluno AS 'CPF do ALuno', tel_aluno AS 'Telefone do Aluno', " +
                                  "email_aluno AS 'Email do Aluno' FROM ALuno";

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }

        // Alunos, lista de todos os cursos por situação
        public static DataTable rAlunoTodosCursoSituacao(string situacaoAluno)
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT situacao_aluno AS 'Situação do Aluno', nome_aluno AS 'Nome do Aluno', " +
                                  "cpf_aluno AS 'CPF do ALuno', tel_aluno AS 'Telefone do Aluno', " +
                                  "email_aluno AS 'Email do Aluno' FROM ALuno WHERE situacao_aluno = @situacaoAluno";
                cmd.Parameters.Add(new SqlParameter("@situacaoAluno", situacaoAluno));

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }

        // Alunos, lista de alunos ativos do curso selecionado
        public static DataTable rAlunosAtivosCurso(string nomeCurso)
        {
            DataTable dt = null;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT situacao_aluno AS 'Situação do Aluno', nome_aluno AS 'Nome do Aluno', " +
                                  "cpf_aluno AS 'CPF do ALuno', tel_aluno AS 'Telefone do Aluno', " +
                                  "email_aluno AS 'Email do Aluno' FROM ALuno INNER JOIN Matricula " +
                                  "ON Aluno.cod_aluno = Matricula.cod_aluno INNER JOIN Turma " +
                                  "ON Matricula.cod_turma = Turma.cod_turma INNER JOIN Modulo " +
                                  "ON Modulo.cod_modulo = Turma.cod_modulo INNER JOIN Curso " +
                                  "ON Curso.cod_curso = Modulo.cod_curso " +
                                  "WHERE situacao_aluno = @situacaoAluno AND nome_curso = @nomeCurso";
                cmd.Parameters.Add(new SqlParameter("@situacaoAluno", "a"));
                cmd.Parameters.Add(new SqlParameter("@nomeCurso", nomeCurso));

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
