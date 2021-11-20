namespace VEHICLES
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var manager = new DataManager();

            var list = manager.readData();

            var bicycle = list.Vehicles.Where(x => x.type == "bicycle" && x.Wheels != null && x.Wheels.All(y => y.Size == 14)).First();
            if (bicycle.Wheels != null)
            {
                foreach (var wheel in bicycle.Wheels)
                {
                    wheel.Pressure = 50;
                }
            }

            var trucks = list.Vehicles.Where(x => x.type == "truck");
            Displacement disp = new Displacement();
            disp.Value = 3000;
            foreach (var truck in trucks)
            {
                if (truck.motor != null)
                    truck.motor.Displacement = disp;
            }

            list.Vehicles.Where(x => x.type == "car" && x.motor != null && x.motor.Type == "hybrid").First().color = "red";

            manager.writeData(list);

















            //     var c = new VehiclesList();

            //     c = XCar();

            //     foreach (var k in c.Vehicles)
            //     {
            //         Console.WriteLine(k.Id + " " + k.motor + " " + k.type);
            //     }
            //     //c = null;
            //     //Console.ReadLine();

            //     // var options = new JsonSerializerOptions { WriteIndented = true };
            //     // string jsonString = JsonSerializer.Serialize(c, options);

            //     string fileName = @"Challenge_C#.json";
            //     string jsonString = JsonSerializer.Serialize(c, new JsonSerializerOptions { WriteIndented = true });
            //     File.WriteAllText(fileName, jsonString);


            //     Console.WriteLine(jsonString);
            // }
            // static VehiclesList XCar()
            // {
            //     using (TextReader reader = new StreamReader(@"Challenge_C#.xml"))
            //     {
            //         XmlSerializer serializer = new XmlSerializer(typeof(VehiclesList));
            //         return (VehiclesList)serializer.Deserialize(reader);
            //     }
        }
    }
}
