using NUnit.Framework;
namespace MatrixUnitTest;

public class Tests
{
    private Matrix.Matrix _testMatrix1;
    private Matrix.Matrix _testMatrix2;
    [SetUp]
    public void Setup()
    {
        List<double> m1 = new List<double>(){1, 2};
        List<double> m2 = new List<double>() { 2, 1 };
        List<double> m3 = new List<double>() { 3, 2 };
        List<List<double>> m = new List<List<double>>() { m1, m2 };
        List<List<double>> m4 = new List<List<double>>() { m1, m3 };
        _testMatrix1 = new Matrix.Matrix(m);
        _testMatrix2 = new Matrix.Matrix(m4);
    }
    
    [Test]
    public void Test1()
    {
        Setup();
        Assert.AreEqual(true, _testMatrix1.CheckSymmetricMatrix());
    }
    
    [Test]
    public void Test2()
    {
        Setup();
        Assert.AreEqual(false, _testMatrix2.CheckSymmetricMatrix());
    }
}