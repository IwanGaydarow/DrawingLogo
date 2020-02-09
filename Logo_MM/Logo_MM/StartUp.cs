namespace MentorMateTask
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int letterSize = int.Parse(Console.ReadLine());

            var logo = new LogoMM(letterSize);

            string result = logo.Draw();

            Console.WriteLine(result);
        }
    }
}
