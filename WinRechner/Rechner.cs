namespace WinRechner
{
    public class Rechner
    {
      public  double A, B, Summe, Dif, Multi, Div ;



        public Rechner(double A, double B)
        {Summe= A+B; 
            Dif= B-A; 
            Multi= A*B; 
            Div = A / B;
        }

        public override string ToString()
        {
             return $"{Summe:N3}{Dif.ToString("N3").PadLeft(10)}{Multi.ToString("N3").PadLeft(10)}{Div.ToString("N3").PadLeft(10)}"; // Round to 3 place after coma

            // return $"{Summe:N3}{Dif.ToString().PadLeft(10):N3}{Multi.ToString().PadLeft(10):N3}{Div.ToString().PadLeft(10):N3}";
        }
    }

}
