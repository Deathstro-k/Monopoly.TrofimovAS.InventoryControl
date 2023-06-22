using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Infrastructure;
using Monopoly.TrofimovAS.InventoryControl.ConsoleApplication.Models;

namespace Monopoly.TrofimovAS.InventoryControl.Tests.Models;

public class BoxTests
{
    [Test]
    public void CreateBoxWithTheProductionDateOnly()
    {
        var expectedBox = new Box(new Dimensions(5, 5, 5), 20, DateTime.Parse("21.06.2023").AddDays(100), DateTime.Parse("21.06.2023"));

        var actualBox = new Box(new Dimensions(5, 5, 5), 20, DateTime.Parse("21.06.2023"));

        Assert.That(actualBox.ExpirationDate, Is.EqualTo(expectedBox.ExpirationDate));
    }    

}