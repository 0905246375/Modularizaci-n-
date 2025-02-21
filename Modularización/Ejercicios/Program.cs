using System;
using System.Collections.Generic;

namespace Ejercicios
{
    class Program
    {
        // Campo estático para el contador
        static int contadorValor = 0;
        //Menu Inicial 
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Menú para ingresar a cada ejercicio:");
                Console.WriteLine("1. Calculadora básica");
                Console.WriteLine("2. Validación de contraseña");
                Console.WriteLine("3. Números primos");
                Console.WriteLine("4. Verificar si un número es primo");
                Console.WriteLine("5. Suma de números pares");
                Console.WriteLine("6. Mostrar números pares ingresados");
                Console.WriteLine("7. Conversión de temperatura");
                Console.WriteLine("8. Contar vocales");
                Console.WriteLine("9. Juego de adivinanzas");
                Console.WriteLine("10. Paso por referencia");
                Console.WriteLine("11. Tabla de multiplicar");
                Console.WriteLine("12. Contador");
                Console.WriteLine("13. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Has seleccionado calculadora básica");
                        CalculadoraBasica();
                        break;
                    case "2":
                        Console.WriteLine("Has seleccionado Validación de contraseña");
                        ValidarContrasena();
                        break;
                    case "3":
                        Console.WriteLine("Has seleccionado Números primos");
                        NumerosPrimos();
                        break;
                    case "4":
                        Console.WriteLine("Has seleccionado Verificar si un número es primo");
                        VerificarNumeroPrimo();
                        break;
                    case "5":
                        Console.WriteLine("Has seleccionado Suma de números pares");
                        SumaNumerosPares();
                        break;
                    case "6":
                        Console.WriteLine("Has seleccionado Mostrar números pares ingresados");
                        MostrarNumerosPares();
                        break;
                    case "7":
                        Console.WriteLine("Has seleccionado Conversión de temperatura");
                        ConvertirTemperatura();
                        break;
                    case "8":
                        Console.WriteLine("Has seleccionado Contar vocales");
                        ContarVocales();
                        break;
                    case "9":
                        Console.WriteLine("Has seleccionado Juego de adivinanzas");
                        Adivinanza();
                        break;
                    case "10":
                        Console.WriteLine("Has seleccionado Paso por referencia");
                        PasoPorReferencia();
                        break;
                    case "11":
                        Console.WriteLine("Has seleccionado Tabla de multiplicar");
                        TablaDeMultiplicar();
                        break;
                    case "12":
                        Console.WriteLine("Has seleccionado Contador");
                        Console.WriteLine($"Contador: {Contador()}");
                        break;
                    case "13":
                        Console.WriteLine("Saliendo del programa...");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 13.");
                        break;
                }

                // Agregar una línea en blanco para separar las iteraciones del menú
                Console.WriteLine();
            }
        }

        static int Contador()
        {
            contadorValor++;
            return contadorValor;
        }
        //1- Calculadora basica 
        static void CalculadoraBasica()
        {
            // Mostrar el menú de la calculadora
            Console.WriteLine("Calculadora básica:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Seleccione una operación: ");
            string operacion = Console.ReadLine();

            // Solicitar los dos números al usuario
            double numero1, numero2;
            Console.Write("Ingrese el primer número: ");
            while (!double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
                Console.Write("Ingrese el primer número: ");
            }

            Console.Write("Ingrese el segundo número: ");
            while (!double.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
                Console.Write("Ingrese el segundo número: ");
            }

            // Realizar la operación correspondiente
            double resultado = 0;
            switch (operacion)
            {
                case "1":
                    resultado = numero1 + numero2;
                    Console.WriteLine($"Resultado de la suma: {resultado}");
                    break;
                case "2":
                    resultado = numero1 - numero2;
                    Console.WriteLine($"Resultado de la resta: {resultado}");
                    break;
                case "3":
                    resultado = numero1 * numero2;
                    Console.WriteLine($"Resultado de la multiplicación: {resultado}");
                    break;
                case "4":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"Resultado de la división: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero no es permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida. Por favor, seleccione una operación del 1 al 4.");
                    break;
            }
        }
        //2- Validacion de Contrasena 
        static void ValidarContrasena()
        {
            const string contrasenaCorrecta = "1234";
            string contrasenaIngresada;
            do
            {
                Console.Write("Ingrese la contraseña: ");
                contrasenaIngresada = Console.ReadLine();

                if (contrasenaIngresada != contrasenaCorrecta)
                {
                    Console.WriteLine("Contraseña incorrecta. Inténtelo de nuevo.");
                }
            }
            while (contrasenaIngresada != contrasenaCorrecta);

            Console.WriteLine("Acceso concedido. Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
        }
        //3- Numeros Primos 
        static void NumerosPrimos()
        {
            Console.Write("Ingrese un número para encontrar todos los números primos hasta ese número: ");
            int limite;
            while (!int.TryParse(Console.ReadLine(), out limite) || limite < 2)
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero mayor o igual a 2.");
                Console.Write("Ingrese un número para encontrar todos los números primos hasta ese número: ");
            }

            Console.WriteLine($"Números primos hasta {limite}:");
            for (int i = 2; i <= limite; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        //4- Verificacion de numeros primos 
        static void VerificarNumeroPrimo()
        {
            Console.Write("Ingrese un número para verificar si es primo: ");
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 2)
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero mayor o igual a 2.");
                Console.Write("Ingrese un número para verificar si es primo: ");
            }

            if (EsPrimo(numero))
            {
                Console.WriteLine($"{numero} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número primo.");
            }

            Console.WriteLine("Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
        }
        //5-Suma de numeros Pares
        static void SumaNumerosPares()
        {
            Console.Write("Ingrese un número para calcular la suma de todos los números pares hasta ese número: ");
            int limite;
            while (!int.TryParse(Console.ReadLine(), out limite) || limite < 0)
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero mayor o igual a 0.");
                Console.Write("Ingrese un número para calcular la suma de todos los números pares hasta ese número: ");
            }

            int suma = 0;
            for (int i = 0; i <= limite; i += 2)
            {
                suma += i;
            }

            Console.WriteLine($"La suma de todos los números pares hasta {limite} es: {suma}");
            Console.WriteLine("Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
        }
        //6- Mostrar Numeros  Pares 
        static void MostrarNumerosPares()
        {
            List<int> numerosPares = new List<int>();
            int numero;

            do
            {
                Console.Write("Ingrese un número (0 para terminar): ");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                    Console.Write("Ingrese un número (0 para terminar): ");
                }

                if (numero != 0 && numero % 2 == 0)
                {
                    numerosPares.Add(numero);
                }

            } while (numero != 0);

            Console.WriteLine("Números pares ingresados:");
            foreach (var num in numerosPares)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
        }
        //7- Convertir Temperatura 
        static void ConvertirTemperatura()
        {
            Console.WriteLine("Conversión de Temperatura: Celsius a Fahrenheit");
            Console.Write("Ingrese la temperatura en grados Celsius: ");
            double celsius;
            while (!double.TryParse(Console.ReadLine(), out celsius))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
                Console.Write("Ingrese la temperatura en grados Celsius: ");
            }

            double fahrenheit = CelsiusAFahrenheit(celsius);
            Console.WriteLine($"{celsius} grados Celsius es equivalente a {fahrenheit} grados Fahrenheit.");
            Console.WriteLine("Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
        }

        static double CelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        //8- Contar Vocales 
        static void ContarVocales()
        {
            Console.Write("Ingrese una cadena de texto: ");
            string texto = Console.ReadLine();
            int contador = 0;

            foreach (char c in texto)
            {
                if ("aeiouAEIOU".IndexOf(c) >= 0)
                {
                    contador++;
                }
            }

            Console.WriteLine($"La cadena ingresada contiene {contador} vocales.");
            Console.WriteLine("Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
        }
        //9- Juego de Adivinanzas 
        static void Adivinanza()
        {
            int numeroAleatorio = new Random().Next(1, 101);
            int intentos = 0;

            while (true)
            {
                Console.WriteLine("Adivina el número entre 1 y 100:");
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                }

                intentos++;

                if (numero > numeroAleatorio)
                {
                    Console.WriteLine("Demasiado alto");
                }
                else if (numero < numeroAleatorio)
                {
                    Console.WriteLine("Demasiado bajo");
                }
                else
                {
                    Console.WriteLine($"¡Felicidades, adivinaste el número en {intentos} intentos!");
                    Console.WriteLine("Presione cualquier tecla para volver al menú principal.");
                    Console.ReadKey();
                    break;
                }
            }
        }
        //10- Paso Por Referencia 
        static void PasoPorReferencia()
        {
            int valor = 10;
            Console.WriteLine($"Valor antes de modificar: {valor}");
            ModificarValor(ref valor);
            Console.WriteLine($"Valor después de modificar: {valor}");
            Console.WriteLine("Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
        }

        static void ModificarValor(ref int numero)
        {
            numero += 10;
        }
        //11- Tabla de Multiplicar 
        static void TablaDeMultiplicar()
        {
            Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
            }

            Console.WriteLine($"Tabla de multiplicar del {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

            Console.WriteLine("Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
        }
        static bool EsPrimo(int numero)
        {
        if (numero < 2) return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
         if (numero % i == 0) return false;
        }
         return true;
            }
        }
    }

