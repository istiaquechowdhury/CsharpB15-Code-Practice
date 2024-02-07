using System.Globalization;

public class Program
{
    public static void Main()
    {
        //One dimensional array

        int[] Onedimensional_array = 
        { 
            1, 2, 4, 5, 5, 5, 5 
        };

        //ToAccessThis

        foreach (int i in Onedimensional_array)
            Console.WriteLine(i);


        //two dimensional array
        int[,] Twodimensional_array =
        {
            {1,2, 3, 4,5, 5, 5,},
            {1,2, 3, 4,5, 5, 5,},
            {1,2, 3, 4,5, 5, 5,},
            {1,2, 3, 4,5, 5, 5,},
            {1,2, 3, 4,5, 5, 5,},
            {1,2, 3, 4,5, 5, 5,},

        };

        //ToAccess this
        for (int row = 0; row < Twodimensional_array.GetLength(0); row++)
        {
            for (int col = 0; col < Twodimensional_array.GetLength(1); col++)
            {
                int element = Twodimensional_array[row, col];
                Console.WriteLine($"Element at row {row}, column {col}: {element}");
            }
        }

        //Jagged array

        string[][] Names = new string[3][];

        Names[0] = new string[3] { "skjf","slkjfs","skjflsk" };

        Names[1] = new string[5] { "slkjfs", "slkjfs", "slkjfs", "slkjfs", "slkjfs", };

        Names[2] = new string[5] { "slkjfs", "slkjfs", "slkjfs", "slkjfs", "slkjfs", };

        //To Access this

        for(int i = 0; i < Names.Length; i++)
        {
            for(int j = 0; j < Names[i].Length; j++)
            {
                string value = Names[i][j];  
                
                Console.WriteLine (value);

            }
        }













    }

   
}