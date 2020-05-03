using System;

namespace Area
{
    public class Area
    {
        double S;
        double p = 0;
        public double FindArea(params int[] par)
        {
            if (par.Length == 1)
            {
                if (par[0] == 0) throw new Exception("Передайте другое значение");
                S = Math.PI * par[0] * par[0];
            }
            else if (par.Length == 3)
            {
                if (par[0] == 0 || par[1] == 0 || par[2] == 0) throw new Exception("Передайте другое значение");
                p = double.Parse(par[0].ToString()) * par[1] * par[2] / 2;
                S = Math.Sqrt(p * (p - par[0]) * (p - par[1]) * (p - par[2]));
            }
            else throw new Exception("Ошибка в передачи переменных в функцию!");
            
            return S;
        }
    }
}
