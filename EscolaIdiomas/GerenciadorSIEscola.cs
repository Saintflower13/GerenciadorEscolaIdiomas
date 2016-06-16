using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace EscolaIdiomas
{
    public class Verifica
    {
        public static bool Vazio(string CAMPO)
        {
            //Regex regex = new Regex(@"^[a-zA-Zà-ùÀ-Ù\s]+$");
            //if (regex.IsMatch(LETRAS))
            //    return true;
            //return false;

            if (CAMPO.Length > 0)
                return true;

            return false;
        }

        public static bool RG(string RG)
        {
            int soma = 0, j = 9;

            if (RG.Length != 9)
                return false;

            for (int i = 0; i < 8; ++i)
                soma += int.Parse(RG[i].ToString()) * (j--);

            string r = (soma % 11).ToString();

            if (r == "10") r = "X";
            if (r == RG[8].ToString()) return true;

            return false;
        }

        public static bool CPF(string CPF)
        {
            string r = "";
            int j = 10, soma = 0;

            if (CPF.Length != 11) return false;

            switch (CPF)
            {
                case "11111111111":
                    return false;
                case "22222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;
            }

            for (int i = 0; i <= 8; ++i)
                soma += int.Parse(CPF[i].ToString()) * j--;

            r = ((soma * 10) % 11).ToString();

            if (r == "10") r = "0";
            if (r != CPF[9].ToString()) return false;

            soma = 0;
            j = 11;

            for (int i = 0; i <= 9; ++i)
                soma += int.Parse(CPF[i].ToString()) * j--;

            r = ((soma * 10) % 11).ToString();

            if (r == "10") r = "0";

            if (r != CPF[10].ToString()) return false;

            return true;
        }

        public static bool Email(string EMAIL)
        {
            Regex regex = new Regex(@"\w+@\w+\.\w+(\.\w)?");

            if (regex.IsMatch(EMAIL))
                return true;
            return false;
        }

        public static bool DDDeTelefone(string DDD, string TEL)
        {
            if ((DDD.Length < 2) || (TEL.Length < 8)) return false;
            return true;
        }

        public static bool DDDeTelefoneALT(string DDD, string TEL)
        {
            if (DDD.Length == 0 && TEL.Length == 0)
                return true;
            else
            {
                if ((DDD.Length < 2) || (TEL.Length < 8)) return false;
            }

            return true;
        }

        public static bool Maioridade(string DATA)
        {
            int dias = DateTime.Now.Day - GerenciadorBanco.GetDia(DATA);

            if (GerenciadorBanco.GetIdade(DATA, dias) < 18)
                return false;
            else
                return true;
        }

        public static bool Moeda(string FORMATO)
        {
            if (FORMATO.Length == 0)
                return false;

            Regex regex = new Regex(@"^(\d{1,3}){1}(\.\d{3})*(\,\d{2})?$");
            if (regex.IsMatch(FORMATO))
                return true;
            return false;
        }

        public static bool CursoExiste(string CURSO)
        {
            List<string> listaCursos = GerenciadorBanco.getListaTotalCurso();

            for (int i = 0; i < listaCursos.Count(); ++i)
            {
                if (listaCursos[i] == CURSO)
                    return true;
            }

            return false;
        }

        public static bool ProfessorExiste(string PROFESSOR)
        {
            List<string> listaProf = GerenciadorBanco.getListaTotalProf();

            for (int i = 0; i < listaProf.Count(); ++i)
            {
                if (listaProf[i] == PROFESSOR)
                    return true;
            }

            return false;
        }

        public static bool PodeMatricular(string codTurma)
        {
            if (GerenciadorBanco.GetQtdMatriculas(codTurma) >= GerenciadorBanco.GetQtdAluno(codTurma))
                return false;

            return true;
        }

        public static bool AlunoCadastrado(string codAluno, string codTurma)
        {
            List<string> listaMatriculas = GerenciadorBanco.getListaMatriculados(codTurma);

            for (int i = 0; i < listaMatriculas.Count(); ++i)
            {
                if (listaMatriculas[i] == codAluno)
                    return true;
            }

            return false;
        }
    }
}
