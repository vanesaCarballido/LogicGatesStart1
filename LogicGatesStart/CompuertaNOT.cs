namespace LogicGatesStart;

public class CompuertaNOT: IValorVerdad
{
    private string nombre;
    private IValorVerdad entrada;
    public CompuertaNOT(string nombre, IValorVerdad entrada)
    {
        this.nombre = nombre;
        this.entrada = entrada;
    }
    public string GetNombre()
    {
        return this.nombre;
    }
    public IValorVerdad GetEntrada()
    {
        return this.entrada;
    }
    public bool Evaluar
    {
        get
        {
            return !this.entrada.Evaluar;
        }
    }
}