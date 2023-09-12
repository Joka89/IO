using System;

namespace Trojkat.Services
{
    public class TrojkatLicz
    {
        public static bool Trojkat_Spr(double bokA, double bokB, double bokC)
        {
            //sprawdzenie czy uda sie stworzyć trójkąt z podanych wymiarów
            return (bokA + bokB > bokC) && (bokA + bokC > bokB) && (bokB + bokC > bokA);
        }
    }
}