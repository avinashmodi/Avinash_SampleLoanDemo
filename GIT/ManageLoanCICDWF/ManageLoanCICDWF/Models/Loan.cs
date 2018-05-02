using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageLoanCICDWF.Models
{
    public class LoanDetails
    {
        public string loanNo { get; set; }

        public string loanAccount { get; set; }

        public string ClientNo { get; set; }

        public string ClientName { get; set; }

        public string InterestRate { get; set; }

        public string InitiatedBy { get; set; }

        public string loanStatus { get; set; }

        public string LoanType { get; set; }

        public string PendingWith { get; set; }

        public string loanAmount { get; set; }
    }

    public class LoanCollection
    {
        public List<LoanDetails> LoanList { get; set; }
    }
}