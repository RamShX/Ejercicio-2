public abstract class Shape
{
    //Atributos con su getters y setters
    protected double Ancho {get; set;}
    protected double Altura {get; set;}

    //Contructor inicializando
    public Shape(double ancho, double altura)
    {
        this.Ancho = ancho;
        this.Altura = altura;
    }

    //Método abstracto para hacer cálculos en las hijas(Triangle,Rectangle, Circle)
    public abstract double ClaculateSurface();
}