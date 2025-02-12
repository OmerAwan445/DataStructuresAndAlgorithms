using System.Xml.Serialization;

namespace DataStructuresAndAlgorithms.Arrays
{
    interface IArrayOperation
    {
        enum RotationDirection
        {
        Left,
        Right
        }
        void InsertElementNoReverseLoop(int[] arr, int len, int el, int pos);
        void InsertElement(int[] arr, int len, int el, int pos);

        void DeleteElement(int[] arr, int n, int key);
        int getSecondLargest_2Pass(int[] arr, int n);
        int getSecondLargest_1Pass(int[] arr, int n);
        int[] findThreeDiffLargest(int[] arr);
        List<int> findLeaders(int[] arr);
        bool isSorted(int[] arr);
        int[] removeDuplicate(int[] arr);
        int[][] subArrays(int[] arr);
        int[] reverseArray(int[] arr, int d);
        int[] arrayRotationJugglingAlgo(int[] arr, int k, string direction);
        int[] moveZerosToEnd(int[] arr);
    }
}
