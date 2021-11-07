using System;

namespace Exercicio_C_A
{
    
public class Volume
    {
        double raio;
        public double resultado;
        public double raioElevado;
        
        public double volumeE(){
        raioElevado = Math.Pow(raio, 3);
        Console.WriteLine("Digite o valor do raio");                
        raio = Convert.ToDouble(Console.ReadLine()); 
        resultado=(4 * Math.PI * raioElevado)/3;
        return resultado;
        }    
    }
}