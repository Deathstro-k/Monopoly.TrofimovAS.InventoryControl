namespace Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models.Base;

public abstract class InventoryEntity
{
    public InventoryEntity(double width, double height, double lenght, double weight)
    {
        Id=Guid.NewGuid();
        Width = width;
        Height = height;
        Lenght = lenght;
        Weight = weight;       
    } 
    public Guid Id { get; }

    public double Width { get; }
    public double Height { get; }
    public double Lenght { get; }

    public virtual double Weight { get; }
    public virtual double Volume => Width * Height * Lenght;

    public virtual DateTime? ProductionDate { get; set; } 
    public virtual DateTime? ExpirationDate { get; set; } 
   

    public override string ToString()
    {
        return $"Id:{Id}\n" +
               $"Volume:{Volume} cm^3 ({Lenght}x{Width}x{Height})\n" +
               $"Weight:{Weight} kg\n" +
               $"Production date:{ProductionDate}\n" +
               $"Expiration date:{ExpirationDate}\n";              
    }
}
