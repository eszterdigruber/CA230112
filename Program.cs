namespace HelloWorld
{
    class Program
    {
        static List<int> Szam_List = new List<int>();
        static List<int> Tiszta_List = new List<int>();
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Listák
            //Lista random számokkal való feltöltése
            for (int i = 0; i < 200; i++)
            {
                Szam_List.Add(rnd.Next(1, 51));
            }
            //Kiiratás
            for (int i = 0; i < Szam_List.Count; i++)
            {
                if (i % 20 == 0) 
                { Console.Write("\n"); }
                Console.Write($"{Szam_List[i]:00}, ");
            }
            //Fajl-ba kiiratni, txt, csv UTF 8-as kódolású ami ismeri az ékezetes betűket
            var sw = new StreamWriter(@"C:\Users\digruber.eszter\Documents\20230112\szamlista.txt", false, System.Text.Encoding.UTF8);
            for (int i = 0; i < Szam_List.Count; i++)
            {
                if (i % 20 == 0)
                { sw.Write("\n"); }
                sw.Write($"{Szam_List[i]:00}, ");
            }
            sw.Close();
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("Lista tisztítása");
            foreach (var sz in Szam_List)
            {
                if (!Tiszta_List.Contains(sz))
                { Tiszta_List.Add(sz); }
            }
            Console.WriteLine($"Tiszta lista nagysága: {Tiszta_List.Count}");
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("Statisztika");
            Tiszta_List.Sort();
            Tiszta_List.Reverse();
            foreach (var t in Tiszta_List)
            {
                int dbstat = 0;
                foreach (var sz in Szam_List)
                {
                    if (t == sz)
                    { dbstat++; }
                }
                Console.WriteLine($"{t:00}: {dbstat}db");
            }
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("Elem hozzáadása: +245");
            Szam_List.Add(245);
            Console.WriteLine($"Új lista hossza: {Szam_List.Count}");
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("A lista összegének kiszámolása");
            int Osszeg = Szam_List.Sum();
            Console.WriteLine($"A lista összege: {Osszeg}");
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("Maximum vagy minimum");
            int Max = Szam_List.Max();
            Console.WriteLine($"A legnagyobb érték a listában: {Max}");
            int MaxHely = Szam_List.IndexOf(Max);
            Console.WriteLine($"A listában a maximum helye: {MaxHely + 1}");
            int Min = Szam_List.Min();
            Console.WriteLine($"A legkisebb érték a listában: {Min}");
            int MinHely = Szam_List.IndexOf(Min);
            Console.WriteLine($"A listában a minimum helye: {MinHely + 1}");
        }
    }
}