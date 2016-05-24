using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EscolaIdiomas
{
    public class Pessoa
    {
        public static bool VerificaLetras(string LETRAS)
        {
            Regex regex = new Regex(@"^[a-zA-Z\s]+$");
            if (regex.IsMatch(LETRAS))
                return true;
            return false;
        }

        public static bool VerificaRG(string RG)
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

        public static bool VerificaCPF(string CPF)
        {
            string r = "";
            int j = 10, soma = 0;

            if (CPF.Length != 11) return false;

            switch (CPF)
            {
                case "11111111111":
                    return false;
                case "00000000000":
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

        public static bool VerificaEmail(string EMAIL)
        {
            Regex regex = new Regex(@"\w+@\w+\.\w+(\.\w)?");

            if (regex.IsMatch(EMAIL))
                return true;
            return false;
        }

        public static bool VerificaDDDeTelefone(string DDD, string TEL)
        {
            if ((DDD.Length < 2) || (TEL.Length < 8)) return false;
            return true;
        }

        public static bool Bissexto(string ANO)
        {
            string f = ANO[2].ToString() + ANO[3];
            bool bissexto = false;

            if ((int.Parse(ANO) % 4) == 0)
            {
                if (!(f[0] == 0 && f[1] == 0))
                {
                    bissexto = true;
                }
                else
                {
                    if (int.Parse(ANO) % 400 == 0)
                        bissexto = true;
                }
            }

            return bissexto;
        }

        public static bool VerificaData(string DATA)
        {
            if (DATA.Length != 8) return false;

            int dia = int.Parse(DATA[0].ToString() + DATA[1].ToString());
            int mes = int.Parse(DATA[2].ToString() + DATA[3].ToString());
            int ano = int.Parse(DATA[4].ToString() + DATA[5].ToString() +
                                DATA[6].ToString() + DATA[7].ToString());

            if (mes > 12) return false;

            if (ano < 1900 || ano > DateTime.Now.Year) return false;

            if (mes < 07)
            {
                if (mes == 02)
                {
                    if (DateTime.IsLeapYear(ano) && dia > 29) { return false; }
                }
                else
                    if (dia > 28) return false;

                if ((mes % 2) == 0)
                {
                    if (dia > 30) return false;
                }    
                else
                    if (dia > 31) return false;
            }

            if (mes == 07)
                if (dia > 31) return false;

            if (mes > 7)
            {
                if ((mes % 2) == 0)
                {
                    if (dia > 31) return false;
                }
                else
                    if (dia > 30) return false;
            }
            
            return true;
        }

        public static bool VerificaIdade(int ANO)
        {
            if (DateTime.Now.Year - ANO < 18) return false;
            return true;
        }
    }

    public class Foto
    {
        public static void InserirImagem()
        {
        }
    }
}
