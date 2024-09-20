using LogicGatesStart;
using NUnit.Framework;

namespace LogicGatesStartTests;

[TestFixture]
[TestOf(typeof(CompuertaOR))]
public class CompuertaORTest
{

    [Test]
    public void METHOD()
    {
        
    }
    
    [Test]
    public void TestCrearCompuertaOR()
    {
        string nombreEsperado = "Or1";
        IValorVerdad entradaEsperada = ValorVerdadero.Instance;

        CompuertaOR or1 = new CompuertaOR("Or1", ValorVerdadero.Instance);
        
        Assert.That(nombreEsperado, Is.EqualTo(or1.GetNombre()));
        Assert.That(entradaEsperada, Is.EqualTo(or1.GetEntradas()[0]));
    }

    [Test]
    public void TestVerdaderoORVerdadero()
    {
        bool resultadoEsperado = true;

        CompuertaOR or1 = new CompuertaOR("Or1", ValorVerdadero.Instance);
        or1.AgregarEntrada(ValorVerdadero.Instance);

        Assert.That(resultadoEsperado, Is.EqualTo(or1.Evaluar));
    }
    
    [Test]
    public void TestVerdaderoORFalso()
    {
        bool resultadoEsperado = true;

        CompuertaOR or1 = new CompuertaOR("Or1", ValorVerdadero.Instance);
        or1.AgregarEntrada(ValorFalso.Instance);

        Assert.That(resultadoEsperado, Is.EqualTo(or1.Evaluar));
    }
    
    [Test]
    public void TestFalsoORVerdadero()
    {
        bool resultadoEsperado = true;

        CompuertaOR or1 = new CompuertaOR("Or1", ValorFalso.Instance);
        or1.AgregarEntrada(ValorVerdadero.Instance);

        Assert.That(resultadoEsperado, Is.EqualTo(or1.Evaluar));
    }
    
    [Test]
    public void TestFalsoORFalso()
    {
        bool resultadoEsperado = false;

        CompuertaOR or1 = new CompuertaOR("Or1", ValorFalso.Instance);
        or1.AgregarEntrada(ValorFalso.Instance);

        Assert.That(resultadoEsperado, Is.EqualTo(or1.Evaluar));
    }
}