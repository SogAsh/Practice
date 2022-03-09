namespace Practice.Inheritance
{
    public class Transport
    {
        public double Velocity;
        public double KilometerPrice;
        public int Capacity;
    }

    public class CombustionEngineTransport : Transport
    {
        public double EngineVolume;
        public double EnginePower;
    }

    public enum ControlType
    {
        Forward,
        Backward
    }

    public class Car : CombustionEngineTransport
    {
        public ControlType Control;
    }

    public class Program1
    {
        public static void NewMain()
        {
            Car car = new Car();
            Transport carAsTransport = (Transport)car; //апкаст - конверсия (тира Car) к базовому типу (Transport)
            Car car1 = (Car)carAsTransport; //даункаст - конверсия (типа Transport) к типу наследнику (Car)
        }
    }
}