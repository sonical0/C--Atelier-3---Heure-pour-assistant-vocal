namespace TestHeureVocale;

using Epsi.Atelier3;

[TestClass]
public sealed class TestHeureVocale
{
    [TestMethod]
    public void Test7hPile()
    {
        HeureVocale heureVocale = new ();

        var actual = heureVocale.Convertir(DateTime.Parse("7:00"));

        Assert.AreEqual("sept heures pile", actual);
    }
}
