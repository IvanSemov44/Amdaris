
namespace MediatorDesignPattern
{
    public class ConcreteFacebookGroupMediator : FacebookGroupMediator
    {
        private List<User> userList =   new List<User>();


        public void RegisterUser(User user)
        {
            userList.Add(user);
        }

        public void SendMessage(string msg, User user)
        {
            foreach (var u in userList)
            {
                if (u != user)
                {
                    u.Receive(msg);
                }
            }
        }
    }
}
