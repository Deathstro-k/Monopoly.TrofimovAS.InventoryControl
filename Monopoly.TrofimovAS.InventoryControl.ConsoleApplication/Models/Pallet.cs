using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Infrastructure;
using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models.Base;

namespace Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models;
public class Pallet : InventoryEntity
{
    public Pallet(Dimensions dimensions, double weight = 30) : base(dimensions, weight)
        => Boxes = new(this);
   
    public BoxesCollection Boxes { get; }

    public override Dimensions Dimensions { get => base.Dimensions; set => base.Dimensions = value; }

    public double SummaryVolume => Boxes.Sum(box=>box.Dimensions.Volume) + Dimensions.Volume;

    public double SummaryWeight => Boxes.Sum(box => box.Weight) + Weight;

    public override DateTime? ExpirationDate => Boxes.Min(box => box.ExpirationDate);
    public override DateTime? ProductionDate => Boxes.Min(box => box.ProductionDate);


    public override string ToString()
    {
        return $"Id:{Id}\n" +
               $"Summary volume:{SummaryVolume} cm^3\n" +
               $"Summary weight:{SummaryWeight} kg\n" +
               $"Pallet dimensions:{Dimensions}\n" +               
               $"Pallet weight:{Weight} kg\n" +
               $"Production date:{ProductionDate}\n" +
               $"Expiration date:{ExpirationDate}\n" +
               $"Boxes count:{Boxes.Count}";
    }
}

