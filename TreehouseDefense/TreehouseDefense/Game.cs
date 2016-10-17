using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new TreehouseDefense.Map(8, 5);
       
            int area = map.Width * map.Height;
        }
    }
}