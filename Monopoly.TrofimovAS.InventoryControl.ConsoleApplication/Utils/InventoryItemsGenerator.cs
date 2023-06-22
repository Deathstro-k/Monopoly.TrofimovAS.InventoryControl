using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Infrastructure;
using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models;

namespace Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Helpers;

public static class InventoryItemsGenerator
{
    private static readonly Random _random = new();

    public static List<Box> CreateRandomBoxes(int count)
    {
        var boxes = new List<Box>();        

        for (int i = 0; i < count; i++)
        {
            var randomDimension = _random.Next(1,100);
            var randomWeight = _random.Next(1,100);

            var dimensions = new Dimensions(randomDimension,randomDimension,randomDimension);
            var box = new Box(dimensions, randomWeight, DateTime.Now.AddDays(_random.Next(-100,100)));
            boxes.Add(box);
        }
        return boxes;
    }

    public static List<Pallet> CreatePallets(int count)
    {        
        var pallets = new List<Pallet>();   
        for (int i = 0; i < count; i++)
        {
            pallets.Add(new Pallet(new Dimensions(200,500,250)));
        }
        return pallets;
    }

    public static List<Pallet> AddBoxesToPallets(this List<Pallet> pallets,List<Box> boxes)
    {
        boxes.ForEach(box => pallets[_random.Next(0, pallets.Count)].Boxes.Add(box));
        return pallets;
    }
}
