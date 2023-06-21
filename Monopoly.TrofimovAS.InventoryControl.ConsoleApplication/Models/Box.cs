using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models.Base;

namespace Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models;
public class Box : InventoryEntity
{
    public Box(double width, double height, double lenght, double weight,DateTime productionDate)
        : base(width, height, lenght, weight)
    {
        ProductionDate = productionDate;
        ExpirationDate = productionDate.AddDays(100);
    }
    public Box(double width, double height, double lenght, double weight, DateTime expirationDate, DateTime? productionDate)
        : base(width, height, lenght, weight)
    {        
        ExpirationDate = expirationDate;
        ProductionDate = productionDate;
    }
   
}
