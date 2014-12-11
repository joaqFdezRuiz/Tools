using System;

namespace Tools.Prod.Argumentos
{
  public class Argumentos : Tools.Prod.Argumentos.IArgumentos
  {
    private string[] args;

    public Argumentos(string[] args)
    {
      this.args = args;
    }

    public bool ValidarNumArgumentos(int numArgsEsperado)
    {
      if (args.Length == numArgsEsperado)
        return true;
      throw new ArgumentException("número de argumentos incorrecto");
    }
  }
}
