using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models;

namespace Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Infrastructure;
public class BoxesCollection:List<Box>
{
    private readonly Pallet _pallet;
    public BoxesCollection(Pallet pallet) => _pallet = pallet;

    public new void Add(Box box)
    {
        if (IsBoxSmallerPallet(box) && IsUniqueBoxId(box))
        {
            base.Add(box);          
        }        
    }

    private bool IsBoxSmallerPallet(Box box) =>
        _pallet.Dimensions.Lenght >= box.Dimensions.Lenght && _pallet.Dimensions.Width >= box.Dimensions.Width;

    private bool IsUniqueBoxId(Box box) => !this.Any(b => b.Id == box.Id);
}
