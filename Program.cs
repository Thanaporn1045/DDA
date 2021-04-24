using System;

namespace DDA
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step;
            float x1, y1, x2, y2;
            
            x1 = float.Parse(Console.ReadLine());
            y1 = float.Parse(Console.ReadLine());
            x2 = float.Parse(Console.ReadLine());
            y2 = float.Parse(Console.ReadLine());
            dx = x2 - x1;
            dy = y2 - y1;
            if(Math.Abs(dx)>=Math.Abs(dy))
            {
                step = Math.Abs(dx);
            }
            else
            {
                step = Math.Abs(dy);
            }
            dx /= step;
            dy /= step;
            x = x1;
            y = y1;
            int i;
            for(i=1; i<=step; i++)
            {   Console.Write(x);
                Console.Write(",\",");
                Console.Write("\",");
                Console.Write(y);
                x += dx;
                y += dy;
            }
        }
    }
}
