using NUnit.Framework;
using Tools.Prod;

namespace Tools.Test
{
  [TestFixture]
  class FinalizacionTests
  {
    private Finalizacion finalizacion;
    [SetUp]
    public void SetUp()
    {
      finalizacion = new Finalizacion();
    }
    [Test]
    public void DevolverCeroSiFinalizacionCorrecta()
    {
      Assert.AreEqual(0, finalizacion.Correcto);
    }

    [Test]
    public void DevolverMenosUnoSiFinalizacionError()
    {
      Assert.AreEqual(-1, finalizacion.Error);
    }
  }
}
