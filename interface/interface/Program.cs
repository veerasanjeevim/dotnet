using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    internal class Program
    {
        interface idrawable
        {
            void draw();

        }
        interface iresizable
        {
            void resize(int width, int height);
        }
        class circle : idrawable
        {
            public void draw()
            {
                Console.WriteLine("drawing circle...");
            }
        }
        class rectangle : idrawable, iresizable
        {
            private int width;
            private int height;

            public void draw()
            {
                Console.WriteLine($"drawing a rectangle{width} ,{height}");
            }

                public void resize(int width, int height) { 

                this.width = width;
                this.height = height;

            }
        }

    

        static void Main(string[] args)
        {
            rectangle r1 = new rectangle();
          
            r1.resize(267, 7262);
            r1.draw();
        }
    }
}
