using Polimorfismo;

List<IFigura> figuras = new List<IFigura>
{
    new Circulo(5.0),
    new Cuadrado(4.0)

};


foreach (var figura  in figuras)
{ 

    Console.WriteLine($"Área de la figura es: {figura.CalcularArea()}");

}
