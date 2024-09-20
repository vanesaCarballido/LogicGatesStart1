using LogicGatesStart;


public class Program
{
    public static void Main()
    {
        //Crear compuerta OR y agregar entradas
        CompuertaOR or1 = new CompuertaOR("OR1", LogicaFalso.Instance);
        or1.AgregarEntrada(LogicaVerdadero.Instance);
        or1.AgregarEntrada(LogicaVerdadero.Instance);
        
        //Evaluar salida inicial del circuito
        Console.WriteLine($"Resultado inicial con compuerta {or1.GetNombre()} es: {or1.Evaluar}");
        
        //crear compuerta AND y agregar entradas
        CompuertaAND and1 = new CompuertaAND("AND1", or1);
        and1.AgregarEntrada(LogicaFalso.Instance);
        
        //Evaluar salida parcial del circuito
        Console.WriteLine($"Resultado parcial con compuerta {and1.GetNombre()} es: {and1.Evaluar}");
        
        //crear compuerta NOT
        CompuertaNOT not1 = new CompuertaNOT("NOT1", and1);
        
        //Evaluar salida final del circuito
        Console.Write($"Resultado final con compuerta {not1.GetNombre()} es: {not1.Evaluar}");
    }
    
}