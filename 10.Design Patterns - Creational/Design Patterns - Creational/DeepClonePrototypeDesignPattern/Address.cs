
namespace DeepClonePrototypeDesignPattern
{
    public class Address
    {
        public string? GetAddress { get; set; }
        
        public Address GetClone()
        {   
            return (Address)this.MemberwiseClone();
        }
    }
}
