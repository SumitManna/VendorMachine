using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ConsoleApp2
{
    public class Product
    {
        public string DispenseProduct(string prodName,decimal totalAmount,ref int prodCount,ref decimal remainingamount){
            if(prodName.ToUpper()=="COLA")
            {
                prodCount=Convert.ToInt32(Math.Truncate(totalAmount/Constants.colaCost));
                remainingamount=totalAmount-(prodCount*Constants.colaCost);
                if(prodCount>0){
                    return "Thank You";
                }
                else{
                    return "PRICE";
                }
            }
            else if(prodName.ToUpper()=="CHIPS")
            {
                prodCount=Convert.ToInt32(Math.Truncate(totalAmount/Constants.chipsCost));
                remainingamount=totalAmount-(prodCount*Constants.chipsCost);
                if(prodCount>0){
                    return "Thank You";
                }
                else{
                    return "PRICE";
                }
            }
            else if(prodName.ToUpper()=="CANDY")
            {
                prodCount=Convert.ToInt32(Math.Truncate(totalAmount/Constants.candyCost));
                remainingamount=totalAmount-(prodCount*Constants.candyCost);
                if(prodCount>0){
                    return "Thank You";
                }
                else{
                    return "PRICE";
                }
            }
            else{
                return "Invalid Product";
            }
        }

    }
}