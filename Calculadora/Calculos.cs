using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculos
    {
        public static double Soma(double num1, double num2)
        {
            return num1 + num2;
        }
        


        public static bool Volumes(bool c, bool p, bool r)
        {
           
            bool cubo = c == true ? true: false;
            bool paralelepipedo = p == true ? true : false;
            bool retangulo = r == true ? true : false;
            // bool volume = cubo == false && paralelepipedo == true ? true : false;

            bool a = true;
            bool l = true;


            bool volume = cubo == false && paralelepipedo == true ? true : false;
            bool massa = cubo == false && paralelepipedo == true || retangulo == true ? true : false;
            

            if (volume == true)
            {
                a = true;
                
            }
            if (volume == false)
            {
                a = false;
            }
            if (massa == true)
            {
                l = true;
            }
            if (massa == false)
            {
                l = false;
            }
            return a || l;
        }
    }
}
