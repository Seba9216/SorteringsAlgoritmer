namespace SorteringsAlgoritmer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int gg = rnd.Next(5, 20); 

            int[] ints= new int[gg];
            string[] strings = new string[10] { "appel", "Dumbele", "einszweidrei", "bieacth", "Counterproductive", "fuckthisshitimout", "ahahaha", "heyyy","idkman","justgoalready" };

            for(int i = 0; i < ints.Length; i++)
            {
                ints[i] = rnd.Next(1,20);


            }
            QuickSort hej = new QuickSort();
          hej.Quicksorts(ints, 0, ints.Length - 1);
            hej.Quicksorts(strings, 0, strings.Length - 1); 
            ints = new int[gg];
            strings = new string[10];
        }
    }
}