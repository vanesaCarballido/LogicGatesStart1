namespace LogicGatesStart;

public class ValorFalso: IValorVerdad
{
    private ValorFalso()
    {
        
    }

    public static IValorVerdad Instance { get; } = new ValorFalso();
    public bool Evaluar
    {
        get
        {
            return false;
        }
    }
}