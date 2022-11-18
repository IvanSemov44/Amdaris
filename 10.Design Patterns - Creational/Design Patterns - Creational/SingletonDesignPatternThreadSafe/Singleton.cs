
namespace SingletonDesignPatternThreadSafe
{
    public sealed class Singleton
    {
        private static int count = 0;

        private Singleton()
        {
            count++;
            Console.WriteLine("Count Value:" + count);
        }

        private static readonly Lazy<Singleton> InstanceLock = new Lazy<Singleton>(() => new Singleton());

        public static Singleton GetInstance
        {
            get
            {
                return InstanceLock.Value;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
