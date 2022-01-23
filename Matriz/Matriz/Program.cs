namespace Matriz
{
    public class Matriz
    {
        static void Main(string[] arg)
        {
            int linha = 2;
            int coluna = 2;

            int valorX = 0;
            int valorZ = 35;
            int valorA = 1;

            int[,] array = new int[linha,coluna];

            for (int i = 0; i <= linha; i++)
            {
                for(int y = 0; y <= coluna; y++)
                {
                   valorX++;
                   valorZ--;
                   valorA = valorA + 3;
                   Console.WriteLine("--------------------------------");
                   Console.WriteLine($"| {i},{y} = {array[i,y] = valorX} | {1},{y} = {array[i,y] = valorZ} | {2},{y} = {array[i,y] = valorA}" + " |");
                }
            }
        }
    }
}
