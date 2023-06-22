using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Infrastructure;
using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models.Base;

namespace Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models;
public class Box : InventoryEntity
{  
    public Box(Dimensions dimensions, double weight, DateTime productionDate) : base(dimensions, weight)
    {
        ProductionDate = productionDate;
        ExpirationDate = productionDate.AddDays(100);
    }

    public Box(Dimensions dimensions, double weight, DateTime expirationDate, DateTime? productionDate) : base(dimensions, weight)
    {
        ProductionDate = productionDate;
        ExpirationDate = expirationDate;
    }
    public Box() { }    
}
