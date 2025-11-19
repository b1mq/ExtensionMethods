namespace ExtMethids.Domain.Entities
{
    public sealed record Fraction_R(int Numerator,int Denominator)
    {
        public static Fraction_R operator+(Fraction_R a, Fraction_R b)
        {
            int newNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction_R(newNumerator, newDenominator);
        }
        public static Fraction_R operator -(Fraction_R a, Fraction_R b)
        {
            int newNumerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction_R(newNumerator, newDenominator);
        }

    }
}
