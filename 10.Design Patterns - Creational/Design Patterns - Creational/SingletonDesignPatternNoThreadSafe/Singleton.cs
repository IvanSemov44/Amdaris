
namespace SingletonDesignPatternNoThreadSafe
{
    public sealed class Singleton
    {
        private static int count = 0;
        private static Singleton instance = null;
        
        public static Singleton GetInstance
        {
            get
            {
                if(instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        private Singleton()
        {
            count++;
            Console.WriteLine("Counter value:" + count.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
