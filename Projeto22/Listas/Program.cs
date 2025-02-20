using System.Numerics;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); // List<string> list -> CRIO A LISTA , new List<string>(); -> INSTANCIO A LISTA

            //Método Add
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            //Método Insert
            list.Insert(2, "Marco"); // Na posição 2, adicionar Marco.

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count); // contagem de elementos na lista

            // Ao invés desse:
            /*
            string s1 = list.Find(Test); // Espera um predicado como argumento
            Console.WriteLine("First 'A': " + s1);
            */

            // Usar esse:
            string s1 = list.Find(x => x[0] == 'A'); // lambda: quero o objeto x, tal que, x na posição 0 seja igual o caracater A maiusculo.
            Console.WriteLine(s1);

            string s2 = list.FindLast(x => x[0] == 'A'); // achando a última pessoa da lista com inicial A
            Console.WriteLine(s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1); // Posição do primeiro que inicia com A, resultado Alex, pois está na posição 1
            
            int pos2 = list.FindLastIndex(x =>  x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            Console.WriteLine("---------------------------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5); // Aqui estou pedindo para a busque todos os nomes com 5 letras da (list)
                                                                   // e envie para a list2.
            foreach (string obj in list2)
            {
                Console.WriteLine(obj); 
            }

            Console.WriteLine("---------------------------------------");

            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------------");

            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------------");

            
            list.RemoveAt(1); // Remover na posição 1
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            
        }

        static bool Test(string s)
        {
            return s[0] == 'A'; // Método que acha a primeira pessoa da lista com a inicial A
        }
    }
}