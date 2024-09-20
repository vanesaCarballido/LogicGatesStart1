namespace LogicGatesStart;

public class CompuertaAND: IValorVerdad
{
    private string nombre;
    private List<IValorVerdad> entradas = new List<IValorVerdad>();
    public CompuertaAND(string nombre, IValorVerdad entrada1)
    {
        this.nombre = nombre;
        this.entradas.Add(entrada1);
    }

    public string GetNombre()
    {
        return this.nombre;
    }

    public List<IValorVerdad> GetEntradas()
    {
        return this.entradas;
    }
    public void AgregarEntrada(IValorVerdad entrada)
    {
        this.entradas.Add(entrada);
    }
    public bool Evaluar
    {
        get
        {
            bool resultado = this.entradas[0].Evaluar;
            for (int i = 1; i < this.entradas.Count; i++)
            {
                resultado = resultado && this.entradas[i].Evaluar;
            }

            return resultado;
        }
    }

}