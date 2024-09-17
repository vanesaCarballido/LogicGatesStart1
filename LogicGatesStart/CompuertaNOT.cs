namespace LogicGatesStart;

public class CompuertaNOT: IValorVerdad
{
    private string nombre;
    private IValorVerdad entrada;
    private List<IValorVerdad> entradas = new List<IValorVerdad>();
    public CompuertaNOT(string nombre, IValorVerdad entrada1)
    {
        this.nombre = nombre;
        this.entradas.Add(entrada1);
    }

    public bool Evaluar
    {
        get
        {
            return !this.entrada.Evaluar;
        }
    }
    
}