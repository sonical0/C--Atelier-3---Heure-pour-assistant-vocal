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

    [TestMethod]
    public void Test7Apresmidi()
    {
        HeureVocale heureVocale = new ();

        var actual = heureVocale.Convertir(DateTime.Parse("14:00"));

        Assert.AreEqual("deux heures de l'après-midi", actual);
    }

    [TestMethod]
    public void TestMidiDix()
    {
        HeureVocale heureVocale = new ();
        var actual = heureVocale.Convertir(DateTime.Parse("12:10"));
        Assert.AreEqual("midi dix", actual);
    }

    [TestMethod]
    public void TestTroisHeuresVingtCinqApresMidi()
    {
        HeureVocale heureVocale = new ();
        var actual = heureVocale.Convertir(DateTime.Parse("15:25"));
        Assert.AreEqual("trois heures vingt-cinq de l'après-midi", actual);
    }

    [TestMethod]
    public void TestMinuitEtQuart()
    {
        HeureVocale heureVocale = new ();
        var actual = heureVocale.Convertir(DateTime.Parse("00:15"));
        Assert.AreEqual("minuit et quart", actual);
    }
}
