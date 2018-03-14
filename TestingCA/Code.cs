
using fit;

namespace TestingCA
{
    public class Code : ColumnFixture
    {
        public int age;
        public string gender;

        public float CalcPremium(int age, string gender)
        {
            float premium;

            if (gender == "female")
                if ((age >= 18) && (age <= 30))
                    premium = (float)5.0;
                else if (age >= 31)
                    premium = (float)2.50;
                else
                    premium = (float)0.0;
            else if (gender == "male")
                if ((age >= 18) && (age <= 35))
                    premium = (float)6.0;
                else if (age >= 36)
                    premium = (float)5.0;
                else
                    premium = (float)0.0;
            else
                premium = (float)0.0;

            if (age >= 50)
                premium = premium * (float)0.15;
            return premium;
        }

    }
}
