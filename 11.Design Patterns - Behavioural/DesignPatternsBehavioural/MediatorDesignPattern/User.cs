namespace MediatorDesignPattern
{
    public abstract class User
    {
        protected FacebookGroupMediator mediator;
        protected string name;

        public User(FacebookGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public abstract void Send(string msg);
        public abstract void Receive(string msg);
    }
}