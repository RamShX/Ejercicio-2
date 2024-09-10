
public class Triangle : Shape
{
    //Contructor
    public Triangle(double ancho, double altura)
    : base(ancho, altura){}

    //Método para calcular un Triángulo
    public override double ClaculateSurface()
    {
        return (Ancho * Altura)/2;
    }
}