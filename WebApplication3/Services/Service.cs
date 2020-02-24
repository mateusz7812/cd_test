using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Services
{
    public class Service
    {
        private readonly int number = 0;

        public Service(int number)
        {
            this.number = number;
        }

        public int Calc()
        {
            return number * 3;
        }
    }
}
