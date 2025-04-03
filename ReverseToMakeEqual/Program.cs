namespace  ReverseToMakeEqual
{
    class Program
    {
        public static void Main()
        {
            int[] arrA = {1, 2, 3, 4};
            int[] arrB = {1, 4, 3, 2};

            bool areEqual = areTheyEqual(arrA, arrB);
            Console.WriteLine($"arrA and arrB are equal: {areEqual}");
        }

         private static bool areTheyEqual(int[] arrA, int[] arrB) 
         {
            bool result = true; 

            if (arrA.Length != arrB.Length)
            {
                result = false;
            }
            else
            {
                Dictionary<int, int> freqA = new Dictionary<int, int>();
                Dictionary<int, int> freqB = new Dictionary<int, int>();

                foreach (var num in arrA)
                {
                    if (freqA.ContainsKey(num))
                    {
                        freqA[num]++;
                    }
                    else
                    {
                        freqA[num] = 1;
                    }
                }

                foreach (var num in arrB)
                {
                    if (freqB.ContainsKey(num))
                    {
                        freqB[num]++;
                    }
                    else
                    {
                        freqB[num] = 1;
                    }
                }

                foreach (var key in freqA.Keys)
                {
                    if (!freqB.ContainsKey(key) || freqA[key] != freqB[key])
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result; 
        }
    }
}