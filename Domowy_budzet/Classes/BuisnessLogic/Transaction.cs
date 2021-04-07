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
        private string category;

        public int _id { get => id; set => id = value; }
        public double _amount { get; set; }
        public string _title { get; set; }
        public string _description { get; set; }
        public DateTime _date { get; set; }
        public string _category { get; set; }

        public Transaction()
        {

        }

        public Transaction(int Id, double Amount, string Title, string Description, DateTime Date, string Category )
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
