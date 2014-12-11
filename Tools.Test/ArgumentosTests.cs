using System;
using NUnit.Framework;
using Tools.Prod.Argumentos;

namespace Tools.Test
{
  [TestFixture]
  public class ArgumentosTests
  {
    private  IArgumentos argumentos;
    [SetUp]
    public void SetUp() {
      argumentos = new Argumentos(new string[] { "un argumento" });
    }

    [Test]
    public void DevolverVerdaderoSiNumeroArgumentosIgualAlEsperado()
    {
      Assert.IsTrue(argumentos.ValidarNumArgumentos(1));
    }

    [Test]
    public void DevolverExcepcionSiNumeroArgumentosDistintoAlEsperado() {
      Assert.That(Assert.Throws<ArgumentException>(() => argumentos.ValidarNumArgumentos(2)), 
        Has.Message.EqualTo("número de argumentos incorrecto"));
    }
  }
}
