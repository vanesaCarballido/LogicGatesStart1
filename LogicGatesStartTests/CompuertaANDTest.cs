using LogicGatesStart;
using NUnit.Framework;

namespace LogicGatesStartTests;

[TestFixture]
[TestOf(typeof(CompuertaAND))]
public class CompuertaANDTest
{

    [Test]
    public void METHOD()
    {
        
    }
    
    [Test]
    public void TestCrearCompuertaAND()
    {
        string nombreEsperado = "And1";
        IValorVerdad entradaEsperada = LogicaVerdadero.Instance;

        CompuertaAND and1 = new CompuertaAND("And1", LogicaVerdadero.Instance);
        
        Assert.That(nombreEsperado, Is.EqualTo(and1.GetNombre()));
        Assert.That(entradaEsperada, Is.EqualTo(and1.GetEntradas()[0]));
    }

    [Test]
    public void TestVerdaderoANDVerdadero()
    {
        bool resultadoEsperado = true;

        CompuertaAND and1 = new CompuertaAND("And1", LogicaVerdadero.Instance);
        and1.AgregarEntrada(LogicaVerdadero.Instance);

        Assert.That(resultadoEsperado, Is.EqualTo(and1.Evaluar));
    }
    
    [Test]
    public void TestVerdaderoANDFalso()
    {
        bool resultadoEsperado = false;

        CompuertaAND and1 = new CompuertaAND("And1", LogicaVerdadero.Instance);
        and1.AgregarEntrada(LogicaFalso.Instance);

        Assert.That(resultadoEsperado, Is.EqualTo(and1.Evaluar));
    }
    
    [Test]
    public void TestFalsoANDVerdadero()
    {
        bool resultadoEsperado = false;

        CompuertaAND and1 = new CompuertaAND("And1", LogicaFalso.Instance);
        and1.AgregarEntrada(LogicaVerdadero.Instance);

        Assert.That(resultadoEsperado, Is.EqualTo(and1.Evaluar));
    }
    
    [Test]
    public void TestFalsoANDFalso()
    {
        bool resultadoEsperado = false;

        CompuertaAND and1 = new CompuertaAND("And1", LogicaFalso.Instance);
        and1.AgregarEntrada(LogicaFalso.Instance);

        Assert.That(resultadoEsperado, Is.EqualTo(and1.Evaluar));
    }
}