namespace HelloWorld
{
    class Program
    {
        static List<int> Szam_List = new List<int>();
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Listák
            for (int i = 0; i < 200; i++)
            {
                Szam_List.Add(rnd.Next(1, 51));
            }
        }
    }
}