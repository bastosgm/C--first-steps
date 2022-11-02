namespace FirstSteps
{
  internal class NeighboringNumberHandler
  {
    static void Main()
    {
      Console.WriteLine("--------------- NEIGHBORING NUMBERS HANDLER --------------- \n");

      Console.WriteLine("Now, we'll make our bi-dimensional array");
      Console.WriteLine("Enter lines and columns, respectively: ");
      Console.Write("Lines: ");
      int m = int.Parse(Console.ReadLine());

      Console.Write("Columns: ");
      int n = int.Parse(Console.ReadLine());

      Console.WriteLine();

      int[,] mat = new int[m, n];

      Console.WriteLine($"Enter each line with {n} numbers and press ENTER (place spaces between the numbers): \n");
      for (int i = 0; i < m; i++)
      {
        Console.Write($"Line {i}: ");
        string[] line = Console.ReadLine().Split(' ');
        for (int j = 0; j < n; j++)
        {
          mat[i, j] = int.Parse(line[j]);
        }
      }

      Console.WriteLine();

      Console.Write("Enter a number to get its neighborghoods: ");
      int number = int.Parse(Console.ReadLine());
      Console.WriteLine();

      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          if (mat[i, j] == number)
          {
            string position = $"{i}, {j}";
            Console.WriteLine($"Position: [{position}]");
            if (j - 1 >= 0 && mat[i, j - 1] != null) Console.WriteLine($"At left: {mat[i, j - 1]}");
            if (j + 1 <= n - 1 && mat[i, j + 1] != null) Console.WriteLine($"At right: {mat[i, j + 1]}");
            if (i > 0 && mat[i - 1, j] != null) Console.WriteLine($"Above: {mat[i - 1, j]}");
            if (i + 1 < n - 1 && mat[i + 1, j] != 0) Console.WriteLine($"Below: {mat[i + 1, j]}");
            Console.WriteLine();
          }
        }
      }
      Console.WriteLine("That's it. Thank You!");
    }
  }
}