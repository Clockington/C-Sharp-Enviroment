using System;
using System.Threading;
using System.IO;
using System.Linq;

namespace ckd_11_generator
{
    class Program
    {
        class ckd11Generator
        {
            
        }
        

        static void Main(string[] args)
        {
            string serialPreffix,serialSuffix,serialResult;
            int serialStart,serialQuantity,digitCheck,prefixAdded;
            char addPrefix;

            Console.Write("Ingrese primer serial: ");
            serialStart = int.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad de seriales a generar: ");
            serialQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el prefijo");
            serialPreffix = Console.ReadLine();
            Console.WriteLine("Ingrese un sufijo");
            serialSuffix = Console.ReadLine();
            Console.Write("Desea agregar el prefijo al calculo? (Y/N)");
            try
            {
                Console.ReadKey(addPrefix);
                if (addPrefix='Y')
                {
                    prefixAdded=1;   
                }
                if (addPrefix='N');
                {
                    prefixAdded=2;
                }
                return prefixAdded;
            }
            catch
            {
                switch (prefixAdded)
                {
                    case 1:
                    break;
                    case 2:
                    break;
                    default:
                    throw(SystemException.InvalidInput);
                    break;
                }
                
            }
            


            ckd11Generator ckd_11_generator = new cdk11generator(serialPreffix,serialSuffix,serialResult,serialStart,serialQuantity,digitCheck);


        }

    }
}