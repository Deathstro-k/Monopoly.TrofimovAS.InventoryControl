using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Infrastructure;
using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models;

namespace Monopoly.TrofimovAS.InventoryControl.Tests.Infrastructure;
public class BoxesCollectionTests
{   
    [Test]
    public void AddUniqueAndSmallerPalletBox()
    {
        var pallet = new Pallet(new Dimensions(10, 10, 10));
        var boxes = new BoxesCollection(pallet);
        var box = new Box(new Dimensions(5, 5, 5), 20, DateTime.Now);

        boxes.Add(box);

        Assert.IsTrue(boxes.Count == 1);
    }

    [Test]
    public void AddUniqueAndNotSmallerPalletBox()
    {
        var pallet = new Pallet(new Dimensions(10, 10, 10));
        var boxes = new BoxesCollection(pallet);
        var box = new Box(new Dimensions(25, 25, 25), 20, DateTime.Now);

        boxes.Add(box);

        Assert.IsTrue(boxes.Count == 0);
    }

    [Test]
    public void AddNotUniqueAndSmallerPalletBox()
    {
        var pallet = new Pallet(new Dimensions(10, 10, 10));
        var boxes = new BoxesCollection(pallet);
        var box = new Box(new Dimensions(5, 5, 5),20, DateTime.Now);

        boxes.Add(box);
        boxes.Add(box);

        Assert.IsTrue(boxes.Count == 1);
    }

    [Test]
    public void AddNotUniqueAndNotSmallerPalletBox()
    {
        var pallet = new Pallet(new Dimensions(10, 10, 10));
        var boxes = new BoxesCollection(pallet);
        var box = new Box(new Dimensions(25, 25, 25), 20, DateTime.Now);

        boxes.Add(box);
        boxes.Add(box);

        Assert.IsTrue(boxes.Count == 0);
    }
}