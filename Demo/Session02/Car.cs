
namespace Session02
{
    internal class Car
    {
        public Car(int id, string model, double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }

        public Car(int id, string model): this (id, model, 150)
        {
            Id = id;
            Model = model;
        }
        public int Id { get; set; }

        public string Model { get; set; }

        public double Speed { get; set; }


        public override string ToString()
        {
            return $"Car Id : {Id}\n Model: {Model}\n Speed: {Speed}";
        }
    }
}
