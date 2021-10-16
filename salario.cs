namespace Exercicio_C_A
{
    public class Salario
    {
        public double qtsalarios;

        public double salarioM(double funcionario, double minimo)
        {           
            qtsalarios = funcionario/minimo;
            return qtsalarios;
        }

    public double getQtsalarios(){
        return this.qtsalarios;
    }

    }
}