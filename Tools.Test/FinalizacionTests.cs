using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tools.Test
{
  [TestFixture]
  class FinalizacionTests
  {
    [Test]
    public void DevolverCeroSiFinalizacionCorrecta() {
      Tools.Prod.Finalizacion finalizacion = new Tools.Prod.Finalizacion();
      Assert.AreEqual(0, finalizacion.Correcto);
    }
  }
}
