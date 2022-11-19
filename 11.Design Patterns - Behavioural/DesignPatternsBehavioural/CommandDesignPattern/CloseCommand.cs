
namespace CommandDesignPattern
{
    public class CloseCommand : ICommand
    {
        private Document document;
        public CloseCommand(Document document)
        {
            this.document = document;
        }
        public void Execute()
        {
            document.Close();
        }
    }
}
