﻿namespace HelloWorld
{
    class Program
    {
        static List<int> Szam_List = new List<int>();
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
            var sw = new StreamWriter(@"szamlista.txt", false, System.Text.Encoding.UTF8);
            for (int i = 0; i < Szam_List.Count; i++)
            {
                if (i % 20 == 0)
                { sw.Write("\n"); }
                sw.Write($"{Szam_List[i]:00}, ");
            }
            sw.Close();
        }
    }
}