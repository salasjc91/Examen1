namespace Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // se solicita al usuario que ingrese un numero del 1 al 9:

            Console.WriteLine("Ingrese un número del 1 al 9:");
            int numero = Convert.ToInt32(Console.ReadLine());

            // en esta funcion se hace la conversion de numero a letras, utilizando la clase NumeroAletra.


            NumeroALetra numeroALetra = new NumeroALetra();
            string valorEnLetras = numeroALetra.Convertir(numero);


            /*Utilice  el ciclo IF para verificar los datos ingresados por los usuarios
             * en la funcion de Obtener Valores en letras para ver si estan dentro o fuera del rango 
             */

            if (valorEnLetras != "")
            {
                //Muestra el numero seleccionado al igual en la manera que se escribe.

                Console.WriteLine($"El número que seleccionaste es: {numero} = {valorEnLetras}");
            }
            else
            {
                // Este mensaje indica que selecciono un numero fuera del rango.

                Console.WriteLine("El número ingresado está fuera del rango permitido.");
            }
        }
    }
}

        
       