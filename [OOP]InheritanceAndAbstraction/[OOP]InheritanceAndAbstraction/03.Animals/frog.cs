﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animals
{
    public class Frog : Animal
    {
         public Frog(string name,byte age,Gender gender)
            :base(name,age,gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kwak");
        }
    }
}