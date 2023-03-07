using SorteringsAlgoritmer;

namespace TestafSort
{
    public class UnitTest1
    {
        [Fact]
        public void QuickSortint()
        {
            int[] nums = { 11, 4,32, 4,2 ,6, 7 };
            int[] expectec = { 2, 4, 4, 6, 7, 11, 32 }; 
            QuickSort sort = new QuickSort();

            sort.Quicksorts(nums, 0, nums.Length - 1);

            Assert.Equal(nums, expectec); 
        }
        [Fact]
        public void QuickSortString2()
        {
            string[] strings = { "appel", "Dumbele", "einszweidrei", "bieacth", "Counterproductive", "fuckthisshitimout", "ahahaha", "heyyy", "idkman", "justgoalready" };
            string[] strings2 = { "appel", "Dumbele", "einszweidrei", "bieacth", "Counterproductive", "fuckthisshitimout", "ahahaha", "heyyy", "idkman", "justgoalready" };
            Array.Sort(strings2);
            QuickSort sort = new QuickSort();

            sort.Quicksorts(strings, 0, strings.Length - 1);

            Assert.Equal(strings2, strings);


        }
    }
}