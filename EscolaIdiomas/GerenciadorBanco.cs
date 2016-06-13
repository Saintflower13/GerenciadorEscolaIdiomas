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
                                      "pai, tel_pai, foto_aluno, situacao_aluno) VALUES " +
                                      "(@nomeAluno, @rg, @cpf, @nasc, @sexo, @email, @tel, @telAlt, " +
                                      "@endereco, @bairro, @cidade, @mae, @telMae, @pai, @telPai, CONVERT(VARBINARY(MAX), @foto), @situacao)";

                }
                else
                {
                    cmd.CommandText = "SET DATEFORMAT DMY " +
                                      "INSERT INTO Aluno (cod_responsavel, nome_aluno, rg_aluno, cpf_aluno, " +
                                      "nasc_aluno, sexo_aluno, email_aluno, tel_aluno, tel_alternativo_aluno, " +
                                      "endereco_aluno, bairro_aluno, cidade_aluno, mae, tel_mae, " +
                                      "pai, tel_pai, foto_aluno, situacao_aluno) VALUES " +
                                      "(@codResp, @nomeAluno, @rg, @cpf, @nasc, @sexo, @email, @tel, @telAlt, " +
                                      "@endereco, @bairro, @cidade, @mae, @telMae, @pai, @telPai, CONVERT(VARBINARY(MAX), @foto), @situacao)";

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
                cmd.Parameters.Add(new SqlParameter("@situacao", 'i'));

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
                                  "INSERT INTO Responsavel VALUES " +
                                  "(@nome, @rg, @cpf, @nasc, @sexo, @tel, @telAlt, " +
                                  "@endereco, @bairro, @cidade, @situacao)";

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
                cmd.Parameters.Add(new SqlParameter("@situacao", 'a'));

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
                
                cmd.CommandText = "SET DATEFORMAT DMY " +
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

        public static bool CadastrarCurso(int codCurso, string nome, string duracaoMeses, string duracaoHoras,  int modulos, 
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
                                  "INSERT INTO Curso (cod_curso, nome_curso, duracao_meses, duracao_horas, qtd_modulos, qtd_aulas_semanais, " +
                                  "valor_matricula, valor_total, valor_multa, valor_rescisao) " +
                                  "VALUES " +
                                  "(@cod, @nome, @meses, @horas, @modulos, @aSemanais, @vMatricula, @vTotal, @vMulta, @vRescisao)";

                cmd.Parameters.Add(new SqlParameter("@cod", codCurso));
                cmd.Parameters.Add(new SqlParameter("@nome", nome));
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
                cmd.CommandText = "INSERT INTO Modulo (cod_modulo, cod_curso, descricao_modulo) VALUES " +
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

        public static bool CadastrarTurma(int codTurma, int codCurso, int qtdMin, int qtdMax, string diasSemana, string horarioInicial, int codProf)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "INSERT INTO Turma(cod_turma, cod_curso, qtd_min_aluno,  qtd_max_aluno, dias_semana, horario_inicial, cod_prof) " +
                                  "VALUES (@codTurma, @codCurso, @qtdMin, @qtdMax, @diasSemana, @horarioInicial, codProf)";

                cmd.Parameters.Add(new SqlParameter("@codTurma", codTurma));
                cmd.Parameters.Add(new SqlParameter("@codCurso", codCurso));
                cmd.Parameters.Add(new SqlParameter("@qtdMin", qtdMin));
                cmd.Parameters.Add(new SqlParameter("@qtdMax", qtdMax));
                cmd.Parameters.Add(new SqlParameter("@diasSemana", diasSemana));
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
            int id = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 cod_responsavel FROM Responsavel ORDER BY cod_responsavel DESC";
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

        public static int GetCodModulo(string CodCurso)
        {
            int id = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT TOP 1 cod_modulo FROM Modulo WHERE cod_curso = @codCurso ORDER BY cod_modulo DESC";
                cmd.Parameters.Add(new SqlParameter("@codCurso", CodCurso));
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

        public static int GetQtdMod(string nomeCurso)
        {
            int qtdMod = 0;
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = "SELECT qtd_modulos FROM Curso WHERE nome_curso = @nomeCurso";
                cmd.Parameters.Add(new SqlParameter("@nomeCurso", nomeCurso));
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

                cmd.CommandText = "SELECT TOP 5 nome_curso FROM Curso WHERE nome_curso LIKE @nome";
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

                cmd.CommandText = "SELECT CONVERT(VARCHAR, cod_modulo) FROM Modulo INNER JOIN Curso ON Modulo.cod_curso = Curso.cod_curso WHERE nome_curso = @nome";
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

        public static List<string> getLista(string parte_nome)
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

                cmd.CommandText = "SELECT nome_curso FROM Curso";

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

    }
}
