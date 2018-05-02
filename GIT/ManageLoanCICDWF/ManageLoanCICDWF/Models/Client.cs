using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageLoanCICDWF.Models
{
    public class ClientInfo
    {
        public string ClientNo { get; set; }

        public string ClientName { get; set; }

        public string AccountNumber { get; set; }

        public string isKYCDone { get; set; }
    }

    public class ClientCollection
    {
        public List<ClientInfo> ClientList { get; set; }
    }
}