namespace MediatorDesignPattern
{
    public class ConcreteUser : User
    {
        public ConcreteUser(FacebookGroupMediator mediator, string name)
            : base(mediator, name)
        {
        }

        public override void Receive(string msg)
        {
            Console.WriteLine(this.name + ": Received Message:" + msg);
        }

        public override void Send(string msg)
        {
            Console.WriteLine(this.name + ": Sending Message=" + msg + "\n");
            mediator.SendMessage(msg, this);
        }
    }
}
