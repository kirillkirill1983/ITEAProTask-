using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autos = new List<Auto>
            {
                new Auto{MarkaAuto="гонка",Model="Запорожец",Year=1982,Color="Фиолетовый" },
                new Auto{MarkaAuto="полугонка",Model="Таврия",Year=1981,Color="Оранжевый" },
                new Auto{MarkaAuto="едет",Model="Москвич",Year=1985,Color="Зеленый" }
            };

            List<Driver> drivers = new List<Driver>
            {
                new Driver{ MarkaAuto="гонка", Name="Иван Иваныч", Tel="12-34-45"  },
                new Driver{ MarkaAuto="полугонка", Name="Иван Фиоипыч", Tel="12-34-45"  },
                new Driver{ MarkaAuto="гонка", Name="Семен Иваныч", Tel="12-34-45"  },
                new Driver{ MarkaAuto="едет", Name="Николый Анросович", Tel="12-34-45"  },
            };

            var result = from select1 in autos
                         join select2 in drivers
                         on select1.MarkaAuto equals select2.MarkaAuto
                         select new {Name=select2.Name,
                             Marka=select2.MarkaAuto,
                             Model=select1.Model,
                             Year=select1.Year };

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Marka} ({item.Model} {item.Year}) ");
            }

            Console.ReadKey();
        }
    }
    class Auto
    {
        public string MarkaAuto { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

    class Driver
    {
        public string MarkaAuto { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
    }
}
