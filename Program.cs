using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creación mátriz
            Shape[] shapes = new Shape [3];

            // Inicializar la mátriz con diferentes Shapes
            shapes[0] = new Circle(5);
            shapes[1] = new Rectangle(3,7);
            shapes[2] = new Triangle(4,6);

            // Crear una mátriz para almacenar las áreas calculadas
            double[] areas = new double[shapes.Length];

            //recorrer la mátriz
            for (int i = 0; i < shapes.Length; i++)
            {
                areas[i] = shapes[i].ClaculateSurface();

                Console.WriteLine($"Área de la forma {i + 1}: {areas[i]}");
            }



        }
    }
}