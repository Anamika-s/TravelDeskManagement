using TravelDesk.BusinessObjects;

namespace TravelDeskManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BAL.Bal class1 = new BAL.Bal();
            Console.WriteLine("ENter NAme");
            string fisrtName = Console.ReadLine();
            Console.WriteLine("ENter LastNAme");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("ENter Role ");
            string  rolename= Console.ReadLine();
            //int role1 = class1.GetRole();
            Role role2 = class1.GetRole(rolename);
            
            User user = new User()
            {
                FirstName = fisrtName,
                LastName = lastName,
                Role = role2
            };
          
            int response=  class1.AddUser(user);
            if(response==0)
            {
                Console.WriteLine("User has been added");
            }
            
           
        }
    }
}