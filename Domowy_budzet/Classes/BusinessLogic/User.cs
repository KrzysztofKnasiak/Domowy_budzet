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
        public string _login
        {
            get => login;
            set
            {
                if (value.Length > 20 || value.Length == 0)
                {
                    throw new Exception("Nieodpowiednia długość parametru. (Max - 20)");
                }
                else login = value;
            }
        }
        public string _password 
        { get => password;
            set
            {
                if(value.Length > 20 || value.Length == 0)
                {
                    throw new Exception("Nieodpowiednia długość parametru. (Max - 20)");
                }
                else  password = value;
            }
        }


        public string _name
        {
            get => name;
            set
            {
                bool isnum = false;
                foreach (char c in value)
                {
                    if (char.IsNumber(c))
                        isnum = true;
                }

                if (value.Length > 15 || value.Length == 0)
                {
                    throw new Exception("Nieodpowiednia długośc parametru. (Max - 15)");
                }
                
                   
               else if(isnum == true)
                {
                    throw new Exception("Parametr nie może zawierać liczb.");
                }
                           
               else name = value;
            }
        }
        public string _surname
        {
            get => surname;
            set
            {
                bool isnum = false;
                foreach (char c in value)
                {
                    if (char.IsNumber(c))
                        isnum = true;
                }

                if (value.Length > 20 || value.Length == 0)
                {
                    throw new Exception("Nieodpowiednia długośc parametru. (Max - 20)");
                }

                else if (isnum == true)
                {
                    throw new Exception("Parametr nie może zawierać liczb.");
                }

                else surname = value;
            }
        }

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
