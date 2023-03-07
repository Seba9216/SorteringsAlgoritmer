using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteringsAlgoritmer
{
    public class QuickSort
    {

        // for at vi kan lave vores quicksort skal vi bruge 3 parametre 
        public  int[] Quicksorts(int[] ints,int venstre,int højre)
        {
           
            var i = venstre;
            var j = højre;
            //Vores pivot er ekstremt vigtigt da det er vores som navnet foreslår vores omdrejningspunkt
            //så det vil sige at vores pivot kigger på om vores venstre element er større og om vores højre er større

            var pivot = ints[venstre];
            while (i <= j)
            {
                //er vores venstre værdi mindre end pivot? hvis det er skipper vi dem og videre i vores loop
                while (ints[i] < pivot)
                {
                    i++;
                }
                //er vores højre værdi større end pivot? 
                while (ints[j] > pivot)
                {
                    j--;
                }
                //skifter vores positioner af ints[i] med ints[j] og vica versa 
                if (i <= j)
                {
                    int temp = ints[i];
                    ints[i] = ints[j];
                    ints[j] = temp;
                    i++;
                    j--;
                }
            }
            //vi gentager denne process indtil at vores temp er "opbrugt" variabler og returner vores svar
            if (venstre < j)
                Quicksorts(ints, venstre, j);
            if (i < højre)
                Quicksorts(ints, i, højre);
            return ints;
        }

        public string[] Quicksorts(string[] strings, int left, int right)
        {
            int i = left;
            int j = right;
            
            string alfabeticvaluepivot = strings[left];
            while(i <= j)
            {
                //den enste forskel på metoderne er sådan set af jeg bruger et lille check på vores 2 strings som giver mig enten et plus eller minus 
                while (HvemerFørst(alfabeticvaluepivot, strings[i]) > 0)
                {
                    i++;
                }

                while ((HvemerFørst(alfabeticvaluepivot, strings[j]) < 0))
                {
                    j--;
                }
                if (i <= j)
                {
                    string temp = strings[i];
                    strings[i] = strings[j];
                    strings[j] = temp;
                    i++;
                    j--;
                }

            }
            if (left < j)
                Quicksorts(strings, left, j);
            if (i < right)
                Quicksorts(strings, i, right);

            return strings; 
        }

        public int HvemerFørst(string str1, string str2)
        {
            if(str1 == null || str2 == null)
            {
                throw new Exception("U"); 
            }
           int i =  string.Compare(str1, str2); 

            return i; 
        }

    }

}
