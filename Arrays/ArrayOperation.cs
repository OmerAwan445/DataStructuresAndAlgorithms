namespace DataStructuresAndAlgorithms.Arrays
{
    internal class ArrayOperation : IArrayOperation
    {
        public ArrayOperation()
        {
            
        }

        public int FindElement(int[] arr, int n, int key)
        {
            for (int i = 0; i < n; i++)
            {
                if (key == arr[i]) return i;
            }
            return -1;
        }
        public void DeleteElement(int[] arr, int n, int key)
        {
            int pos = FindElement(arr, n, key);
            if (pos == -1)
            {
                Console.WriteLine("No Element Found");
                return;
            }
            for (int i = pos; i < n; i++)
            {
                arr[i] = arr[i + 1];
            }
        }

        public void InsertElement(int[] arr, int len, int el, int pos)
        {
            for (int i = len; i > pos; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[pos] = el;
        }

        public void InsertElementNoReverseLoop(int[] arr, int len, int el, int pos)
        {
            int prevEl = arr[pos];
            for (int j = pos + 1; j <= len; j++)
            {
                int currEl = arr[j];
                arr[j] = prevEl;
                prevEl = currEl;
            }
            arr[pos] = el;
        }

        public int getSecondLargest_2Pass(int[] arr, int n)
        {
            // Sort the array in non-decreasing order
            Array.Sort(arr);

            // start from second last element as last element is the largest
            for (int i = n - 2; i >= 0; i--)
            {

                if (arr[i] != arr[i + 1])
                {
                    return arr[i];
                }
            }
            return -1;
        }
        public int getSecondLargest_1Pass(int[] arr, int n)
        {
            int max1 = -1;
            int max2 = -1;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                if (arr[i] < max1 && arr[i] > max2)
                {
                    max2 = arr[i];
                }
            }

            return max2;
        }

        public int[] findThreeDiffLargest(int[] arr)
        {
            int[] maxNums = new int[3];
            int max1, max2, max3;
            max1 = max2 = max3 = int.MinValue;

            Array.Sort(arr);
            if (arr.Length != 0)
            {
                max1 = arr[arr.Length - 1];
            }
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                int x = arr[i];
                if (x != max1 && x > max2)
                {
                    max2 = x;
                }
                else if (x != max2 && x != max1 && x > max3)
                {
                    max3 = x;
                }
            }
            if (max1 != int.MinValue)
            {
                maxNums[0] = max1;
            }
            if (max2 != int.MinValue)
            {
                maxNums[1] = max2;
            }
            if (max3 != int.MinValue)
            {
                maxNums[2] = max3;
            }
            return maxNums;
        }

        /*An element is a Leader if it is greater than or equal to all the elements to its right side*/
        public List<int> findLeaders(int[] arr)
        {
            List<int> leaders = new List<int>();
            int n = arr.Length;
            int maxRight = arr[n - 1];
            leaders.Add(maxRight);
            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] > maxRight)
                {
                    maxRight = arr[i];
                    leaders.Add(maxRight);
                }
            }
            leaders.Reverse();

            return leaders;
        }

        public bool isSorted(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) return false;
            }
            return true;
        }

        public int[] removeDuplicate(int[] arr)
        {
            int[] uniqueArr = new int[arr.Length];
            int uniqueCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    uniqueArr[uniqueCount++] = arr[i];
                }
                else if (arr[i] != arr[i + 1])
                {
                    uniqueArr[uniqueCount++] = arr[i];
                }
            }
            return uniqueArr;
        }

        public int[][] subArrays(int[] arr)
        {
            int n = arr.Length;
            int subArraysLen = n * (n + 1) / 2;
            int[][] subArrays = new int[subArraysLen][];
            int idx = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int len = (j - i) + 1;
                    int[] subArray = new int[len];
                    for (int k = 0; k < len; k++)
                    {
                        subArray[k] = arr[i + k];
                    }
                    subArrays[idx++] = subArray;
                }
            }


            return subArrays;
        }

        public int[] reverseArray(int[] arr, int d)
        {
            int n = arr.Length;
            for (int i = 0; i < d; i++)
            {
                int last = arr[n - 1];
                for (int j = n - 1; j  > 0; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[0] = last;

            }
            return arr;
        }

        public int[] arrayRotationJugglingAlgo(int[] arr, int k, string direction)
        {
            int n = arr.Length;
            k %= n; // Handle cases where k > n
            if(direction == "left")
            {
                k = n - k; // Convert right rotation to left rotation
            }
            int cycles = findGDC(n, k);
            for (int i = 0; i < cycles; i++)
            {
                int temp = arr[i];
                int j = i;
                while (true)
                {
                    int d = (j + k) % n;  // Calculate the destination index
                    if (i == d)     // If the cycle is complete
                    {
                        arr[j] = temp;  // Place the stored element
                        break;
                    }
                    arr[j] = arr[d]; //  Move the element
                    j = d;  // Move to the next position in the cycle
                }
            }
            return arr;
        }


        // Function to Find Greatest Common Divisor such as GCD(9,3) = 3
        int findGDC(int a, int b)
        {
            while (b!=0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public int[] moveZerosToEnd(int[] arr)
        {
            int n = arr.Length;
            int[] filteredArray = new int[n];
            int nonZeroIdx = 0;
            //int zerosIdx = n - 1;

            for (int i = 0; i < n; i++)
            {
                    if(arr[i] != 0)
                    filteredArray[nonZeroIdx++] = arr[i];
            }
            return filteredArray;
        }
        public bool hasDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                    return true;
            }
            return false;
        }
    }
}
