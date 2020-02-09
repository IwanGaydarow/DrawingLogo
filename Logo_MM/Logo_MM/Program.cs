using System;
using System.Text;

namespace MentorMateTask
{
    public class Program
    {
        private const char dash = '-';

        private const char star = '*';

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int half = (n + 1) / 2;

            var sb = new StringBuilder();

            for (int i = 0; i < half; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sb.Append(dash, n - i);
                    sb.Append(star, n + i * 2);
                    sb.Append(dash, n - i * 2);
                    sb.Append(star, n + i * 2);
                    sb.Append(dash, n - i);
                }
                sb.AppendLine();
            }

            for (int i = 0; i < half; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sb.Append(dash, n / 2 - i);
                    sb.Append(star, n);
                    sb.Append(dash, i * 2 + 1);
                    sb.Append(star, n * 2 - 1 - i * 2);
                    sb.Append(dash, i * 2 + 1);
                    sb.Append(star, n);
                    sb.Append(dash, n / 2 - i);
                }
                sb.AppendLine();
            }

                Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
