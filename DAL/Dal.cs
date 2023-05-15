using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDesk.BusinessObjects;
using TravelDesk.DAL;

namespace DAL
{
    public class Dal
    {
        

        TravelDbContext db = new TravelDbContext();
        List<Role> roles = null;
        void InitializeRoles()
        {
            if (roles == null)
            {
                roles = new List<Role>
                { new Role() { RoleName = "Admin", DateCreated = DateTime.Now,
                    DateUpdated = null, IsActive = true },
                    new Role() { RoleName = "HRAdmin", DateCreated = DateTime.Now,
                        DateUpdated = null, IsActive = true },
                    new Role() { RoleName = "Manager", DateCreated = DateTime.Now,
                        DateUpdated = null, IsActive = true },
                    { new Role() { RoleName = "Employee", DateCreated = DateTime.Now,
                        DateUpdated = null, IsActive = true }
                    } };
            }
        }
        public Dal()
        {
           
                if (roles == null)
                {
                    InitializeRoles();
                    db.Roles.AddRange(roles);
                    db.SaveChanges();
                
            }
        }
        
        public int AddUser(User user)
        {
            db.Users.Add(user);
            SaveRecords();
            return 0;

        }
        public Role GetRole(string rolename)
        {
            return(db.Roles.FirstOrDefault(x => x.RoleName == rolename));
        }
        void SaveRecords()
        {
            db.SaveChanges();
        }
    }
}
