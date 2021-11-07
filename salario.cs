using System;

namespace Exercicio_C_A
{
    public class Salario
    {
        public double qtsalarios;
        double funcionario;
        double minimo;
        

        public double salarioM()
        {           
            Console.WriteLine("Digite o salário do funcionário");
            funcionario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o salário mínimo");
            minimo = Convert.ToDouble(Console.ReadLine());
            qtsalarios = funcionario/minimo;
            return qtsalarios;
        }

    public double getQtsalarios(){
        return this.qtsalarios;
    }

    }
}