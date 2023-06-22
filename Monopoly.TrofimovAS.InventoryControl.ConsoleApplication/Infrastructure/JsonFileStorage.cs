using Newtonsoft.Json;

namespace Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Infrastructure;
public static class JsonFileStorage
{
    public static void WriteToFile<T>(this IEnumerable<T> collection, string filename)
    {
        string json = JsonConvert.SerializeObject(collection);
        File.WriteAllText(filename, json);        
    }

    public static IEnumerable<T> ReadFromFile<T>(string filename)
    {
        string json = File.ReadAllText(filename);        
        return JsonConvert.DeserializeObject<IEnumerable<T>>(json);
    }
}