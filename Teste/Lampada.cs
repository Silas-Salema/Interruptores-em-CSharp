namespace Teste
{
    class Lampada
    {
        public bool L1 { get; set; }
        public bool L2 { get; set; }

        public void AcionarInteruptor1()
        {
            if (L1 == true)
            {
                L1 = false;
            }
            else
            {
                L1 = true;
            }
        }

        public void AcionarInteruptor2()
        {
            if (L1 == true)
            {
                L1 = false;
            }
            else
            {
                L1 = true;
            }
            if (L2 == true)
            {
                L2 = false;
            }
            else
            {
                L2 = true;
            }
        }
        public void VerificarInteruptor(int i)
        {
            if (i == 1)
            {
                AcionarInteruptor1();
            }
            else
            {
                AcionarInteruptor2();
            }
        }
        public int ValorFinalL1()
        {
            if(L1 == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int ValorFinalL2()
        {
            if (L2 == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
