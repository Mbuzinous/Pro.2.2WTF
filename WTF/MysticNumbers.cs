namespace WTF
{
    public class MysticNumbers
    {
        private int result;
        #region Methods
        //I like the new code more (two numbers) method more, as its easier to understand
        public int ThreeNumbers(int a, int b, int c)
        {
            if ((b > a) && (b > c))
            {
                result = b;
            }
            else if ((c > a) && (c > b))
            {
                result = c;
            }
            else
            {
                result = a;
            }

            return result;
        }
        public int TwoNumbers(int a, int b)
        {
            if (b > a)
            {
                result = b;
            }
            else
            {
                result = a;
            }

            return result;
        }

        public int FourNumbers(int a, int b, int c, int d)
        {
            if ((b > a) && (b > c) && (b > d))
            {
                result = b;
            }
            else if ((c > a) && (c > b) && (c > d))
            {
                result = c;
            }
            else if ((d > a) && (d > b) && (d > c))
            {
                result = d;
            }
            else
            {
                result = a;
            }

            return result;
        }
        #endregion
    }
}