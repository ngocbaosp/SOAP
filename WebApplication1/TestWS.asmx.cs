using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for TestWS
    /// </summary>
    [WebService(Namespace = "TestWebService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TestWS : System.Web.Services.WebService
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Address Address { get; set;}

            public Person()
            {
                Address = new Address();
            }

        }

        public class Address
        {
            public string Street { get; set; }
        }


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public Person Test(string FirstName,string LastName)
        {
            Person person = new Person();
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.Address.Street = "111";
            return person;
            //return "Hello World "+ FirstName + " " + LastName;
        }
    }
}
