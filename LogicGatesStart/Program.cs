namespace LogicGatesStart;


public class Program
{
    public static void Main()
    {
        //crear compuerta OR
        CompuertaOR or1 = new CompuertaOR("OR1", LogicaFalso.Instance);
        or1.AgregarEntrada(LogicaVerdadero.Instance);
        or1.AgregarEntrada(LogicaVerdadero.Instance);
        Console.WriteLine($"Resultado inicial con compuerta {or1.GetNombre()} es: {or1.Evaluar}");
        
        //crear compuerta AND
        CompuertaAND and1 = new CompuertaAND("AND1", or1);
        and1.AgregarEntrada(LogicaFalso.Instance);
        Console.WriteLine($"Resultado intermedio con compuerta {and1.GetNombre()} es: {and1.Evaluar}");
        
        //crear compuerta NOT
        CompuertaNOT not1 = new CompuertaNOT("NOT1", and1);
        Console.Write($"Resultado final con compuerta {not1.GetNombre()} es: {not1.Evaluar}");
    }
    
}