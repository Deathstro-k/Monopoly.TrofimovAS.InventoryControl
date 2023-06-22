
using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Infrastructure;
using Newtonsoft.Json;

namespace Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models.Base;

public abstract class InventoryEntity
{
    public InventoryEntity(Dimensions dimensions, double weight)
    {
        Id = Guid.NewGuid();
        Dimensions = dimensions;
        Weight = weight;
    }
    protected InventoryEntity() { }

    [JsonProperty("id")]
    public Guid Id { get;set; }

    public virtual Dimensions Dimensions { get; set; }

    public virtual double Weight { get; }

    public virtual DateTime? ProductionDate { get; set; } 
    public virtual DateTime? ExpirationDate { get; set; }

  

    public override string ToString()
    {
        return $"Id:{Id}\n" +
               $"Dimensions:{Dimensions}\n" +
               $"Weight:{Weight} kg\n" +
               $"Production date:{ProductionDate}\n" +
               $"Expiration date:{ExpirationDate}\n";              
    }
}
