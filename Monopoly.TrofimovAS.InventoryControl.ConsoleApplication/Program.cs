using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Infrastructure;
using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models;
using static Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Helpers.InventoryItemsGenerator;

namespace Monopoly.TrofimovAS.InventoryControl.ConsoleApplication;

internal class Program
{
    private static readonly string _path = "pallets.json";
    private static List<Pallet> _pallets;
    static void Main(string[] args)
    {          
        var boxes = CreateRandomBoxes(2_000);
        _pallets = CreatePallets(50).AddBoxesToPallets(boxes);      

        Console.WriteLine("Вывести на экран:\r\n" +
            "1) Сгруппированые паллеты по сроку годности, отсортированные по возрастанию срока годности," +
            " в каждой группе отсортированные паллеты по весу.\r\n" +
            "2) 3 паллеты, которые содержат коробки с наибольшим сроком годности, " +
            "отсортированные по возрастанию объема.\r\n" +
            "Введите номер пункта и нажмите Enter!");

        var number=Console.ReadLine();

        if (number == "1")
        {
            var palletsByExpirationDate = _pallets.GroupBy(pallet => pallet.ExpirationDate.Value.ToString("dd.MM.yyyy"))
               .OrderBy(group=>group.Key);

            foreach (var group in palletsByExpirationDate)
            {
                Console.WriteLine(new string('*', Console.WindowWidth));
                Console.WriteLine($"\nExpiration Date: {group.Key}");
                var groupBySummaryWeight = group.OrderBy(pallet => pallet.SummaryWeight);
                foreach (var pallet in groupBySummaryWeight)
                {
                    Console.WriteLine(new string('_', Console.WindowWidth));
                    Console.WriteLine(pallet);
                }
            }
        }

        if(number == "2")
        {                        
            var topThreePalletsByBoxExpirationDate = _pallets
                  .OrderByDescending(pallet => pallet.Boxes.Max(box => box.ExpirationDate.Value.ToString("dd.MM.yyyy")))
                  .Take(3)
                  .OrderBy(pallet => pallet.SummaryVolume).ToList();
           
            foreach (var pallet in topThreePalletsByBoxExpirationDate)
            {
                Console.WriteLine(new string('_', Console.WindowWidth));
                Console.WriteLine(pallet);
            }
        }
        Console.WriteLine("Сохранить созданные паллеты?[Y/N]");

        if (Console.ReadKey().Key == ConsoleKey.Y)
        {
            _pallets.WriteToFile(_path);
        }       
    }   
}