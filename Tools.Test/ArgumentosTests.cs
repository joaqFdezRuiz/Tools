using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Tools.Prod.Argumentos;

namespace Tools.Test

{
  [TestFixture]
  public class ArgumentosTests
  {
    [Test]
    public void DevolverVerdaderoSiNumeroArgumentosIgualAlEsperado()
    {
      var argumentos = new Argumentos(new string[] { "un argumento" });
      Assert.IsTrue(argumentos.ValidarNumArgumentos(1));
    }

    [Test]
    public void DevolverExcepcionSiNumeroArgumentosDistintoAlEsperado() {
      var argumentos = new Argumentos(new string[] { "un argumento" });
      var exception = Assert.Throws<ArgumentException>(() => argumentos.ValidarNumArgumentos(2));
      Assert.That(exception, Has.Message.EqualTo("número de argumentos incorrecto"));
    }
  }
}
