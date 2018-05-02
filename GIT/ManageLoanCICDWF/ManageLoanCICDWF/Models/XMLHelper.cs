using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace ManageLoanCICDWF.Models
{
    public class XMLReader
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static ClientCollection ClientXMLReader()
        {
            ClientCollection result;
            XmlSerializer serializer = new XmlSerializer(typeof(ClientCollection));
            using (var reader = XmlReader.Create(path + "//ClientCollection.xml"))
            {
                result = (ClientCollection)serializer.Deserialize(reader);
            }
            return result;
        }
        public static EmployeeCollection EmpXMLReader()
        {
            EmployeeCollection result;
            XmlSerializer serializer = new XmlSerializer(typeof(EmployeeCollection));
            using (var reader = XmlReader.Create(path + "//EmployeeCollection.xml"))
            {
                result = (EmployeeCollection)serializer.Deserialize(reader);
            }
            return result;
        }
        public static LoanCollection LoanXMLReader()
        {
            LoanCollection result;
            XmlSerializer serializer = new XmlSerializer(typeof(LoanCollection));
            using (var reader = XmlReader.Create(path + "//LoanCollection.xml"))
            {
                result = (LoanCollection)serializer.Deserialize(reader);
            }
            return result;
        }
    }

    public class XMLWriter
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static void ClientXMLWriter(ClientCollection Clist)
        {
            System.Xml.Serialization.XmlSerializer CWriter = new System.Xml.Serialization.XmlSerializer(typeof(ClientCollection));
            var CfullPath = path + "//ClientCollection.xml";
            System.IO.FileStream Cfile = System.IO.File.Create(CfullPath);
            CWriter.Serialize(Cfile, Clist);
            Cfile.Close();
        }
        public static void EmpXMLWriter(EmployeeCollection Elist)
        {
            System.Xml.Serialization.XmlSerializer EWriter = new System.Xml.Serialization.XmlSerializer(typeof(EmployeeCollection));
            var EfullPath = path + "//EmployeeCollection.xml";
            System.IO.FileStream Efile = System.IO.File.Create(EfullPath);
            EWriter.Serialize(Efile, Elist);
            Efile.Close();
        }

        public static void LoanXMLWriter(LoanCollection Llist)
        {
            System.Xml.Serialization.XmlSerializer LWriter = new System.Xml.Serialization.XmlSerializer(typeof(LoanCollection));
            var LfullPath = path + "//LoanCollection.xml";
            System.IO.FileStream Lfile = System.IO.File.Create(LfullPath);
            LWriter.Serialize(Lfile, Llist);
            Lfile.Close();
        }


        public static void TestXMLWriter()
        {
            ClientCollection Clist = new ClientCollection();
            EmployeeCollection Elist = new EmployeeCollection();
            LoanCollection Llist = new LoanCollection();

            Clist.ClientList = new List<ClientInfo>();
            Elist.EmployeeList = new List<Employee>();
            Llist.LoanList = new List<LoanDetails>();
            for (var i = 0; i < 5; i++)
            {
                ClientInfo overview = new ClientInfo();
                overview.ClientName = "Avinash" + i;
                overview.ClientNo = "462521" + i;
                overview.AccountNumber = "123456" + i;
                overview.isKYCDone = "true";
                Clist.ClientList.Add(overview);

                Employee emp = new Employee();
                emp.EmpID = "4625" + i;
                emp.EmpName = "Chait" + i;
                emp.Password = "admin";
                emp.Role = "BankUser";
                emp.Hierarchy = "Admin";
                Elist.EmployeeList.Add(emp);

                LoanDetails loan = new LoanDetails();
                loan.loanNo = "1234" + i;
                loan.ClientNo = overview.ClientNo;
                loan.ClientName = overview.ClientName;
                loan.InitiatedBy = emp.EmpID;
                loan.InterestRate = "10%";
                loan.loanAccount = overview.AccountNumber;
                loan.loanStatus = "Pending";
                loan.PendingWith = "Admin";
                Llist.LoanList.Add(loan);
            }

            System.Xml.Serialization.XmlSerializer CWriter = new System.Xml.Serialization.XmlSerializer(typeof(ClientCollection));
            var CfullPath = path + "//ClientCollection.xml";
            System.IO.FileStream Cfile = System.IO.File.Create(CfullPath);
            CWriter.Serialize(Cfile, Clist);
            Cfile.Close();

            System.Xml.Serialization.XmlSerializer EWriter = new System.Xml.Serialization.XmlSerializer(typeof(EmployeeCollection));
            var EfullPath = path + "//EmployeeCollection.xml";
            System.IO.FileStream Efile = System.IO.File.Create(EfullPath);
            EWriter.Serialize(Efile, Elist);
            Efile.Close();

            System.Xml.Serialization.XmlSerializer LWriter = new System.Xml.Serialization.XmlSerializer(typeof(LoanCollection));
            var LfullPath = path + "//LoanCollection.xml";
            System.IO.FileStream Lfile = System.IO.File.Create(LfullPath);
            LWriter.Serialize(Lfile, Llist);
            Lfile.Close();

        }
    }
}