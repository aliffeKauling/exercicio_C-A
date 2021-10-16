using System;

namespace Exercicio_C_A
{
    public class Imc
    {
        public float imc;
       public float imcC(float A, float P)
        {
                    

            imc = (P / (A *A));

            if (imc < 18.5)
            {
                Console.WriteLine("Peso abaixo do normal");
            }
            else if ((imc > 18.5) && (imc < 25))
            {
                Console.WriteLine("Peso normal");
            }
            else  if ((imc > 25) && (imc < 30))
            {
                Console.WriteLine("Sobre o Peso");
            }
            else if ((imc > 30) && (imc < 35))
            {
                Console.WriteLine("Grau de Obesidade I");
            }
            else if ((imc > 35) && (imc < 40))
            {
                Console.WriteLine("Grau de Obesidade II");
            }
            else  if (imc > 40)
            {
                Console.WriteLine("Obesidade Grau III");
            }

            Console.ReadKey();
            
            return imc;
        
        }



    }
}