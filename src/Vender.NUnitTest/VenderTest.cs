using NUnit.Framework;
using ConsoleApp2;

namespace Vender.NUnitTest
{
    public class VenderTest{

        [Test]
        public void CalculateTotalPriceTest(){
            VendorMachine objVendor=new VendorMachine();
            Assert.AreEqual(0.4M,objVendor.CalculateTotalPrice(1,1,1));
        }

        [Test]
        public void NickelsFindofCoinTest(){
            VendorMachine objVendor=new VendorMachine();
            Assert.AreEqual("Nickels",objVendor.FindTypeofCoin(0.7M,2));
        }

        [Test]
        public void DimesFindofCoinTest(){
            VendorMachine objVendor=new VendorMachine();
            Assert.AreEqual("Dimes",objVendor.FindTypeofCoin(0.4M,1));
        }

        [Test]
        public void QuaterFindofCoinTest(){
            VendorMachine objVendor=new VendorMachine();
            Assert.AreEqual("Quater",objVendor.FindTypeofCoin(2.1M,5));
        }

        [Test]
        public void PinnesFindofCoinTest(){
            VendorMachine objVendor=new VendorMachine();
            Assert.AreEqual("Pinnes",objVendor.FindTypeofCoin(0.1M,8));
        }

        [Test]
        public void InsertCoin(){
            VendorMachine objVendor=new VendorMachine();
            int countofNickels=0;
            int countofQuater=0;
            int countofDims=0;
            decimal totalAmount=0;
            Assert.AreEqual("Total Amount is 0.10",objVendor.InsertCoin(0.7M,2,ref countofDims,ref countofNickels,ref countofQuater,ref totalAmount));
        }
    }
}