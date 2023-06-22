namespace Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Infrastructure;
public class Dimensions
{
    public Dimensions(double lenght, double width, double height)
    {
        Lenght = lenght;
        Width = width;
        Height = height;
    }

    public double Lenght { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public virtual double Volume => Lenght * Width * Height;    
    public virtual double Area => Width * Lenght;

    public override string ToString()
    {
        return $"\n" +
               $"\tVolume:{Volume} cm^3 ({Lenght}x{Width}x{Height}) cm\n" +
               $"\tArea:{Area} cm^2 ({Lenght}x{Width}) cm";
    }
}
