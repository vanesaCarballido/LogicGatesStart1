namespace LogicGatesStart;

public class LogicaVerdadero: IValorVerdad
{
    private LogicaVerdadero()
    {
        
    }

    public static IValorVerdad Instance { get; } = new LogicaVerdadero();
    public bool Evaluar
    {
        get
        {
            return true;
        }
    }
}