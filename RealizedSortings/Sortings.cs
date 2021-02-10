using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MySortings
{
    class Sortings
    {
        #region Сортировка Вставкой !!!!!!!! с костылём(
        public static int findMinIndexNew(int[] massOfElems)
        {
            int minElem = massOfElems[0];
            int minIndex = 0;
            for (int i = 1; i < massOfElems.Length; i++)
            {
                if (massOfElems[i] < minElem)
                {

                    minElem = massOfElems[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        public static int[] SelectionSort(int[] massOfInts)
        {
            int[] Sorted = new int[massOfInts.Length];
            for (int i = 0; i < massOfInts.Length; i++)
            {

                Sorted[i] = massOfInts[findMinIndexNew(massOfInts)];
                massOfInts[findMinIndexNew(massOfInts)] = int.MaxValue;
            }

            return Sorted;
        }
        #endregion

        #region Быстрая сортировка
        /// <summary>
        /// Возвращает случайный индекс элемента в массиве
        /// </summary>
        /// <param name="intMass">Массив на входе</param>
        /// <returns></returns>
        public static int GetRandomIndexOfMass(int[] intMass)
        {
            if (intMass.Length == 1) return 0;
            else
            {
                Random rnd = new Random();
                return rnd.Next(0, intMass.Length);
            }
        }
        public static int[] GlueMassives(int[] LessMass, int[] LargerMass, int baseElement)
        {
            LessMass = FillInMass(LessMass, baseElement);
            for (int i = 0; i < LargerMass.Length; i++)
            {
                LessMass = FillInMass(LessMass, LargerMass[i]);
            }
            return LessMass;
        }
        public static int[] FillInMass(int[] massToFillIn, int elem)
        {
            int[] copy = new int[massToFillIn.Length + 1];
            for (int i = 0; i < copy.Length; i++)
            {
                if (i == copy.Length - 1)
                {
                    copy[i] = elem;
                }
                else
                {
                    copy[i] = massToFillIn[i];
                }

            }

            return copy;
        }
        public static int[] GetLessOrLargerElems(int[] massToDivide, int baseElement, bool LargerOrLess)
        {
            if (LargerOrLess == true)
            {
                int[] LargerElems = { };
                return LargerElems;
            }
            else
            {
                int[] LessElems = { };
                return LessElems;
            }

        }
        
        //Это главный метод сортироваки остальные - вспомогательные
        public static int[] QuickSort(int[] MassToSort)
        {


            if (MassToSort.Length < 2) return MassToSort;
            
            else
            {
                int baseElement = MassToSort[GetRandomIndexOfMass(MassToSort)];

                int[] LessMass = GetLessElems(MassToSort, baseElement);
                int[] LargerMass = GetLargerElems(MassToSort, baseElement);
                
                return GlueMassives(QuickSort(LessMass), QuickSort(LargerMass), baseElement);
            }

        }


        public static int[] GetLessElems(int[] MassToGetLess, int baseElement)
        {
            int[] LessElems = { };
            for (int i = 0; i < MassToGetLess.Length; i++)
            {
                if (MassToGetLess[i] < baseElement)
                {
                    LessElems = FillInMass(LessElems, MassToGetLess[i]);
                }
            }
            return LessElems;
        }
        public static int[] GetLargerElems(int[] MassToGetLarger, int baseElement)
        {
            int[] LargerElems = { };
            for (int i = 0; i < MassToGetLarger.Length; i++)
            {
                if (MassToGetLarger[i] > baseElement)
                {
                    LargerElems = FillInMass(LargerElems, MassToGetLarger[i]);

                }
            }
            return LargerElems;
        }
        #endregion
        
        
    }

}
