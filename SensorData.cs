using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SensorData
  {
    // data
    int[] temperature;  // array
    int NumDrones;  // size, can also use as an index
    Random rnd = new Random();

    public SensorData(int MaxNumDrones) {
        temperature = new int[MaxNumDrones];
    }

    public void read(int NumDrones)
    {
        this.NumDrones = NumDrones;
        for (int j = 0; j < NumDrones; j++)
        {
            temperature[j] = rnd.Next(40);//returns random integers < 10
        }
    }

    public float average()
    {
        int sum = 0;
        for (int i=0; i < NumDrones; i++) // go one array item after another
        {
            sum += temperature[i];
        }

        float avg = sum / NumDrones;

        return avg;
    }

    public int max()
    {
        int maxval = temperature[0];
        for (int i =0; i<NumDrones; i++)
        {
            if (temperature[i] > maxval)
            {
                maxval = temperature[i];
            }
        }

        return maxval; 
    }

    public int min()
    {
        return 0;
    }

    public void print()
    {
        for (int i = 0; i < NumDrones; i++)
        {
            Console.WriteLine(temperature[i]);
        }
    }

    // add the back a new temperature value
    public void append(int val)
    {
        temperature[NumDrones] = val;
        NumDrones = NumDrones + 1
    }

    public void appendFront(int val)
    {
        // shift to the right
        for (int i=NumDrones-1; i>=0; i--)
        {
            temperature[i+1] = temperature[i];
        }

        // one more line here
    }

}
