namespace ConsoleApp1.Entites
{
    class Quant_atendido
    {
        public int A1 { get; set; }
        public int B1 { get; set; }
        public int C1 { get; set; }

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int Total { get; set; }
        public Quant_atendido()
        {

        }
        public Quant_atendido(int a1, int b1, int c1, int a, int b, int c)
        {
            A1 = a1;
            B1 = b1;
            C1 = c1;
            A = a;
            B = b;
            C = c;
        }

        public bool Calculo_Atendi()
        {
            if (0 <= A && A <= 100 && 0 <= B && B <= 100 && 0 <= C && C <= 100 && 0 <= A1 && A1 <= 100 && 0 <= B1 && B1 <= 100 && 0 <= C1 && C1 <= 100)
            {

                int total = 0;

                if (A > A1)
                {
                    total += (A - A1);
                }

                if (B > B1)
                {
                    total += (B - B1);
                }

                if (C > C1)
                {
                    total += (C - C1);
                }
                Total = total;
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}

