using System;
using System.Collections.Generic;
using System.Text;
using Domowy_budzet.Classes.BuisnessLogic;

namespace Domowy_budzet.Classes
{
    class UserStorage : XmlStorage<UserStorage>
    {
        public List<User> users;
        public override bool InitializeFromObject(UserStorage Object)
        {
            throw new NotImplementedException();
        }
    }
}
