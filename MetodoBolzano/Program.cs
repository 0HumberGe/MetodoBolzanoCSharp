using System;

namespace MetodoBolzano
{
    class Program
    {
            
        static void Main(string[] args)
        {
            Boolean flag = true;
            int numIt = 0;
            float x1, x2, xr_prev, xr, errorDes, errAprox;
            Console.WriteLine("===> Bienvenido al Método Bolzano Para Funciones Cuadradas <===\n");
            metods met = new metods();
            met.obtencionDatos();
            errorDes = met.obtencionError();
            //Paso 1. Valores Iniciales
            do
            {
            Console.WriteLine("Ingrese el valor inicial x1: ");
            x1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese el valor inicial xv: ");
            x2 = Convert.ToSingle(Console.ReadLine());
            }while(met.inicVal(x1, x2));
            //Paso 2. Aproximación a la Raíz
            xr = met.midPoint(x1,x2);

            //Paso 3. Evaluar y Determinar el Caso
            do
            {
                numIt += 1;
                switch (met.evRaices(x1, x2))
                {
                    case 1:
                        x2 = xr;
                        break;
                    case 2:
                        x1 = xr;
                        break;
                    default:
                        flag = false;
                        break;
                }

                //Paso 4. Nueva Aproximación a la Raiz
                xr_prev = xr;
                xr = met.midPoint(x1, x2);

                //Paso 5. Verificar la Exactitud de la Aproximación
                errAprox = met.errorAproximado(xr, xr_prev);
                if ( errAprox <= errorDes)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("===> Reporte de Iteración #{0} <===", numIt);
                    Console.WriteLine("Porcentaje de error deseado: {0}%\n", errorDes);
                    Console.WriteLine("Valor de la raíz aproximada: {0}\n", xr);
                    Console.WriteLine("Error aproximado: {0}\n", errAprox);
                    Console.WriteLine("Valor Final de x_1: {0}\nValor Final de x_v: {1}\n", x1, x2);
                    Console.ReadLine();
                }
            } while (flag);
            Console.WriteLine("===> Reporte de Finela Iteración #{0} <===", numIt);
            Console.WriteLine("Porcentaje de error deseado: {0}%\n", errorDes);
            Console.WriteLine("Valor de la raíz aproximada: {0}\n", xr);
            Console.WriteLine("Error aproximado: {0}\n", errAprox);
            Console.WriteLine("Valor Final de x_1: {0}\nValor Final de x_v: {1}\n", x1, x2);
            Console.ReadLine();

        }
        
                
    }
}
