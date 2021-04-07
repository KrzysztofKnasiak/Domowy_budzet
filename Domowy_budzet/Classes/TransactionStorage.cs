using System;
using System.Collections.Generic;
using System.Text;
using Domowy_budzet.Classes.BuisnessLogic;

namespace Domowy_budzet.Classes
{
    class TransactionStorage : XmlStorage<TransactionStorage>
    {

        public List<Transaction> transactions;

        public override bool InitializeFromObject(TransactionStorage Object)
        {
            throw new NotImplementedException();
        }
    }
}
