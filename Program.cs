namespace VEHICLES
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var manager = new FileManager();

            var list = manager.ReadData();

            var bicycle = list.Vehicles.Where(x => x.Type == "bicycle" && x.Wheels != null && x.Wheels.All(y => y.Size == 14)).First();
            if (bicycle.Wheels != null)
            {
                foreach (var wheel in bicycle.Wheels)
                {
                    wheel.Pressure = 50;
                }
            }

            var trucks = list.Vehicles.Where(x => x.Type == "truck");
            Displacement disp = new Displacement();
            disp.Value = 3000;
            foreach (var truck in trucks)
            {
                if (truck.Motor != null)
                    truck.Motor.Displacement = disp;
            }

            list.Vehicles.Where(x => x.Type == "car" && x.Motor != null && x.Motor.Type == "hybrid").First().Color = "red";

            manager.WriteData(list);

            Console.WriteLine("Operations Successfully Completed!");

        }
    }
}
