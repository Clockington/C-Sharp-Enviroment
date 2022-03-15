using System;
using System.Threading;
using System.IO;
using System.Linq;

namespace ckd_11_main
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string serialPreffix,serialSuffix,serialResult;
            int serialStart,serialQuantity,digitCheck;

            Console.WriteLine("Ingrese primer serial: ");
            serialStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de seriales a generar: ");
            serialQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el prefijo");
            serialPreffix = Console.ReadLine();
            Console.WriteLine("Ingrese un sufijo");
            serialSuffix = Console.ReadLine();
            Console.Write("Desea agregar el prefijo al calculo? (Y/N)");
            try
            {
                Console.ReadKey('y'=true);
            }
            catch
            {
                throw(SystemException.InvalidInput);
            }
            


            ckd_11_main ckd_11_gen = new cdk_11_gen(serialPreffix,serialSuffix,serialResult,serialStart,serialQuantity,digitCheck);


        }

    }
}