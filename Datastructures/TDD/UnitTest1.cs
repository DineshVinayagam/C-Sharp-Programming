namespace TDD;
[TestFixture]
public class Tests
{
    Maths operation=null;
    [SetUp]

    public void Setup()
    {
        operation=new Maths();
    }

    [Test]
    public void Test1()
    {
        dynamic result=operation.Addition(10,10);
        Assert.That(result,Is.EqualTo(20));
    }
    [TestCase(1,2,3)]
    [TestCase(10,30,40)]
    public void IsAdditionOk(int value1,int value2,int result)
    {
       int output=operation.Addition(value1,value2);
       Assert.AreEqual(output,result);
    }
    [TestCase(1.2,2.1,3.3)]
    public void IsAdditionOk(double value1,double value2,double result)
    {
       double output=operation.Addition(value1,value2);
       Assert.AreEqual(output,result);
    }
    [TestCase("ravi","chandran","ravichandran")]
    public void IsAdditionOk(string value1,string value2,string result)
    {
        string output=operation.Addition(value1,value2);
        Assert.AreEqual(output,result);
    }
}