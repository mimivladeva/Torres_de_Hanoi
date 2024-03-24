﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Torres_de_Hanoi
    {
        class Program 
        {
            static void Main(string[] args)
            {
                bool run = false; // Variable para controlar la ejecución del programa

                // Bienvenida al usuario
                Console.WriteLine("¡Bienvenido a las Torres de Hanoi!");
                Console.WriteLine("Por favor, elija el modo de juego pulsando : 1. Modo iterativo , 2. Modo recursivo");

                // Bucle principal del programa
                do
                {
                    String modoString = Console.ReadLine();
                    if (Int32.TryParse(modoString, out int modo)) //Si la conversión tiene éxito, el valor convertido se almacena en la variable modo
                {
                        switch (modo)
                        {
                            case 1: // Modo iterativo
                                Console.WriteLine("Modo iterativo seleccionado.");
                                Console.WriteLine("Por favor, indique el número de piezas (discos) para el rompecabezas.");
                                Console.WriteLine("El programa calculará el número mínimo de movimientos para resolver el rompecabezas.");
                                // Bucle para ingresar el número de piezas
                                do
                                {
                                    String piezasString = Console.ReadLine();
                                    if (Int32.TryParse(piezasString, out int piezas))
                                    {
                                        if (piezas <= 0)
                                        {
                                            Console.WriteLine("No se admiten números menores que 0.");
                                        }
                                        else
                                        {
                                            // Crear las pilas y resolver el puzle
                                            Pila ini = new Pila(piezas);
                                            Pila aux = new Pila();
                                            Pila fin = new Pila();
                                            int movimientos = new Hanoi().iterativo(piezas, ini, fin, aux);
                                            Console.WriteLine("Con " + piezas + " piezas se han necesitado " + movimientos + " movimientos para resolver el puzle");
                                            run = true; // Establecer run como verdadero para salir del bucle
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se admiten palabras, introduzca de manera numérica el número de piezas que quiere.");
                                    }
                                } while (!run);

                                break;
                            case 2: // Modo recursivo
                                Console.WriteLine("Modo recursivo seleccionado.");
                                Console.WriteLine("Por favor, indique el número de piezas (discos) para el rompecabezas.");
                                Console.WriteLine("El programa calculará el número mínimo de movimientos para resolver el rompecabezas.");
                                // Bucle para ingresar el número de piezas
                                do
                                {
                                    String piezasString = Console.ReadLine();
                                    if (Int32.TryParse(piezasString, out int piezas))
                                    {
                                        if (piezas <= 0)
                                        {
                                            Console.WriteLine("No se admiten números menores que 0.");
                                        }
                                        else
                                        {
                                            // Crear las pilas y resolver el puzle
                                            Pila ini = new Pila(piezas);
                                            Pila aux = new Pila();
                                            Pila fin = new Pila();
                                            int movimientos = new Hanoi().recursivo(piezas, ini, fin, aux);
                                            Console.WriteLine("Con " + piezas + " piezas se han necesitado " + movimientos + " movimientos para resolver el puzle");
                                            run = true; // Establecer run como verdadero para salir del bucle
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se admiten palabras, introduzca de manera numérica el número de piezas que quiere.");
                                    }
                                } while (!run);
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Presione 1 para modo iterativo o  2 para modo recursivo");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se admiten palabras, pulse 1 si quiere usar el modo iterativo o el 2 si quiere usar el modo recursivo.");
                    }

                    // Preguntar al usuario si desea volver a ejecutar el programa
                    if (run)
                    {
                        Console.WriteLine("¿Desea intentarlo nuevamente? Presione 1 para continuar o 0 para salir.");
                        int rerun = -1;
                        do
                        {
                            String rerunString = Console.ReadLine();
                            if (Int32.TryParse(rerunString, out int x))
                            {
                                rerun = x;
                                switch (rerun)
                                {
                                    case 0:
                                        Console.WriteLine("Hasta luego");
                                        Console.ReadLine();
                                        break;
                                    case 1:
                                        Console.WriteLine("Excelente. Presione 1 para seleccionar el modo iterativo o 2 para el modo recursivo.");
                                        run = false; // Establecer run como falso para volver a ejecutar el programa
                                        break;
                                    default:
                                        Console.WriteLine("Opción no válida. Presione 1 para continuar o 0 para salir.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("No se admiten palabras, introduzca de manera numérica lo que quiere hacer a continuación.");
                            }
                        } while (rerun != 1 && rerun != 0);
                    }
                } while (!run);
            }
        }
    }

