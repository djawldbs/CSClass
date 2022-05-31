namespace CSClass
{
    internal class Method
    {
    
           public double Multi(double v1, int v2)
            {
                return v1 * v2;
            }
        public int sum(int min, int max)
        {
            int output = 0;
            for(int i = min; i <= max; i++) output += i;
            return output;
        }
    }
}