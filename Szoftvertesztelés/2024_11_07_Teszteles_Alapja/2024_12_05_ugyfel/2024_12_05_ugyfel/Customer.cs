using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_05_ugyfel
{
    internal class Customer
    {
        string FirstName, Lastname, Email;
        int BirthDate;


        public int GetAge()
        {
            string todaydate = "2024.12.05";
            string[] std = todaydate.Split('.');
            int datev = Convert.ToInt32(std[0]);
            int dathonap = Convert.ToInt32(std[1]);
            int datnap = Convert.ToInt32(std[2]);

            string[] st = BirthDate.ToString().Split('.');
            int szulev = Convert.ToInt32(st[0]);
            int szulhonap = Convert.ToInt32(st[1]);
            int szulnap = Convert.ToInt32(st[2]);

            if(datnap-szulnap < 0 &&dathonap-szulhonap <= 0)
            {
                datev--;
                return datev-szulev;
            }
            else
            {
                return datev-szulev;
            }


            
        
        
        }

        public bool IsEmailValid()
        {


            if (Email.Contains('@'))
            {
                
                string[] st = Email.Split('@');
                
                if (st[1].Contains('.') && st.Length<3)
                {
                   
                    if (st[1].Contains('0') || st[1].Contains('1') || st[1].Contains('2') || st[1].Contains('3') || st[1].Contains('4') || st[1].Contains('5') || st[1].Contains('6') || st[1].Contains('7') || st[1].Contains('8') || st[1].Contains('9'))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else { return false; }
                
            }
            else
            {
                return false;
            }
            
        }
        public string GetFullName()
        {
            return FirstName + " " + Lastname;
        }


    }
    
}
