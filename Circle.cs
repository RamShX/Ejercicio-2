public class Circle : Shape
{
    //Contructor
    public Circle(double radio)
    : base (radio , radio){}

    //Método para calcular el area de un Circulo
    public override double ClaculateSurface()
    {
        // El ancho y el alto son iguales
        double radio = Ancho;

        return Math.PI * radio * radio;
    }
}