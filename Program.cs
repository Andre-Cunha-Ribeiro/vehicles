namespace VEHICLES
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var manager = new FileManager();

            // Reads File
            var list = manager.ReadData();

            //Sets the wheel pressure to 50 in every wheel of the first bycicle that has 14" wheels
            var bicycle = list.Vehicles.Where(x => x.Type == "bicycle" && x.Wheels != null && x.Wheels.All(y => y.Size == 14)).First();
            if (bicycle.Wheels != null)
            {
                foreach (var wheel in bicycle.Wheels)
                {
                    wheel.Pressure = 50;
                }
            }

            //Sets a displacement of 3000 in every vehicle with the type truck
            var trucks = list.Vehicles.Where(x => x.Type == "truck");
            DisplacementAmount disp = new DisplacementAmount();
            disp.Value = 3000;
            foreach (var truck in trucks)
            {
                if (truck.Motor != null)
                    truck.Motor.Displacement = disp;
            }

            //Sets the color red in the first vehicle with the type car and the motor type hybrid
            list.Vehicles.Where(x => x.Type == "car" && x.Motor != null && x.Motor.Type == "hybrid").First().Color = "red";

            //Writes Updated Object
            manager.WriteData(list);

            Console.WriteLine("Operation Successfully Completed!");

        }
    }
}
