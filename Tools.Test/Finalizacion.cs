
namespace Tools.Prod
{
  public class Finalizacion
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
