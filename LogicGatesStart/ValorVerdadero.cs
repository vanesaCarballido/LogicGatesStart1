namespace LogicGatesStart;

public class ValorVerdadero: IValorVerdad
{
    private ValorVerdadero()
    {
        
    }
    public static IValorVerdad Instance { get; } = new ValorVerdadero();
    public bool Evaluar
    {
        get
        {
            return true;
        }
    }
}