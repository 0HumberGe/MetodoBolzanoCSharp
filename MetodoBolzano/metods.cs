using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoBolzano
{
    class metods
    {
        public float x2, x1, x;
        public metods() { }

        //Obtención de datos
        public void obtencionDatos()
        {
            //  Coeficientes de la función
            Console.WriteLine("Escribe el coeficiente de x^2: ");
            x2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Escribe el coeficiente de x: ");
            x1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Escribe el coeficiente independiente: ");
            x = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("La función es: {0}x^2+{1}x+{2}", x2, x1, x);
        }

        //Obtener Error Deseado
        public float obtencionError()
        {
            Boolean bandera;
            float err;
            Console.WriteLine("Ingrese el valor del error deseado en el rango de 0% - 100%: ");
            do
            {
                err = Convert.ToSingle(Console.ReadLine());
                if (err < 100 || err > 0)
                {
                    bandera = false;
                }
                else
                {
                    Console.WriteLine("El valor del error deseado no está dentro del rango, ingrese el valor del error deseado de nuevo: ");
                    bandera = true;
                }
            } while (bandera);
            return err;
        }

        //Verificar los valores iniciales
        public Boolean inicVal(float x1, float x2)
        {
            if (((this.x2 * Math.Pow(x1, 2)) + this.x1 * x1 + this.x) * ((this.x2 * Math.Pow(x2, 2)) + this.x1 * x2 + this.x) < 0)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Los valores iniciales no son correctas, verifiquelos, porfavor.\n");
                return true;
            }
        }

        //  Punto Medio
        public float midPoint(float x1, float x2)
        {

            return (x1 + x2) / 2;
        }

        //  Determinar el caso
        public int evRaices(float x1, float xr)
        {
            float _valorProducto = ((this.x2 * Convert.ToSingle(Math.Pow(x1, 2))) + this.x1 * x1 + this.x) * ((this.x2 * Convert.ToSingle(Math.Pow(xr, 2))) + this.x1 * xr + this.x);
            if (_valorProducto < 0)
            {
                return 1;
            }
            else if (_valorProducto > 0)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public float errorAproximado(float vaAct, float vaPrev)
        {
            return Math.Abs((vaAct - vaPrev) / vaAct) * 100;
        }

    }
}
