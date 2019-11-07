using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshivoje.Models
{
    public class Client
    {
        public int _id { get; private set; }
        public string _firstName { get; private set; }
        public string _lastName { get; private set; }
        public string _address { get; private set; }
        public string _type { get; private set; }
        public string _companyName { get; private set; }
        public string _JMBG { get; private set; }
        public string _PIB { get; private set; }
        public string _BPG { get; private set; }
        public string _SPO { get; private set; }
        public string _zipCode { get; private set; }
        public string _bankAccount { get; private set; }
        public string _phone { get; private set; }

        public Client(int clientId,
            string clientFirstName,
            string clientLastName,
            string clientAddress,
            string clientType,
            string clientJMBG,
            string clientBPG,
            string clientZipCode,
            string clientBankAccount,
            string clientPhone,
            string clientPIB,
            string clientSPO,
            string companyName
            )
        {
            _id = clientId;
            _firstName = clientFirstName;
            _lastName = clientLastName;
            _address = clientAddress;
            _type = clientType;
            _companyName = companyName;
            _JMBG = clientJMBG;
            _PIB = clientPIB;
            _BPG = clientBPG;
            _SPO = clientSPO;
            _zipCode = clientZipCode;
            _bankAccount = clientBankAccount;
            _phone = clientPhone;

    }

}
}
