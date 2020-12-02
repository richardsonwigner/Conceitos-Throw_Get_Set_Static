using System;
using System.Collections.Generic;
using System.Text;

namespace Conceitos_Throw_Get_Set_Static
{
    class Empregado
    {
        string primeiro_nome;
        string sobrenome;
        double salario;
        static Exception ExceptionSalario = new Exception("Salario não pode ser negativo");
        public Empregado(string primeiro_nome, string sobrenome, double salario)
        {
            this.primeiro_nome = primeiro_nome;
            this.sobrenome = sobrenome;
            this.salario = salario;
            if(salario < 0)
            {
                throw ExceptionSalario;   
            }
        }
        public void SalarioEmpregado()
        {
            Console.WriteLine($"Salario atual:{salario}");
        }     
        public void SalarioAtualizado()
        {
            Console.WriteLine($"Salario Com aumento:{salario}");
        }

        public string PrimeiroNome 
        {
            get { return primeiro_nome; }
            set { primeiro_nome = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }


    }
}
