using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Helpers;

namespace Monopoly.TrofimovAS.InventoryControl.ConsoleApplication;

internal class Program
{
    static void Main(string[] args)
    {
        var a = InventoryItemsGenerator.CreateRandomBoxes(10000);

        var b = InventoryItemsGenerator.CreatePallets(100).AddBoxesToPallets(a);
        foreach (var item in b)
        {
            Console.WriteLine(item);
            
            Console.WriteLine(new string('_',Console.WindowWidth));    
        }
    
    }

}