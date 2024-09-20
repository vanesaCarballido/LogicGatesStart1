namespace LogicGatesStart;

public class CompuertaNOT: IValorVerdad
{
    private string nombre;
    private IValorVerdad entrada;
    public CompuertaNOT(string nombre, IValorVerdad entrada1)
    {
        this.nombre = nombre;
        this.entrada = entrada1;
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