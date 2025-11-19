namespace ExtMethids.Domain.Entities
{
    public static  class FractionExtension
    {
        public static Fraction_R MinFractionInFractionArray(this Fraction_R[] fraction_array)
        {
            Fraction_R MinFraction = fraction_array[0];
            foreach (var x in fraction_array)
            {
                if (x.Numerator < MinFraction.Numerator || x.Denominator < MinFraction.Denominator)
                    MinFraction = x;
            }
            return MinFraction;

        }
        public static Fraction_R MaxFractionInFractionArray(this List<Fraction_R> fraction_array)
        {
            Fraction_R MinFraction = fraction_array[0];
            foreach (var x in fraction_array)
            {
                if (x.Numerator > MinFraction.Numerator || x.Denominator > MinFraction.Denominator)
                    MinFraction = x;
            }
            return MinFraction;

        }

    }
}
