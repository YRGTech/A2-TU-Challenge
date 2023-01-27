using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {


        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            int temp;
            if (isInOrder(1, 2) == IsInOrder(1, 2))
            {
                while (!IsListInOrder(toSort))
                {
                    for (int i = 1; i <= toSort.Count - 1; i++)
                    {
                        if (isInOrder(toSort[i - 1], toSort[i]) == -1)
                        {
                            temp = toSort[i];
                            toSort[i] = toSort[i - 1];
                            toSort[i - 1] = temp;
                        }
                    }
                }

            }
            else
            {
                while (!IsListInOrderDesc(toSort))
                {
                    for (int i = 1; i <= toSort.Count - 1; i++)
                    {
                        if (isInOrder(toSort[i - 1], toSort[i]) == -1)
                        {
                            temp = toSort[i];
                            toSort[i] = toSort[i - 1];
                            toSort[i - 1] = temp;
                        }
                    }
                }
            }

            return toSort;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> list = new List<int>();
            for (int i = 0; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static bool IsDivisible(int a, int b)
        {
            double test = (double)a / b;
            int result = a / b;
            if (result == test)
            {
                return true;
            }
            return false;
        }

        public static bool IsEven(int a)
        {
            return (a % 2 == 0);
        }

        public static int IsInOrder(int a, int b)
        {
            if (a < b)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public static int IsInOrderDesc(int a, int b)
        {
            if (a < b)
            {
                return -1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 1; i <= list.Count - 1; i++)
            {
                if (IsInOrder(list[i - 1], list[i]) == -1)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsListInOrderDesc(List<int> list)
        {
            for (int i = 1; i <= list.Count - 1; i++)
            {
                if (IsInOrderDesc(list[i - 1], list[i]) == -1)
                {
                    return false;
                }
            }
            return true;
        }


        public static bool IsMajeur(int age)
        {
            if (age >= 18 && age < 141)
            {
                return true;
            }
            else if (age < 18 && age >= 0)
            {
                return false;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static bool IsPrimary(int a)
        {
            for (int i = 2; i < a; i++)
                if (a % i == 0) return false;
            return a > 1;
        }

        public static int Power(int a, int b)
        {
            int result = a;
            for (int i = 1; i < b; i++)
            {
                result = result * a;
            }
            return result;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            int temp;
            while (!IsListInOrder(toSort))
            {
                for (int i = 1; i <= toSort.Count - 1; i++)
                {
                    if (IsInOrder(toSort[i - 1], toSort[i]) == -1)
                    {
                        temp = toSort[i];
                        toSort[i] = toSort[i - 1];
                        toSort[i - 1] = temp;
                    }
                }
            }
            return toSort;
        }
    }
}
