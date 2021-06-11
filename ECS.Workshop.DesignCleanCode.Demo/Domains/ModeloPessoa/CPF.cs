using System;

namespace ECS.Workshop.DesignCleanCode.Demo.Domains.ModeloPessoa
{
    public sealed class CPF
    {
        public static CPF PorLong(long valor)
        {
            var number = valor.ToString().PadLeft(DefaultSize, '0');
            return new CPF(number);
        }

        private static string Normalize(string value)
        {
            return value.Replace(".", "").Replace("-", "");
        }

        public static CPF ApartirString(string valor)
        {
            return new CPF(valor);
        }

        private const int DefaultSize = 11;

        public string Value { get; private set; }


        public CPF(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentNullException(nameof(valor));
            }
            if (!IsValid(valor))
            {
                throw new ArgumentException($"Cpf invalido [{valor}]");
            }
            Value = Normalize(valor);
        }

        private static bool IsValid(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = Normalize(cpf.Trim());
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            var result = cpf.EndsWith(digito);
            return result;
        }

    }
}
