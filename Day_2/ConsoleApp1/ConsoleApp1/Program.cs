


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int[]> report = new List<int[]>();
            int count = 0;
            using StreamReader reader = new StreamReader(@"/home/xubaca/Desktop/CSharp/AdventOfCode2024/Day_2/ConsoleApp1/inputs.txt.txt");
            {
                while (!reader.EndOfStream)
                {
                    string[] reports = reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    int[] list = reports.Select(x => int.Parse(x))/*.Take(5)*/.ToArray();

                    bool val = true;

                    int problem_index = -1;

                    int order = -1;



                    if (list[0] > list[1])
                    {
                        for(int i = 1; i < list.Length; i++)
                        {
                            if(!(list[i - 1] > list[i] && list[i - 1] <= list[i] + 3))
                            {
                                val = false;
                                problem_index = i;
                                order = 0;
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < list.Length-1; i++)
                        {
                            if (!(list[i] < list[i+1] && list[i] + 3 >= list[i + 1]))
                            {
                                val = false;
                                problem_index = i;
                                order = 1;
                                break;
                            }
                        }
                    }
                    if(!val) val = ProblemDampener(list,0,0);
                    count += val ? 1 : 0;
                }
                Console.WriteLine("O numero é:\t" + count);
            }
        }

        static bool ProblemDampener(int[] list, int problem_index/*index em que dá problema*/, int order/*1 para ascendente, 0 para descendente*/)
        {
            int max = problem_index + 1;
            problem_index = (problem_index == 0 ? 0 : problem_index - 1);
            bool val = true;
            if(order == 1)
            {
                while(problem_index < max)
                {
                    val = true;
                    List<int> list = temp
                        .where((item,index)=>index != problem_index)
                        .ToList();       
                    
                    for (int i = 0; i < list.Length-1; i++)
                    {
                        if (!(list[i] < list[i+1] && list[i] + 3 >= list[i + 1]))
                        {
                            val = false;
                            break;
                        }
                    }
                    if(val) break;
                    else problem_index++;
                }

            }
            else {
                while(problem_index < max)
                {
                    val = true;
                    List<int> list = temp
                        .where((item,index)=>index != problem_index)
                        .ToList();       
                    
                    for(int i = 1; i < list.Length; i++)
                    {
                        if(!(list[i - 1] > list[i] && list[i - 1] <= list[i] + 3))
                        {
                            val = false;
                            break;
                        }
                    }
                    if(val) break;
                    else problem_index++;
                }
            }
            return val;
        }
    }
}
