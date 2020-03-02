using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWar.Problems;

namespace CodeWar.TestTools
{
    [TestClass]

    public class CodeWarTests
    {
        [TestMethod]

        public void IsNumber1_Int_True()
        {
        Problem1 testProblem = new Problem1 (5, 5);
        Assert.AreEqual(true, testProblem.Number1 is int);
        }

        [TestMethod]

        public void IsNumber2_Int_True()
        {
        Problem1 testProblem = new Problem1 (5, 6);
        Assert.AreEqual(true, testProblem.Number2 is int);
        }

        [TestMethod]

        public void IsReturnSum_SumOfNums_Sum()
        {
        Problem1 testProblem = new Problem1 (5, 6);
        Assert.AreEqual(11, testProblem.ReturnSum());
        }

        [TestMethod]

        public void IsReturnNextNum_NextNum_Number()
        {
        Problem2 testProblem2 = new Problem2(7);
        Assert.AreEqual(8, testProblem2.GetNextNum());
        }

        [TestMethod]

        public void IsAreaOfTriangle_CalcArea_Area()
        {
        Triangle testTriangle = new Triangle(9, 9, 9);
        Assert.AreEqual(40, testTriangle.AreaOfTriangle());
        }

        [TestMethod]

        public void IsGetRemainder_CalcRemainder_Remainder()
        {
        Problem1 testRemainder = new Problem1(10, 3);
        Assert.AreEqual(1, testRemainder.GetRemainder());
        }

        [TestMethod]

        public void IsFlipTheBool_FlippingTheBool_False()
        {
        Bools testingTheBool = new Bools(true);
        Assert.AreEqual(false, testingTheBool.FlipTheBool());
        }

        [TestMethod]

        public void IsFlipTheBool_FlippingTheBool_True()
        {
        Bools testingTheBool = new Bools(false);
        Assert.AreEqual(true, testingTheBool.FlipTheBool());
        }

        [TestMethod]

        public void IsIsDivisible_DividingBy5_True()
        {
        Divisible testDivisible = new Divisible(15);
        Assert.AreEqual(true, testDivisible.IsDivisible());
        }

    }
}