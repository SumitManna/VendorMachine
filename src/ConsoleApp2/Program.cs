using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
            decimal Totalamount=0;
            StartProcess(ref Totalamount);
        }

        public static void StartProcess(ref decimal Totalamount){
            int countofNickels=0;
            int countofDims=0;
            int countofQuater=0;

            InsertingCoin(ref countofNickels,ref countofDims,ref countofQuater,ref Totalamount);
            Console.WriteLine("Please enter Product Name (Cola/Chips/Candy)");
            string prodName=Convert.ToString(Console.ReadLine());
            int prodCount=0;
            decimal remainingamount=0;
            Product objProd=new Product();

            string MessageProd=objProd.DispenseProduct(prodName,Totalamount,ref prodCount,ref remainingamount);
            Console.WriteLine(MessageProd);
            if(prodCount<0){
                Console.WriteLine("Current Amount "+remainingamount);
            }
            if(remainingamount==0){
                Totalamount=0;
                StartProcess(ref Totalamount);
            }
            if(remainingamount>0){
                Console.WriteLine("Current Amount "+remainingamount);
                Totalamount=remainingamount;
                StartProcess(ref Totalamount);
            }
	        Console.ReadLine();
        }

        public static void InsertingCoin(ref int countofNickels,ref int countofDims,ref int countofQuater,ref decimal Totalamount)
        {
            
            while(true)
            {
            Console.WriteLine("Please insert coin");
            Console.WriteLine("Please give weight of the coin (Nickels(0.6-1.0),Dimes(0.3-0.5),Quater(1.5-2.5))");

            decimal weight=Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please give size of the coin (Nickels(2),Dimes(1),Quater(5))");

            decimal size=Convert.ToDecimal(Console.ReadLine());
            VendorMachine objVender=new VendorMachine();
            string Message=objVender.InsertCoin(weight,size,ref countofNickels,ref countofDims,ref countofQuater,ref Totalamount);
            Console.WriteLine(Message);

            Console.WriteLine("Do you want to add more coin? Y/N");
            string checkingWithUser=Convert.ToString(Console.ReadLine());
                if(checkingWithUser.ToUpper()=="N"){
                    break;
                }
            }
        }
    }
}
