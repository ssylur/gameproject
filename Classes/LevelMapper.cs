using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Classes
{
    class LevelMapper
    {
        static public int adjust(int score)
        {
            if (score > 40)
            {
                return 5;
            }
            if (score > 25)
            {
                return 4;
            }
            if (score > 15)
            {
                return 3;
            }
            if (score > 5)
            {
                return 2;
            }
          
            return 1;
        }
    }
}
