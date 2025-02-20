using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //aula91 propriedades e operações com timeSpan
            DateTime d = new DateTime(2001, 08, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) Day: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine(d.ToLongDateString()); // Transformando datetime em string
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));

            Console.WriteLine("---------------------------------------------");

            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine("--------------------------------------------");
            // Exemplo BOLETO

            DateTime s = DateTime.Now; // gera o momento atual que o boleto foi emitido por exemplo

            DateTime s2 = s.AddDays(7); // adiciono 7 dias a data da emissão do boleto para definir 

            Console.WriteLine(s); // 20 / 02 / 2025 11:02:46 EXEMPLO DA DATA DA EMISSÃO DO BOLETO
            Console.WriteLine(s2); // 27 / 02 / 2025 11:02:46 EXEMPLO DA DATA DO VENCIMENTO

            Console.WriteLine("-------------------------------------------");

            DateTime a = new DateTime(2000, 10, 15);

            DateTime a2 = new DateTime(2000, 10, 18);

            TimeSpan t = a2.Subtract(a); // data final subtrai data inicial e atribui a "t" para marcar duração

            Console.WriteLine(t); // RESULTADO 3 DIAS de diferença
        }
    }
}