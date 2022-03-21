namespace Practice.DataIntegrity
{
    class A
    {
        private int a;
        public int B;

        public void PublicMethod()
        {
            a = 1; // строка 1
            B = 2; // строка 2
        }

        private void PrivateMethod()
        {
            a = 3; // строка 3
            B = 4; // строка 4
        }
    }

    class B
    {
        private A privateA = new A();
        public A PublicA = new A();

        public void M()
        {
            //privateA.a = 5; // строка 5
            //PublicA.a = 7; // строка 6
            privateA.B = 6; // строка 7
            PublicA.B = 8; // строка 8
            PublicA.PublicMethod(); // строка 9
            privateA.PublicMethod(); // строка 10
            //PublicA.PrivateMethod(); // строка 11
            //privateA.PrivateMethod(); // строка 12
        }
    }
}