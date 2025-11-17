namespace ExtMethids.Domain.Entities
{
    public static class IntExtension
    {
        public static bool isEven(this int number)
        {
            
            return number % 2 == 0;
        }    
        public static bool isOdd(this int number)
        {
            return number % 2 != 0;
        } 
        public static bool isPrime(this int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
                if (number % i == 0) return false;
            return true;
        }
        
    }
}
