using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ConsoleApp2
{
    public class VendorMachine
    {
        public decimal CalculateTotalPrice(int countNickels,int countDims,int countQuarters)
        {
            return (Constants.nickels * countNickels) + (Constants.dimes * countDims) + (Constants.quarter * countQuarters);
        }

        public string FindTypeofCoin(decimal weight, decimal size)
        {
            if ((weight <= Constants.maxWeightNickels || weight >= Constants.minWeightNickels) && size == Constants.sizeNickels)
            {
                return "Nickels";
            }
            else if ((weight <= Constants.maxWeightdimes || weight >= Constants.minWeightdimes) && size == Constants.sizeDimes)
            {
                return "Dimes";
            }
            else if ((weight <= Constants.maxWeightquater || weight >= Constants.minWeightquarter) && size == Constants.sizeQuater)
            {
                return "Quater";
            }
            else
            {
                return "Pinnes";
            }
        }

        public string InsertCoin(decimal weight,decimal size,ref int countofNickels,ref int countofDims,ref int countofQuater,ref decimal Totalamount){

            string coin=FindTypeofCoin(weight,size);
            if(coin=="Pinnes"){
                return "INSERT COIN";
            }

            if(coin=="Nickels"){
                countofNickels++;
            }
            else if(coin=="Dimes"){
                countofDims++;
            }
            else if(coin =="Quater"){
                countofQuater++;
            }
            
            Totalamount=CalculateTotalPrice(countofNickels,countofDims,countofQuater);
            return "Total Amount is "+Totalamount;
        }
    }
}
