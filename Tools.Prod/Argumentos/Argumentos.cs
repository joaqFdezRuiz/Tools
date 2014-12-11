using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools.Prod.Argumentos
{
  public class Argumentos
  {
    private string[] args;

    public Argumentos(string[] args)
    {
      this.args = args;
    }



    public bool ValidarNumArgumentos(int numArgsEsperado)
    {
      return true;
    }
  }
}
