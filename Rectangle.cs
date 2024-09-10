public class Rectangle : Shape
{
    //contructor
    public Rectangle(double ancho, double altura)
    : base (ancho, altura){}

    //Método para calcular el areaa de un Rectángulo
    public override double ClaculateSurface()
    {
        return Ancho * Altura;
    }
}