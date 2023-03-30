using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.DataContracts;
using System.Text;
using System.Threading.Tasks;

namespace OpenAPICLient
{
    internal class Methoden
    {
        public Methoden()
        {
            MachSachen(12, "haha", DateTime.Now.Ticks, "mehr");
            MachSachen(12, "haha", DateTime.Now.Ticks);
            MachSachen(12, "haha");
            MachSachen(12, "haha", ffff: 0.8f, mehrText: "lulu");
            MachSachen(12, "haha", 5555, mehrText: "lulu", 0.9f);

        }

        //static void MachSachen(int zahl, string text, DateTime datum)
        //{
        //    MachSachen(zahl, text, datum, "lalal");
        //}


        static void MachSachen(int zahl, string text, long datum = default, string mehrText = "lala", float ffff = 0.6f)
        {
            Console.WriteLine("Hallo");

            //Save<int>(12);
            //Save<OutOfMemoryException>(new OutOfMemoryException());
            Save<DayOfWeek>(DayOfWeek._6);
        }

        static void SaveAll()
        {
            using StreamWriter sw = new StreamWriter("AAa.txt");
            
                //using(var serial = new TextWriter(sw))



        } //IDispose


        static void Save<T>(T dings) where T : Enum
        {
            Console.WriteLine("");
        }

    }
}
