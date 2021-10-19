using System;

namespace Exercicio_C_A
{
    public class Imc
    {
        public float imc;
        public string classificacao;
       public float imcC(float A, float P)
        {          
            imc = (P / (A *A));

            if (imc < 18.5)
            {
                this.classificacao = "Peso abaixo do normal";
            }
            else if ((imc > 18.5) && (imc < 25))
            {
                this.classificacao = "Peso normal";
            }
            else  if ((imc > 25) && (imc < 30))
            {
                Console.WriteLine("Sobre o Peso");
                this.classificacao = "Sobre o peso";
            }
            else if ((imc > 30) && (imc < 35))
            {
                this.classificacao = "Grau de Obesidade I";
            }
            else if ((imc > 35) && (imc < 40))
            {
                this.classificacao = "Grau de Obesidade II";
            }
            else  if (imc > 40)
            {
                this.classificacao = "Grau de Obesidade III";
            }
            
            return imc;
            
        
        }

    }
}