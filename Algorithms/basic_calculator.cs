using System;

namespace basic_calculator
{
    class Program
    {
        public class CalcuBasica
        {
            // Declaracion de variables
            private Double operA;
            private Double operB;
            private Double resultAB;

            // Constructores
            public void InitiateBasica(Double operA, Double operB, Double resultAB)
            {
                this.operA = operA;
                this.operB = operB;
                this.resultAB = resultAB;
            }

            // Operaciones Básicas
            private Double Suma()
            {
                resultAB = operA + operB;
                Math.Round(resultAB, 4); // Redondea puntos decimales a 4 posiciones
                return resultAB;
            }
            private Double Resta()
            {
                resultAB = operA - operB;
                Math.Round(resultAB, 4);
                return resultAB;
            }
            private Double Multiplicacion()
            {
                resultAB = operA * operB;
                Math.Round(resultAB, 4);
                return resultAB;
            }
            private Double Division()
            {
                try { resultAB = operA / operB; } // El programa intentará ejecutar la operacion aritmetica
                catch (System.DivideByZeroException e) // Si no hay resultado entonces mostrará el símbolo de Infinito
                { Console.WriteLine(e); }
                return resultAB; // Caso contrario entonces mostrara el resultado correspondiente

            }
            public String Resultados()
            {
                return "Los resultados de las operaciones son los siguientes:" +
                    "\nSuma: " + Suma() +
                    "\nResta: " + Resta() +
                    "\nMultiplicacion: " + Multiplicacion() +
                    "\nDivision: " + Division();
            }
        }
        public class CalcuTrigono
        {
            private readonly double operC;
            private readonly int funciont;

            public CalcuTrigono(double operC, int funciont)
            {
                this.operC = operC;
                this.funciont = funciont;
            }
            public String ResultTrigono()
            {
                switch (funciont)
                {
                    case 1:
                        return ">" + Math.Sin(operC);
                    case 2:
                        return ">" + Math.Cos(operC);
                    case 3:
                        return ">" + Math.Tan(operC);
                    case 4:
                        return ">" + (1 / Math.Sin(operC));
                    case 5:
                        return ">" + (1 / Math.Cos(operC));
                    case 6:
                        return ">" + (Math.Cos(operC) / Math.Sin(operC));
                    default:
                        throw new InvalidOperationException("Operación Invalida.");
                }
            }
        }
        public class ConverMoneda
        {
            private readonly double operD;
            private readonly int conver;

            public ConverMoneda(double operD, int conver)
            {
                this.operD = operD;
                this.conver = conver;
            }

            public string ResultMoneda()
            {
                switch (conver)
                {
                    case 1:
                        return "\n>$ " + Math.Round((operD * 0.0486), 2) + "\n\nhttps://www.xe.com/currencytables/ (2021-10-29)";
                    case 2:
                        return "\n>$ " + Math.Round((operD * 0.0421), 2) + "\n\nhttps://www.xe.com/currencytables/ (2021-10-29)";
                    case 3:
                        return "\n>$ " + Math.Round((operD * 20.5458), 2) + "\n\nhttps://www.xe.com/currencytables/ (2021-10-29)";
                    case 4:
                        return "\n>$ " + Math.Round((operD * 0.8656), 2) + "\n\nhttps://www.xe.com/currencytables/ (2021-10-29)";
                    case 5:
                        return "\n>$ " + Math.Round((operD * 23.7350), 2) + "\n\nhttps://www.xe.com/currencytables/ (2021-10-29)";
                    case 6:
                        return "\n>$ " + Math.Round((operD * 1.1552), 2) + "\n\nhttps://www.xe.com/currencytables/ (2021-10-29)";
                    default:
                        throw new InvalidOperationException("Error al convertir.");
                }
            }
        }
        public class ConverTemperatura
        {
            private readonly double operE;
            private readonly int unidadT;
            public ConverTemperatura(double operE, int unidadT)
            {
                this.operE = operE;
                this.unidadT = unidadT;
            }
            public string ResultTemperatura()
            {
                switch (unidadT)
                {
                    case 1://C -> F
                        return "\n>" + Math.Round(((operE * 1.8) + 32), 3);
                    case 2://C -> K
                        return "\n>" + Math.Round((operE + 273.15), 3);
                    case 3://F -> C
                        return "\n>" + Math.Round(((operE - 32) / 1.8), 3);
                    case 4://F -> K
                        return "\n>" + Math.Round(((5 * (operE - 32)) / 9) + 273.15, 3);
                    case 5://K -> C
                        return "\n>" + Math.Round((operE - 273.15), 3);
                    case 6://K -> F
                        return "\n>" + Math.Round((((9 * (operE - 273.15)) / 5) + 32), 3);
                    default:
                        throw new InvalidOperationException("Error al convertir.");
                }
            }
        }
        public class ConverLongitud
        {
            private readonly double operF;
            private readonly int unidadM;
            public ConverLongitud(double operF, int unidadM)
            {
                this.operF = operF;
                this.unidadM = unidadM;
            }
            public string ResultLongitud()
            {
                switch (unidadM)
                {
                    case 1://cm a in
                        return "\n>" + Math.Round(operF / 2.54, 4);
                    case 2://mt a ft
                        return "\n>" + Math.Round(operF * 3.28084, 4);
                    case 3://mt a yd
                        return "\n>" + Math.Round(operF * 1.093613, 4);
                    case 4://km a mi
                        return "\n>" + Math.Round(operF / 0.621371, 4);
                    case 5://in a cm
                        return "\n>" + Math.Round(operF * 2.54, 4);
                    case 6://ft a mt
                        return "\n>" + Math.Round(operF * 0.3048, 4);
                    case 7://yd a mt
                        return "\n>" + Math.Round(operF * 0.9144, 4);
                    case 8://mi a km
                        return "\n>" + Math.Round(operF * 1.609344, 4);
                    default:
                        throw new InvalidOperationException("Error al convertir.");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hola y bienvenido a CeeCalc. La calculadora desarrollada en C#.");
            do
            {
                //Menu
                int seleccion;
                Console.WriteLine("\nIndica el modo a utilizar:" +
                    "\n1. Básica." +
                    "\n2. Trigonometrica." +
                    "\n3. Conversión de Moneda." +
                    "\n4. Conversión de Temperatura." +
                    "\n5. Conversión de Longitud." +
                    "\n6. Salir.");
                seleccion = int.Parse(Console.ReadLine());
                switch (seleccion)
                {
                    case 1://Basica
                        {   // Inicializa clase Base
                            CalcuBasica calcubasica;
                            calcubasica = new CalcuBasica();

                            // Declaracion de Variables
                            double operA;
                            double operB;
                            double resultAB = 0; // resultAB tiene que ser 0 ya que el usuario no ingresa su valor.

                            Console.WriteLine("Modo Básico habilitado...");
                            Console.WriteLine("Indique el primer operador:");
                            operA = double.Parse(Console.ReadLine());
                            Console.WriteLine("Indique el segundo operador:");
                            operB = double.Parse(Console.ReadLine());

                            // Inicializa las variables
                            calcubasica.InitiateBasica(operA, operB, resultAB);

                            // Imprime el return de Resultados()
                            Console.WriteLine(calcubasica.Resultados());
                            break;
                        }
                    case 2://Trigonometrica
                        {
                            double operC;
                            int funciont;

                            Console.WriteLine("Modo Trigonométrico habilitado...");
                            Console.WriteLine("\nIndique con un numero la funcion a usar:" +
                                "\n\t1. Seno" +
                                "\n\t2. Coseno" +
                                "\n\t3. Tangente" +
                                "\n\t4. Cosecante" +
                                "\n\t5. Secante" +
                                "\n\t6. Cotangente");
                            funciont = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nIngrese el valor a evaluar en radianes:");
                            operC = double.Parse(Console.ReadLine());

                            CalcuTrigono calcutrigono = new CalcuTrigono(operC, funciont);
                            Console.WriteLine(calcutrigono.ResultTrigono());

                            break;
                        }
                    case 3://Moneda
                        {
                            double operD;
                            int conver;

                            Console.WriteLine("\nConversión de Moneda habilitado...");
                            Console.WriteLine("\nIndique el valor a convertir:");
                            operD = double.Parse(Console.ReadLine());

                            Console.WriteLine("Indique el tipo de conversión." +
                                "\n\t1. MXN a USD" +
                                "\n\t2. MXN a EUR" +
                                "\n\t3. USD a MXN" +
                                "\n\t4. USD a EUR" +
                                "\n\t5. EUR a MXN" +
                                "\n\t6. EUR a USD");
                            conver = int.Parse(Console.ReadLine());

                            ConverMoneda convermoneda = new ConverMoneda(operD, conver);
                            Console.WriteLine(convermoneda.ResultMoneda());

                            break;
                        }
                    case 4://Temperatura
                        {
                            double operE;
                            int unidadT;

                            Console.WriteLine("Conversión de Temperatura habilitado...");
                            Console.WriteLine("\nIndique el valor a convertir:");
                            operE = double.Parse(Console.ReadLine());

                            Console.WriteLine("Indique el tipo de conversión:" +
                                "\n\t1. Centigrados a Farenheit." +
                                "\n\t2. Centigrados a Kelvin." +
                                "\n\t3. Farenheit a Centigrados." +
                                "\n\t4. Farenheit a Kelvin." +
                                "\n\t5. Kelvin a Centigrados." +
                                "\n\t6. Kelvin a Farenheit.");
                            unidadT = int.Parse(Console.ReadLine());

                            ConverTemperatura convertemperatura = new ConverTemperatura(operE, unidadT);
                            Console.WriteLine(convertemperatura.ResultTemperatura());

                            break;
                        }
                    case 5://Longitud
                        {
                            double operF;
                            int unidadM;

                            Console.WriteLine("\nConversión de Unidad de Medida habilitado...");
                            Console.WriteLine("\nIndique el valor a convertir:");
                            operF = double.Parse(Console.ReadLine());

                            Console.WriteLine("Indique la Unidad de Medida a convertir:" +
                                "\n\t1. Centimetro a Pulgada." +
                                "\n\t2. Metros a Pie." +
                                "\n\t3. Metros a Yarda." +
                                "\n\t4. Kilometros a Milla." +
                                "\n\t5. Pulgada a Centimetro." +
                                "\n\t6. Pie a Metros." +
                                "\n\t7. Yarda a Metros." +
                                "\n\t8. Milla a Kilometro.");
                            unidadM = int.Parse(Console.ReadLine());

                            ConverLongitud converlongitud = new ConverLongitud(operF, unidadM);
                            Console.WriteLine(converlongitud.ResultLongitud());

                            break;
                        }
                    case 6:
                        Console.Clear();
                        Environment.Exit(1);
                        return;
                    default:
                        throw new InvalidOperationException("Opción Inválida.");
                }
            } while (true);
        }
    }
}