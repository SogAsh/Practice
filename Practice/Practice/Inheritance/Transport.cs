namespace Practice.Inheritance
{
    class Transport
    {
        public double Velocity;
        public double KilometerPrice;
        public int Capacity;
    }

    class CombustionEngineTransport : Transport
    {
        public double EngineVolume;
        public double EnginePower;
    }

    enum ControlType
    {
        Forward,
        Backward
    }

    class Car : CombustionEngineTransport
    {
        public ControlType Control;
    }

    class Program1
    {
        public static void NewMain()
        {
            Car car = new Car();
            Transport carAsTransport = (Transport)car; //апкаст
            Car car1 = (Car)carAsTransport; //даункаст
        }
    }
}