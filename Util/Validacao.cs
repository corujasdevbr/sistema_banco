using System;

namespace Util
{
    public class Validacao
    {
        /// <summary>
        /// Validação de cpf
        /// </summary>
        /// <param name="cpf">Parametro do tipo string recebe o cpf</param>
        /// <returns>Retorna true ou false</returns>
        public bool ValidarCPF(string cpf){
            //Retira os pontos e traços
            cpf = cpf.Trim().Replace(".", "").Replace("-","");

            //Verifica se tem 11 digitos o parametro passado, caso não tenha retorna falso
            if (cpf.Length != 11){
                return false;
            }

            //Verifica se o cpf digitado não possui a sequência de números informada
            if(cpf == "00000000000" || cpf == "11111111111" || cpf == "22222222222"
             || cpf == "33333333333" || cpf == "44444444444" || cpf == "55555555555"
             || cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999"){
                 return false;
             }

            //cria um array de int para validar o primeiro digito
            int[] multiplicador1 = new int[9]{10,9,8,7,6,5,4,3,2};
            //cria um array de int para validar o segundo digito
            int[] multiplicador2 = new int[10]{11,10,9,8,7,6,5,4,3,2};


             string tempCpf, digito;
             int soma =0,resto =0;

            //armazena na váriavel tempCpf os 9 primeiros digitos do cpf passado como parametro
             tempCpf = cpf.Substring(0,9);

            //percorre o array multiplicando os digitos do cpf com a posição do array e soma
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt16(tempCpf[i].ToString())  * multiplicador1[i];
            }

            //armazena o resto da divisão da soma por 11
            resto = soma % 11;

            //Caso o resto seja menor que 2 atribui 0, caso contrário atribui 11 - resto para obter primeiro número
            if(resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            //atribui a digito o resto
            digito = resto.ToString();
            //concatena o tempCpf com o digito
            tempCpf = tempCpf + digito;

            soma = 0;
            //Percorre o tempcpf contatenado e multiplica pelos valores do array
            for (int i = 0; i < 10; i++)
            {
                soma += Convert.ToInt16(tempCpf[i].ToString())  * multiplicador2[i];
            }

            //armazena o resto da divisão da soma por 11
            resto = soma % 11;

            //concatena o tempCpf com o digito
            if(resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito  =digito + resto.ToString();

            //Verifica se os ultimos 2 digitos obtidos são iguais aos do cpf passado
            return cpf.EndsWith(digito);
        }

        /// <summary>
        /// Validação de CNPJ
        /// </summary>
        /// <param name="cnpj">Recebe como parametro de entrada um string com o valor do cnpj a ser validado</param>
        /// <returns>Retorna true ou false</returns>
        public bool ValidarCNPJ(string cnpj){

            //Retira os caracteres especiais do CNPJ
            cnpj = cnpj.Trim().Replace(".", "").Replace("-","");

            //Verifica se o CNPJ possui 14 caracteres
            if (cnpj.Length != 14){
                return false;
            }

            //Declara um array com valores a serem multiplicados para encontrar o primeiro caractere
            int[] multiplicador1 = new int[12]{5,4,3,2,9,8,7,6,5,4,3,2};
            //Declara um array com valores a serem multiplicados para encontrar o segundo caractere
            int[] multiplicador2 = new int[13]{6,5,4,3,2,9,8,7,6,5,4,3,2};


            string tempCnpj, digito;
            int soma =0,resto =0;

            //Atribui a variavel os 12 primeiros caracteres do cnpj
            tempCnpj = cnpj.Substring(0,12);

            //Percorre os 12 caracteres e otem a soma
            for (int i = 0; i < 12; i++)
             {
                 //multiplica o valor do array na poição i ao caracter na posição i
                 soma += Convert.ToInt16(tempCnpj[i].ToString())  * multiplicador1[i];
             }

            //obtêm o resto da divisão da soma por 11
            resto = soma % 11;

            //Caso o resto seja menor que 2 atribui 0 e caso seja maior atribui ao valor 11 - resto
            if(resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            //Atribui o valor do resto a variável digito
            digito = resto.ToString();
            //Concatena o cnpj com 12 caracteres ao resto para validar o segundo dígito
            tempCnpj = tempCnpj + digito;

            soma = 0;
            //Percorre os 13 caracteres e otem a soma
            for (int i = 0; i < 13; i++)
            {
                 //multiplica o valor do array na poição i ao caracter na posição i
                 soma += Convert.ToInt16(tempCnpj[i].ToString())  * multiplicador2[i];
            }

            //Caso o resto seja menor que 2 atribui 0 e caso seja maior atribui ao valor 11 - resto
            resto = soma % 11;

            //Caso o resto seja menor que 2 atribui 0 e caso seja maior atribui ao valor 11 - resto
            if(resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            //Atribui o valor do resto a variável digito
            digito = resto.ToString();

            //Verifica se o digito é igual aos do cnpj, caso seja retorna true caso contrário retorna false
            return cnpj.EndsWith(digito);
        }
    }
}