using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Infrastructure;
using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models.Base;

namespace Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models;
public class Pallet : InventoryEntity
{ 
    public Pallet(double width, double height, double lenght, double weight = 30)
        : base(width, height, lenght, weight)
    {
        Boxes = new BoxesCollection(this);
    }
    public BoxesCollection Boxes { get; }
   
    public override double Weight => base.Weight + Boxes.Sum(b=>b.Weight);
    public override double Volume => base.Volume + Boxes.Sum(b=>b.Volume);

    public override DateTime? ExpirationDate => Boxes.Min(p => p.ExpirationDate);
    public override DateTime? ProductionDate => Boxes.Min(b => b.ProductionDate);


    public override string ToString()
    {
        return $"Id:{Id}\n" +
               $"Volume:{Volume} cm^3 ({Lenght}x{Width}x{Height})\n" +
               $"Weight:{Weight} kg\n" +
               $"Production date:{ProductionDate}\n" +
               $"Expiration date:{ExpirationDate}\n" +
               $"Boxes count:{Boxes.Count}";
    }

}
    
