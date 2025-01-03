


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int[]> report = new List<int[]>();
            int count = 0;
            using StreamReader reader = new StreamReader(@"C:\Users\ivoxm\OneDrive\Ambiente de Trabalho\AOC++\Day_2\ConsoleApp1\inputs.txt.txt");
            {
                while (!reader.EndOfStream)
                {
                    string[] reports = reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    int[] temp = reports.Select(x => int.Parse(x))/*.Take(5)*/.ToArray();

                    bool val = true;

                    if (temp[0] > temp[1])
                    {
                        for(int i = 1; i < temp.Length; i++)
                        {
                            if(!(temp[i - 1] > temp[i] && temp[i - 1] <= temp[i] + 3))
                            {
                                val = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < temp.Length-1; i++)
                        {
                            if (!(temp[i] < temp[i+1] && temp[i] + 3 >= temp[i + 1]))
                            {
                                val = false;
                                break;
                            }
                        }
                    }
                    count += val ? 1 : 0;
                }
                Console.WriteLine("O numero é:\t" + count);
            }
        }

        static int ProblemDampener(int[] temp, int problem_index/*index em que dá problema*/, int order/*1 para ascendente, 0 para descendente*/)
        {
            int max = problem_index + 1;
            problem_index = (problem_index == 0 ?  )
            if(order == 1)
            {
                while(problem_index < )
            }
            return 0;
        }
    }
}
