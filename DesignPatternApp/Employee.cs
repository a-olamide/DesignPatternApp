using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp
{
    public class Employee
    {
        private int empId; //every object must have an ID
        private string empName; //every object must have a name
        public double salary { get; set; }  //it changes frequently and not required
        public int grade { get; set; } //it changes frequently and not required
        public string company = "WQ"; //since every object will have same values
        //here is a dependency. we want to be able to send notification to employee 
        IEmail email; //to send email notification to employee

        public Employee(int empId, string empName, IEmail email)
        {
            this.empId = empId;
            this.empName = empName;
            this.email = email;
        }

        public void NotifyEmployee()
        {
            email.SendEmail();
        }
    }

    public interface IEmail
    {
        void SendEmail();
    }

    public class OutlookEmail : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("Send outlook email");
        }
    }

    public class WebServiceEmail : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("Send webservice email");
        }
    }



}
