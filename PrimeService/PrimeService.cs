﻿using System;

namespace PrimeService
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            for (int i =2;i<candidate;i++)
            {
                if (candidate % i == 0)
                    return false;
            }
            return true;
        }
    }
}
