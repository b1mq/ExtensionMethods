namespace ExtMethids.Domain.Entities
{
    public static class PersonExtension
    {
        public static int MaxAgeByPersonArray(this List<Person> People)
        {
            int maxAge = People[0].Age;
            for (int i = 0; i < People.Count; i++)
            {
                if (maxAge < People[i].Age)
                {
                    maxAge = People[i].Age;
                }
            }
            return maxAge;
        }
        public static int MinAgeByPersonArray(this List<Person> People)
        {

            int minAge = People[0].Age;
            for (int i = 0; i < People.Count; i++)
            {
                if (minAge > People[i].Age)
                {
                    minAge = People[i].Age;
                }
            }
            return minAge;
        }
        public static double AverageAgePersonArray(this List<Person> People)
        {
            int avg = 0;
            for (int i = 0; i < People.Count; i++)
            {
                avg += People[i].Age;
            }
            return People.Count / avg;
        }
    }
}
