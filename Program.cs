using System;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            /*
                    |   Funções de data C# |
            Console.WriteLine(formatada);
            var data = new DateTime();
            var data = DateTime.Now;
            var data = new DateTime(2020, 10, 12, 8, 23, 14);

            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.DayOfWeek);

            Console.WriteLine((int)data.DayOfWeek);

            var data = DateTime.Now;        
            var formatada = String.Format("{0:y}", data); //exibe mes e ano
            var formatada = String.Format("{0:M}", data); //exibe dia e mes
            var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data); //exibe dia e hora
            var formatada = String.Format("{0:D}", data); // dia completo 
            var formatada = String.Format("{0:f}", data); // dia completo 
            var formatada = String.Format("{0:g}", data); // dia completo 
            var formatada = String.Format("{0:r}", data); // usado pra JSON 
            var formatada = String.Format("{0:s}", data); // usado pra JSON 
            var formatada = String.Format("{0:u}", data); // usado pra JSON 
            */

            /*

                | Metodos C# para calcular datas |
            
            

            var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(12)); // seleciona data atual e soma 12 dias
            Console.WriteLine(data.AddMonths(1)); // seleciona data atual e soma mais um mes
            Console.WriteLine(data.AddYears(1)); // seleciona data atual e soma mais um ano
            Console.WriteLine(data.AddHours(1)); // seleciona data atual e soma mais um hora

            */


            /*

                | Metodos C# para comparar datas |
            
            

            var data = DateTime.Now;

            if (data.Date >= DateTime.Now.Date)
                Console.WriteLine("É igual");

            Console.WriteLine(data);

            */


            /*

               | Metodos C# para Cultura/País |
           
            
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", pt));
            */

            /*

              | Metodos C# para TIMEZONE |
           


            var utcDate = DateTime.UtcNow;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(utcDate);

            Console.WriteLine(utcDate.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific");
            Console.WriteLine(timezoneAustralia);

            var horaAustralia =
                TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            Console.WriteLine(horaAustralia);
            */

            /*

              | Metodos C# para Data  |
           

            Console.Clear();

            Console.WriteLine(DateTime.DaysInMonth(2020, 1)); // conta dias do mes


            // verifica se o dia é sabado ou domingo
            static bool IsWeekDay(DayOfWeek today)
            {
                return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
            }

             */


            /* 
                | Formatação de Moeda |
            
            */
            Console.Clear();

            decimal valor = 10536.25m;
            // string "C" exibe moeda local
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

            // Metodo de arredondamento de valor
            Console.WriteLine(Math.Round(valor)); // arredonda na média
            Console.WriteLine(Math.Ceiling(valor)); // arredonda pra cima
            Console.WriteLine(Math.Floor(valor)); // arredonda pra baixo


        }
    }
}
