namespace CSClass
{
    internal class Method
    {
        int instanceVariable = 10;
        static int classVariable = 10;
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
        public int multiply(int min, int max)
        {
            int output = 1;
            for(int i = min; i <= max; i++) output *= i;

            some();

            return output;

        }

        static public void some()
        {
            //multiply(1, 10);
        }

        public static int Abs(int input)
        {
            if(input < 0) return -input;
            else return input;
        }
     

    }
}