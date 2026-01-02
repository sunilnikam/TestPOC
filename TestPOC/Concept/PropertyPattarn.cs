using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace TestPOC.Concept
{
    internal class PropertyPattarn
    {
        public void TestPropertyPattarn()
        {
            User user = new User { Role = "Admin", Age = 30 };
            if (user is { Role: "Admin", Age: >= 18 })
            {
                Console.WriteLine("User is an adult admin.");
            }
            else
            {
                Console.WriteLine("User does not meet the criteria.");
            }
        }
    }

    public class User
    {
        public string Role { get; set; }
        public int Age { get; set; }
    }
}
