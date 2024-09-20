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
        IValorVerdad entradaEsperada = ValorVerdadero.Instance;

        CompuertaAND and1 = new CompuertaAND("And1", ValorVerdadero.Instance);
        
        Assert.That(nombreEsperado, Is.EqualTo(and1.GetNombre()));
        Assert.That(entradaEsperada, Is.EqualTo(and1.GetEntradas()[0]));
    }

    [Test]
    public void TestVerdaderoANDVerdadero()
    {
        bool resultadoEsperado = true;

        CompuertaAND and1 = new CompuertaAND("And1", ValorVerdadero.Instance);
        and1.AgregarEntrada(ValorVerdadero.Instance);

        Assert.That(resultadoEsperado, Is.EqualTo(and1.Evaluar));
    }
    
    [Test]
    public void TestVerdaderoANDFalso()
    {
        bool resultadoEsperado = false;

        CompuertaAND and1 = new CompuertaAND("And1", ValorVerdadero.Instance);
        and1.AgregarEntrada(ValorFalso.Instance);

        Assert.That(resultadoEsperado, Is.EqualTo(and1.Evaluar));
    }
    
    [Test]
    public void TestFalsoANDVerdadero()
    {
        bool resultadoEsperado = false;

        CompuertaAND and1 = new CompuertaAND("And1", ValorFalso.Instance);
        and1.AgregarEntrada(ValorVerdadero.Instance);

        Assert.That(resultadoEsperado, Is.EqualTo(and1.Evaluar));
    }
    
    [Test]
    public void TestFalsoANDFalso()
    {
        bool resultadoEsperado = false;

        CompuertaAND and1 = new CompuertaAND("And1", ValorFalso.Instance);
        and1.AgregarEntrada(ValorFalso.Instance);

        Assert.That(resultadoEsperado, Is.EqualTo(and1.Evaluar));
    }
}