using System;

namespace Conceitos_Throw_Get_Set_Static
{
    class Program
    {
        static Empregado empregado = new Empregado("Pedro", "Silva", 5000);
        static void Main(string[] args)
        {
            empregado.SalarioEmpregado();
            SalarioAtualizado();
            empregado.SalarioAtualizado();
        }
        static void SalarioAtualizado()
        {
            empregado.Salario = empregado.Salario * 1.10;
        }
    }
}
