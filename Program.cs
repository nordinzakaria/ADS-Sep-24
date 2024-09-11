using System.Runtime.ExceptionServices;

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int NumSensor = 1000;
            SensorData sd = new SensorData(NumSensor);

            float total = 0
                // run sensor reading every second for 1 day
            int numSec = 60 * 60 * 24;
            for (int t = 0; t < numSec; t++)            
            {
                sd.read();
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                total += sd.average();
                watch.Stop();
                Console.WriteLine($"Execution Time for Average: {watch.ElapsedMilliseconds} ms");
            }
            Console.WriteLine("Average time to process data is ", (total / numSec));
        }
    }

