﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VasilevAA.Sprint2.Task2.V1.Lib
{
    public class DataService : ISprint2Task2V1
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x == 3 && ((y >= 3 && y <= 4) || (y == 7) || (y == 11)))
        || (x == 4 && ((y >= 3 && y <= 4) || (y == 7) || (y >= 11 && y <= 13)))
        || (x == 5 && ((y >= 3 && y <= 7) || (y == 11)))
        || (x == 6 && (y >= 5 && y <= 11))
        || (x == 7 && (y >= 5 && y <= 12))
        || (x == 8 && (y >= 5 && y <= 12))
        || (x == 9 && (y >= 3 && y <= 7))
        || (x == 10 && (y >= 5 && y <= 7))
        || (x == 11 && (y >= 5 && y <= 7))
        || (x == 12 && (y >= 3 && y <= 11))
        || (x == 13 && (y >= 6 && y <= 8)))
            {
                return true;
            }
            return false;
        }
    }
}
