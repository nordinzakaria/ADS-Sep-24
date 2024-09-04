using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SensorData
  {
    // data
    int[] temp;
    int NumDrones;
    Random rnd = new Random();

    public SensorData(int NumDrones) {
        temp = new int[NumDrones];
        this.NumDrones = NumDrones;
    }

    public void init()
    {
        for (int j = 0; j < NumDrones; j++)
        {
            temp[j] = rnd.Next(40);//returns random integers < 10
        }
    }

    public float average()
    {
        return 0;
    }

    public int max()
    {
        return 0; 
    }

    public int min()
    {
        return 0;
    }
}
