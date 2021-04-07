using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Domowy_budzet.Interfaces;

namespace Domowy_budzet.Classes.BuisnessLogic
{
    
    public class User :IData
    {
        private int id;
        private string login;
        private string password;
        private string name;
        private string surname;

        public int _id { get => id; set => id = value; }
        public string _login { get; set; }
        public string _password { get; set; }
        public string _name { get; set; }
        public string _surname { get; set; }

        public User()
        {

        }

        public User(int Id, string Login, string Password, string Name, string Surname)
        {
            this.id = Id;
            this.login = Login;
            this.password = Password;
            this.name = Name;
            this.surname = Surname;

        }
        public void DisplayData()
        {
            throw new NotImplementedException();
        }

        public void EditUser() 
        { 
            throw new NotImplementedException(); 

        }

        public void AddUser()
        {
            throw new NotImplementedException();

        }

     


    }


}
