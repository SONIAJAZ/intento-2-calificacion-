using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ordenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            float firmas_m = Text("ingrese el maximo de firmas");
            float firmas_o = Text("ingrese las firmas obtenidas");
            if (Rule3(100, firmas_m, firmas_o) >= 80)
            {
                float examen = Text("ingrese el porcentaje obtenido de examen");
                Per40(examen);
            }
            float portafolio = Text("ingrese el porcentaje obtenido de portafolio");
            Per40(portafolio);

            float ser1 = Rule3(5, 40, Text("ingrese el valor del ser"));
            calf += ser1;
            float ser2 = Rule3(5, 80, Text("ingrese el valor del Adp."));
            calf += ser2;

            Console.WriteLine("La calificación es: " + calf);
        }

        public static void Per40(float perExamen)
        {
            float ex = Rule3(40, 100, perExamen);
            float ex10 = Rule3(10, 100, perExamen);
            Console.WriteLine("la escala es:" + ex + " y el valor obtenido es: " + ex10);
            calf += ex;
        }
        public static float ser(float pts, float ptso)
        {
            return Rule3(5, pts, ptso);
        }
        public static float Rule3(float per, float valor1, float valor2)
        {
            return (per / valor1) * valor2;
        }
    }
}


