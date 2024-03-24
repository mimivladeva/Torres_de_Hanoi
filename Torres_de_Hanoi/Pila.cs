using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {

        // Variables.
        public int Size { get; set; }
        public int Top { get; set; }
        public List<Disco> Elementos { get; set; }



        //Constructor 1 vacio
        public Pila()
        {
            Size = 0;
            Elementos = new List<Disco>();
            Top = 0;
        }

        //Constructor 2 
        public Pila(int Size)
        {
            this.Size = Size;
            Elementos = new List<Disco>();
            Top = -1; //para indicar que, inicialmente, no hay ningún disco en la pila.

            for (int i = this.Size; i > 0; i--) // se usa para agregar discos y disminuye i en cada iteración hasta llegar a 1.
            {
                Elementos.Add(new Disco(i));
                Top = Elementos.Last().Valor;//Top se actualiza con el valor del último disco añadido
            }
        }

 
        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = Elementos.Last().Valor;
        }


        //Metodo para eliminar un disco de la pila
        public Disco pop()
        {
            Disco d = Elementos.Last();
            Elementos.Remove(d);

            //Esto maneja cualquier excepción que pueda ocurrir al
            //intentar acceder al último elemento de la lista después
            //de haber eliminado un disco. Si la lista está vacía después
            //de eliminar el disco superior, se generaría una excepción.
            try
            {
                Top = Elementos.Last().Valor;
            }
            catch (Exception)
            {
                Top = 0;
            }
            return d;
        }


        //Metodo para saber si la lista elementos esta vacia.
        public bool isEmpty()
        {
            return !Elementos.Any();
        }

        public void MostrarContenidoEnPila()
        {

            if (Elementos.Count == 0)
            {
                Console.WriteLine("Vacia");
            }
            else
            {
                foreach (Disco disco in Elementos)
                {
                    Console.WriteLine($"{disco.Valor}");
                }
            }
            Console.WriteLine();
        }
    }
}


