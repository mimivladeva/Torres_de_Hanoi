using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Torres_de_Hanoi
    {
        class Hanoi
        {
            
            public int movimientos { get; set; }

            
            public Hanoi()
            {
                movimientos = 0; // cont
            }

          
            public void Mover_disco(Pila a, Pila b)
            {
         
            // Si la pila 'a' está vacía, mueve el disco de 'b' a 'a'
            if (a.Top == 0)
                {
                    if (b.Top > 0)
                    {
                        a.push(b.pop());
                   
                }
                }
                
                else if (b.Top == 0)
                {
                    if (a.Top > 0)
                    {
                        b.push(a.pop());
                    
                }
                }
                // Si el disco en la cima de 'a' es más pequeño que el de 'b', mueve el disco de 'a' a 'b'
                else if (a.Top < b.Top)
                {
                    b.push(a.pop());
               
            }
                // En caso contrario, mueve el disco de 'b' a 'a'
                else
                {
                    a.push(b.pop());
                
            }
           
          
          
        }

            // Método iterativo para resolver las Torres de Hanoi
            public int iterativo(int n, Pila ini, Pila fin, Pila aux)
            {
                
                if ((n % 2) == 0)
                {
                Hanoi.MostrarEstado(ini, fin, aux); 

                do
                    { 
                        Mover_disco(ini, aux); // Movimiento 1
                        movimientos++;
                        Hanoi.MostrarEstado(ini, fin, aux);

                        Mover_disco(ini, fin); // Movimiento 2
                        movimientos++;
                        Hanoi.MostrarEstado(ini, fin, aux); 

                    if (fin.Elementos.Count < n)
                        {
                            Mover_disco(aux, fin); // Movimiento 3
                            movimientos++;
                            Hanoi.MostrarEstado(ini, fin, aux); 
                    }
                    } while (fin.Elementos.Count < n);
                }
                else
                {
                    do
                    {
                        Mover_disco(ini, fin); // Movimiento 1
                        movimientos++;
                        Hanoi.MostrarEstado(ini, fin, aux); 

                    if (fin.Elementos.Count < n)
                        {
                            Mover_disco(ini, aux); // Movimiento 2
                            movimientos++;
                            Hanoi.MostrarEstado(ini, fin, aux); 

                            Mover_disco(aux, fin); // Movimiento 3
                            movimientos++;
                            Hanoi.MostrarEstado(ini, fin, aux);
                    }
                    } while (fin.Elementos.Count < n);
                }
                return movimientos; // num tot
            }

            // Método recursivo para resolver las Torres de Hanoi
            public int recursivo(int n, Pila ini, Pila fin, Pila aux)
            {
                if (n == 1)
                {
                    Hanoi.MostrarEstado(ini, fin, aux);

                    Mover_disco(ini, fin); 
                    movimientos++;
                    Hanoi.MostrarEstado(ini, fin, aux);

            }
                else
                {
                    recursivo(n - 1, ini, aux, fin); // Mueve n-1 discos de ini a aux
                    Mover_disco(ini, fin); // Movimiento: mueve un disco de ini a fin
                    movimientos++;
                    Hanoi.MostrarEstado(ini, fin, aux);
                    recursivo(n - 1, aux, fin, ini); // Mueve los n-1 discos restantes de aux a fin
                }
                return movimientos; // Devuelve el número total de movimientos realizados
            }
        public static void MostrarEstado(Pila ini, Pila fin, Pila aux)
        {
            Console.WriteLine("INI:");
            ini.MostrarContenidoEnPila();

            Console.WriteLine("AUX:");
            aux.MostrarContenidoEnPila();

            Console.WriteLine("FIN:");
            fin.MostrarContenidoEnPila();

            Console.WriteLine("..............................");
        }
    }
    }
