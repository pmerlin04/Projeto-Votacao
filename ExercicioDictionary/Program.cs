using ExercicioDictionary.Entities;
namespace ExercicioDictionary
{

    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, int> eleicao = new Dictionary<string, int>();



            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int voto = int.Parse(line[1]);

                        Console.WriteLine(name + " " +voto);

                        if (eleicao.ContainsKey(name))
                        {
                            eleicao[name] += voto;
                        }
                        else
                        {
                            eleicao[name] = voto;
                        }


                    }


                    Console.WriteLine();
                    Console.WriteLine("Votes Total: ");
                    foreach (KeyValuePair<string, int> item in eleicao)
                    {
                        Console.WriteLine(item.Key + ":" + item.Value);
                    }
                }
            } catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}