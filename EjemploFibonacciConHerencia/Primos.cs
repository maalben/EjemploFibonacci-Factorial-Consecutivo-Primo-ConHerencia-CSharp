using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploFibonacciConHerencia
{
    public class Primos : Valor
    {

        public bool identificarPrimo() {
            long numero;
            int contador;
            int divisible;
            numero = this.getNumero();
            
            //Especificar que se inicia en 1 la división
            divisible = 1;

            //Las veces en que el número es divisible
            contador = 0;

            while (divisible <= numero) {
                if ((numero % divisible) == 0 ) {
                    contador++;
                }
                divisible++;
            }
            if (contador == 2) {
                return true;
            }else {
                return false;
            }
        }

    }
}
