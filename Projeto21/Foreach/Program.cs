namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = { "Maria", "Bob", "Alex" };

            //AO INVES DE USAR ISSO: 
            /*
             for (int i = 0; i < vect.Lenght; i++) {
                Console.WriteLine(vect[i]);
            }
            */
            
            //USAR ISSO:
            foreach (string obj in vect) // O QUE DIZ: PARA CADA OBJETO DO VETOR
            {
                Console.WriteLine(obj); // MOSTRE NO CONSOLE O VETOR DE NOMES
            }
        }
    }
}