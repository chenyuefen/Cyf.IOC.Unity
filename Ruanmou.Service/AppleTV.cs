﻿using Ruanmou.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruanmou.Service
{
    public class AppleTV : ITV
    {
        public AppleTV(int id)
        {

        }
        public void Show()
        {
            Console.WriteLine($"This is {nameof(AppleTV)}");
        }
    }
}
