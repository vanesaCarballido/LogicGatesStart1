namespace LogicGatesStart;

public class LogicaFalso: IValorVerdad
{
    private LogicaFalso()
    {
        
    }

    public static IValorVerdad Instance { get; } = new LogicaFalso();
    public bool Evaluar
    {
        get
        {
            return false;
        }
    }
}