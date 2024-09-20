namespace LogicGatesStart;

public class GarageGate: IValorVerdad
{
    private IValorVerdad a;
    private IValorVerdad b;
    private IValorVerdad c;

    public GarageGate(IValorVerdad c, IValorVerdad a, IValorVerdad b)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public bool Evaluar
    {
        get
        {
            CompuertaAND and1 = new CompuertaAND("and1", this.a);
            and1.AgregarEntrada(this.b);
            
            CompuertaNOT a = new CompuertaNOT("A negado", this.a);
            CompuertaNOT b = new CompuertaNOT("B negado", this.b);
            
            CompuertaAND and2 = new CompuertaAND("and2",a);
            and2.AgregarEntrada(b);

            CompuertaOR or = new CompuertaOR("or", and1);
            or.AgregarEntrada(and2);

            CompuertaAND andFinal = new CompuertaAND("and final", or);
            andFinal.AgregarEntrada(this.c);

            return andFinal.Evaluar;
        }
    }
}