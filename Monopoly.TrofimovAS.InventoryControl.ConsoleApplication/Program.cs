using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Infrastructure;
using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models;
using static Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Helpers.InventoryItemsGenerator;

namespace Monopoly.TrofimovAS.InventoryControl.ConsoleApplication;

internal class Program
{
    static void Main(string[] args)
    {
        var a = JsonFileStorage.ReadFromFile<Pallet>("1.json");


        foreach (var item in a)
        {
            Console.WriteLine(item.Id);
        };
        //var boxes = CreateRandomBoxes(2);
        //var pallets = CreatePallets(1).AddBoxesToPallets(boxes);



        //foreach (var box in pallets) { Console.WriteLine(box); }
        //foreach (var box in pallets) { Console.WriteLine(box); }

        //pallets.WriteToFile("1.json");
    }

}