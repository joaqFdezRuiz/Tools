
namespace Tools.Prod.Finalizacion
{
  public class Finalizacion : Tools.Prod.Finalizacion.IFinalizacion
  {
    private const int CORRECTO = 0;
    private const int ERROR = -1;

    public int Correcto
    {
      get { return CORRECTO  ; }
    }

    public object Error
    {
      get { return ERROR; }
    }
  }
}
