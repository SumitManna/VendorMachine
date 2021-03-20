using NUnit.Framework;
using ConsoleApp2;

namespace Vender.NUnitTest
{
    public class ProductTest{

        [Test]
        public void COLANegative(){
            Product objProduct=new Product();
            int prodCount=0;
            decimal remainingamount=0.0M;
            Assert.AreEqual("PRICE",objProduct.DispenseProduct("COLA",.75M,ref prodCount,ref remainingamount));
        }

        [Test]
        public void COLAPositive(){
            Product objProduct=new Product();
            int prodCount=0;
            decimal remainingamount=0.0M;
            Assert.AreEqual("Thank You",objProduct.DispenseProduct("COLA",2.75M,ref prodCount,ref remainingamount));
        }

        [Test]
        public void CHIPSNegative(){
            Product objProduct=new Product();
            int prodCount=0;
            decimal remainingamount=0.0M;
            Assert.AreEqual("PRICE",objProduct.DispenseProduct("CHIPS",0.25M,ref prodCount,ref remainingamount));
        }

        [Test]
        public void CHIPSPositive(){
            Product objProduct=new Product();
            int prodCount=0;
            decimal remainingamount=0.0M;
            Assert.AreEqual("Thank You",objProduct.DispenseProduct("CHIPS",1.50M,ref prodCount,ref remainingamount));
        }

        [Test]
        public void CANDYNegative(){
            Product objProduct=new Product();
            int prodCount=0;
            decimal remainingamount=0.0M;
            Assert.AreEqual("PRICE",objProduct.DispenseProduct("CANDY",0.50M,ref prodCount,ref remainingamount));
        }

        [Test]
        public void CANDYPositive(){
            Product objProduct=new Product();
            int prodCount=0;
            decimal remainingamount=0.0M;
            Assert.AreEqual("Thank You",objProduct.DispenseProduct("CANDY",2.75M,ref prodCount,ref remainingamount));
        }
    }
}