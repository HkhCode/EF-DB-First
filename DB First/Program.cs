using DB_First.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new UnivercityEntities())
            {
                var city = context.Cities.FirstOrDefault(x => x.Id == 1);
                Console.WriteLine(city.Id);
                Console.WriteLine(city.Name);
                Console.WriteLine("====================");
                context.Cities.Add(new City
                {
                    Name = "Tehran"
                }
                );
                context.SaveChanges();
                var city_selected = context.Cities.FirstOrDefault(x => x.Name == "Tehran");
                Console.WriteLine(city_selected.Name);
                Console.WriteLine("===============");
                Console.ReadKey();
            }
        }
    }
}
