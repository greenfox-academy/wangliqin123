﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetApp.Models
{
    public class Greet
    {
        public string Name { get; set; }

        public void Greeting()
        {
            Console.WriteLine("Hello: {0} !", Name);
        }
    }
}
