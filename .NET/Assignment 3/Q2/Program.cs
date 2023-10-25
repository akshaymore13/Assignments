using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class Program
    {
        private String name;
        private int id;
        private int balance;
        static int getid = 123678;

        public Program(String name)
        {
            this.name = name;
            id = ++getid;
            balance = 0;
        }
        public void deposite(int amount)
        {
            
                if (amount != 0)

                    balance += amount;

                else
                {
                    Console.WriteLine("invalid amount");
                }
            }

         public void widraw( int Amount)
            {

                
                    if (Amount != 0 && balance != 0)
                        balance -= Amount;
               else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }

            public void display()
            { 
                Console.WriteLine($"Name:{name} Balance:{balance} ID:{id}");
            }

          
        }
    }


