using System;
using System.Collections.Generic;
namespace Calculations
{
    public class Calculations
    {
        public List<int> FiboNumbers => new() { 1, 1, 2, 3, 5, 8, 13 };
        
        public bool IsOdd(int value)
        {
            return (value % 2) == 1;
        }
    }
        
}
