using LogicGatesStart;
using NUnit.Framework;

namespace LogicGatesStartTests;

[TestFixture]
[TestOf(typeof(GarageGate))]
public class GarageGateTest
{
    [Test]
    public void METHOD()
    {

    }

    [Test]
    public void TestCaso1NoAbre() // C = 0, A = 0, B = 0
    {
        bool resultadoEsperado = false;

        GarageGate caso1 = new GarageGate(ValorFalso.Instance, ValorFalso.Instance, ValorFalso.Instance);

        Assert.That(resultadoEsperado, Is.EqualTo(caso1.Evaluar));
    }

    [Test]
    public void TestCaso2NoAbre() // C = 0, A = 0, B = 1
    {
        bool resultadoEsperado = false;

        GarageGate caso2 = new GarageGate(ValorFalso.Instance, ValorFalso.Instance, ValorVerdadero.Instance);
        
        Assert.That(resultadoEsperado, Is.EqualTo(caso2.Evaluar));
    }

    [Test]
    public void TestCaso3NoAbre() // C = 0, A = 1, B = 0
    {
        bool resultadoEsperado = false;

        GarageGate caso3 = new GarageGate(ValorFalso.Instance, ValorVerdadero.Instance, ValorFalso.Instance);
        
        Assert.That(resultadoEsperado, Is.EqualTo(caso3.Evaluar));
    }

    [Test]
    public void TestCaso4NoAbre() // C = 0, A = 1, B = 1
    {
        bool resultadoEsperado = false;

        GarageGate caso4 = new GarageGate(ValorFalso.Instance, ValorVerdadero.Instance, ValorVerdadero.Instance);
        
        Assert.That(resultadoEsperado, Is.EqualTo(caso4.Evaluar));
    }

    [Test]
    public void TestCaso5Abre() // C = 1, A = 0, B = 0
    {
        bool resultadoEsperado = true;

        GarageGate caso5 = new GarageGate(ValorVerdadero.Instance, ValorFalso.Instance, ValorFalso.Instance);
        
        Assert.That(resultadoEsperado, Is.EqualTo(caso5.Evaluar));
    }

    [Test]
    public void TestCaso6NoAbre() // C = 1, A = 0, B = 1
    {
        bool resultadoEsperado = false;

        GarageGate caso6 = new GarageGate(ValorVerdadero.Instance, ValorFalso.Instance, ValorVerdadero.Instance);
        
        Assert.That(resultadoEsperado, Is.EqualTo(caso6.Evaluar));
    }

    [Test]
    public void TestCaso7NoAbre() // C = 1, A = 1, B = 0
    {
        bool resultadoEsperado = false;

        GarageGate caso7 = new GarageGate(ValorVerdadero.Instance, ValorVerdadero.Instance, ValorFalso.Instance);
        
        Assert.That(resultadoEsperado, Is.EqualTo(caso7.Evaluar));
    }

    [Test]
    public void TestCaso8Abre() // C = 1, A = 1, B = 1
    {
        bool resultadoEsperado = true;

        GarageGate caso8 = new GarageGate(ValorVerdadero.Instance, ValorVerdadero.Instance, ValorVerdadero.Instance);
        
        Assert.That(resultadoEsperado, Is.EqualTo(caso8.Evaluar));
    }

}