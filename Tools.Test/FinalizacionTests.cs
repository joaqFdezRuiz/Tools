using NUnit.Framework;
using Tools.Prod.Finalizacion;

namespace Tools.Test
{
  [TestFixture]
  class FinalizacionTests
  {
    private IFinalizacion finalizacion;
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
