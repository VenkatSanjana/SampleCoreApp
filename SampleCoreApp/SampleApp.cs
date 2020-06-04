using System;

namespace SampleCoreApp
{
    public class SampleApp
    {

        public string Perform(int n)
        {
            string result = string.Empty;

            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Test Process Loop ---" + i);
                    result = i.ToString();
                }
            }
            else
            {
                Console.WriteLine("Error");
                result = "Error";
            }

            return result;
        }

    }
}
