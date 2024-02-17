using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class NumeroALetra
    {
        public string Convertir(int numero)
        {
            /*
             * el switch se encarga de cambiar de numeros a letras
             * 
             */
            switch (numero)
            {
                case 1:
                    return "UNO";
                case 2:
                    return "DOS";
                case 3:
                    return "TRES";
                case 4:
                    return "CUATRO";
                case 5:
                    return "CINCO";
                case 6:
                    return "SEIS";
                case 7:
                    return "SIETE";
                case 8:
                    return "OCHO";
                case 9:
                    return "NUEVE";
                default:
                    return "";
            }
        }
    }
}
