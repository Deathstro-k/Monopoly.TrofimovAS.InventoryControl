using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace Monopoly.TrofimovAS.InventoryControl.Tests.Models;
public class PalletTests
{
    [Test]
    public void CalculateExpirationDate_MinimumBoxExpirationDate()
    {
        var pallet = new Pallet(10,10,10);

        var box1 = new Box(10, 10, 10, 10, DateTime.Parse("21.06.2023"));
        var box2 = new Box(10, 10, 10, 10, DateTime.Parse("22.06.2023"));
        var box3 = new Box(10, 10, 10, 10, DateTime.Parse("23.06.2023"),null);

        pallet.Boxes.Add(box1); 
        pallet.Boxes.Add(box2);
        pallet.Boxes.Add(box3);

        Assert.True(pallet.ExpirationDate == DateTime.Parse("23.06.2023"));
    }


    [Test]
    public void CalculateVolumeDate_SumVolumeBoxesPlusPalletVolume()
    {
        var pallet = new Pallet(10, 10, 10);

        var box1 = new Box(10, 10, 10, 10, DateTime.Parse("21.06.2023"));
        var box2 = new Box(10, 10, 10, 10, DateTime.Parse("22.06.2023"));
        var box3 = new Box(10, 10, 10, 10, DateTime.Parse("23.06.2023"), null);

        pallet.Boxes.Add(box1);
        pallet.Boxes.Add(box2);
        pallet.Boxes.Add(box3);

        var actual = pallet.Height*pallet.Width*pallet.Lenght;
        foreach (var box in pallet.Boxes) 
        {
            actual += box.Volume;
        }
        Assert.True(pallet.Volume == actual);
    }

    [Test]
    public void CalculateWeightDate_SumWeightBoxesPlusPalletVolume()
    {
        var pallet = new Pallet(10, 10, 10);

        var box1 = new Box(10, 10, 10, 10, DateTime.Parse("21.06.2023"));
        var box2 = new Box(10, 10, 10, 10, DateTime.Parse("22.06.2023"));
        var box3 = new Box(10, 10, 10, 10, DateTime.Parse("23.06.2023"), null);

        var actual = 30.0d;
        foreach (var box in pallet.Boxes)
        {
            actual += box.Weight;
        }
        Assert.True(pallet.Weight == actual);
    }

}