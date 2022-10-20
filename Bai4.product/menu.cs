using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4.product
{
    internal class Menu
    {   
        public int id { get; set; }
        public string title { get; set; }   
        public int parent_id { get; set; }

       public static void name()
        {
            Console.WriteLine("name");
        }
    }
}
