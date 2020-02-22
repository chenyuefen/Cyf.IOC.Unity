using Ruanmou.IDAL;
using Ruanmou.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Service
{
    public class Power : IPower
    {
        public Power(IBaseDAL baseDAL)
        {
        }

        public Power()
        {
            Console.WriteLine("Power 被构造");
        }
    }
}
