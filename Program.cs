class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            SensorData sd = new SensorData(1000);

            sd.init();


            var watch = new System.Diagnostics.Stopwatch();
    
            watch.Start();
            sd.average();
            watch.Stop();
            Console.WriteLine($"Execution Time for Average: {watch.ElapsedMilliseconds} ms");
    }
    }

