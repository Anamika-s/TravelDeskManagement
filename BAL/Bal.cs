using TravelDesk.BusinessObjects;

namespace BAL
{
    public class Bal

    {
        DAL.Dal dal = new DAL.Dal();
        public int AddUser(User user)
        {
            dal.AddUser(user);
            return 0;
        }

        public Role GetRole(string rolename)
        {
            return dal.GetRole(rolename);
        }
    }
}