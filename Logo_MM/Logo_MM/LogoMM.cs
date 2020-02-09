namespace MentorMateTask
{
    using System.Text;
    public class LogoMM
    {
        private readonly int n;
        private StringBuilder sb;

        public LogoMM(int n)
        {
            this.n = n;

            this.sb = new StringBuilder();
        }


        public string Draw()
        {
            int half = (this.n + 1) / 2;

            for (int i = 0; i < half; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    this.sb.Append(LogoCharacterConstat.dash, this.n - i);
                    this.sb.Append(LogoCharacterConstat.star, this.n + i * 2);
                    this.sb.Append(LogoCharacterConstat.dash, this.n - i * 2);
                    this.sb.Append(LogoCharacterConstat.star, this.n + i * 2);
                    this.sb.Append(LogoCharacterConstat.dash, this.n - i);
                }
                this.sb.AppendLine();
            }

            for (int i = 0; i < half; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    this.sb.Append(LogoCharacterConstat.dash, this.n / 2 - i);
                    this.sb.Append(LogoCharacterConstat.star, this.n);
                    this.sb.Append(LogoCharacterConstat.dash, i * 2 + 1);
                    this.sb.Append(LogoCharacterConstat.star, this.n * 2 - 1 - i * 2);
                    this.sb.Append(LogoCharacterConstat.dash, i * 2 + 1);
                    this.sb.Append(LogoCharacterConstat.star, this.n);
                    this.sb.Append(LogoCharacterConstat.dash, this.n / 2 - i);
                }
                this.sb.AppendLine();
            }

            return this.sb.ToString().TrimEnd();
        }
    }
}
