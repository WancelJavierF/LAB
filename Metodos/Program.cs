using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     Cual de los siguientes calculos geometricos desea     ");
            Console.ReadLine();
            Console.WriteLine("1) Area del cuadrado. ");
            Console.WriteLine("2) Area del rectangulo. ");
            Console.WriteLine("3) Area del triangulo. ");
            Console.WriteLine("4) Area del circulo. ");
            Console.WriteLine("5) Area del cono. ");
            Console.WriteLine("6) La hipotenusa utilizando el teorema de pitagoras. ");

            string vSalida = Console.ReadLine();
            switch (vSalida)
            {
                case "1":
                    AreaDelCuadrado();

                    break;
                    case "2":
                    AreaDelRectangulo();

                    break;
                case "3":
                    AreadDelTriangulo();

                    break;
                case "4":
                    AreaDelCiruclo();

                    break;
                case "5":
                    AreaDelCono();

                    break;
                case "6":
                    HipotenusaPitagoras();

                    break;
            }

        }

        static int AreaDelCuadrado ()
        {
            int vLado1;
            Console.WriteLine("Favor ingrese un lado del cuadrado: ");
            vLado1 = Convert.ToInt32(Console.ReadLine());

            vLado1 *= vLado1;
            Console.WriteLine("El Area del cuadrado es: "+ vLado1 +"Cm²");
            Console.ReadKey();
            return vLado1;
        }
        static int AreaDelRectangulo ()
        {
            int vLado, vAncho;
            int vResultado;
            Console.WriteLine("Ingrese uno de los lados del rectangulo: ");
            vLado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el ancho del mismo: ");
            vAncho = Convert.ToInt32(Console.ReadLine());

            vResultado = vLado * vAncho;
            Console.WriteLine("El are del rectangulo es: "+vResultado+ "Cm² ");
            Console.ReadKey();
            return vResultado; 
        }
        static double AreadDelTriangulo()
        {

            double vBase, vAltura, vResultado2;
            Console.WriteLine("Favor ingresar la base del triangulo: ");
            vBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Favor ingresar la altura del mismo: ");
            vAltura = Convert.ToDouble(Console.ReadLine());

            vResultado2 = (1 / 2) * vBase * vAltura;
            Console.WriteLine("El area del triangulo es: "+vResultado2+ "Cm²");
            Console.ReadKey();

            return vResultado2;
        
        }
        static double AreaDelCiruclo()
        {
            double vRadio, vResultado;
            double Pi = 3.1415;
            Console.WriteLine("Digite el radio del circulo: ");
            vRadio = Convert.ToDouble(Console.ReadLine());
            vResultado = (Pi * (vRadio * vRadio));
            Console.WriteLine("El area del circulo es: "+vResultado+ "Cm²");
            Console.ReadKey();
            return vResultado;
        }
        static double AreaDelCono()
        {
            double vRadio, vGeneratriz, vResultado;
            double Pi = 3.1415;
            Console.WriteLine("Ingrese el radio del circulo: ");
            vRadio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la generatriz del circulo: ");
            vGeneratriz = Convert.ToDouble(Console.ReadLine());

            vResultado = Pi * vRadio * (vRadio + vGeneratriz);
            Console.WriteLine("El area total del circulo es: "+vResultado+ "Cm²");
            Console.ReadKey();
            return vResultado;

        
        }
        static double HipotenusaPitagoras()
        {
            double vLado1, vLado2, vHipotenusa, vResultado;
            Console.WriteLine("Ingrese uno de los lados del triangulo: ");
            vLado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el lado restante del triangulo: ");
            vLado2 = Convert.ToDouble(Console.ReadLine());

            vHipotenusa = (vLado1 * vLado1) + (vLado2 * vLado2);
            vResultado = Math.Sqrt(vHipotenusa);

            Console.WriteLine("La hipotenusa del triangulo es: "+vResultado);
            Console.ReadKey();
            return vResultado;
        }   


    }
}
