using System;
namespace Tools.Prod.Finalizacion
{
  public interface IFinalizacion
  {
    int Correcto { get; }
    object Error { get; }
  }
}
