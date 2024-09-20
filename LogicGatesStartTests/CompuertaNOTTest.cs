using LogicGatesStart;
using NUnit.Framework;

namespace LogicGatesStartTests;

[TestFixture]
[TestOf(typeof(CompuertaNOT))]
public class CompuertaNOTTest
{

    [Test]
    public void METHOD()
    {
        
    }
    
    [Test]
    public void TestCrearCompuertaNOT()
    {
        string nombreEsperado = "Not1";
        IValorVerdad entradaEsperada = LogicaVerdadero.Instance;

        CompuertaNOT not1 = new CompuertaNOT("Not1", LogicaVerdadero.Instance);
        
        Assert.That(nombreEsperado, Is.EqualTo(not1.GetNombre()));
        Assert.That(entradaEsperada, Is.EqualTo(not1.GetEntrada()));
    }

    [Test]
    public void TestNOTVerdadero()
    {
        bool resultadoEsperado = false;

        CompuertaNOT not1 = new CompuertaNOT("Not1", LogicaVerdadero.Instance);
        
        Assert.That(resultadoEsperado, Is.EqualTo(not1.Evaluar));
    }

    [Test]
    public void TestNOTFalso()
    {
        bool resultadoEsperado = true;

        CompuertaNOT not1 = new CompuertaNOT("Not1", LogicaFalso.Instance);
        
        Assert.That(resultadoEsperado, Is.EqualTo(not1.Evaluar));
    }
}