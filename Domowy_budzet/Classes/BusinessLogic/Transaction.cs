using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Domowy_budzet.Interfaces;

namespace Domowy_budzet.Classes.BuisnessLogic
{
    public class Transaction : IData
    {    

        private int id;
        private double amount;
        private string title;
        private string description;
        private DateTime date;
        private char category;

        public int _id { get => id; set => id = value; }
        public double _amount
        {
            get => amount;
            set
            {
                string x = value.ToString();

                bool isnum = false;
                foreach (char c in x)
                {
                    if (!char.IsNumber(c))
                        isnum = true;
                }
                if (value > 1000000) 
                {
                    throw new Exception("Zbyt duża wartość parametru.(Max - 1000000)");
                }

                else if (isnum == true)
                {
                    throw new Exception("Parametr nie może zawierać liter.");
                }

                else amount = value;
            }
        }
        public string _title
        {
            get => title;
            set
            {
                if (value.Length > 30 || value.Length == 0)
                {
                    throw new Exception("Nieodpowiednia długośc parametru.(Max - 30)");
                }
                else title = value;
            }
        }
        public string _description
        {
            get => description;
            set
            {
                if (value.Length > 60 || value.Length == 0)
                {
                    throw new Exception("Nieodpowiednia długośc parametru. (Max - 60)");
                }
                else description = value;
            }
        }
        public DateTime _date
        {
            get => date;
            set
            {
                date = DateTime.Now;
            }
        }



        public char _category
        {
            get => category;
            set
            {
                if (value > 9 || value < 1)
                {
                    throw new Exception("Wartość poza przedziałem (1-9)");
                }
                else category = value;
            }
        }

        public Transaction()
        {

        }

        public Transaction(int Id, double Amount, string Title, string Description, DateTime Date, char Category )
        {
            this.id = Id;
            this.amount = Amount;
            this.title = Title;
            this.description = Description;
            this.date = Date;
            this.category = Category;

        }


        public void DisplayData()
        {
            throw new NotImplementedException();
        }

        public void AddTransaction()
        {
            throw new NotImplementedException();

        }

        public void EditTransaction()
        {
            throw new NotImplementedException();

        }

        public void DeleteTransaction()
        {
            throw new NotImplementedException();

        }

    }
}
