using DataStructuresAndAlgorithms.Arrays;
using DataStructuresAndAlgorithms.LinkedList;

class DSA
{
    public static void Main()
    {
        int[] arr = { 1, 2, 0, 3, 0, 0, 0, 4, 10 };
        int len = 5;
        IArrayOperation arrOp = new ArrayOperation();
        //arrOp.InsertElementNoReverseLoop(arr, 5, 8, 2);
        //arrOp.InsertElement(arr, len, 8, 2);
        //len++;
        //arrOp.DeleteElement(arr, 6, 8);
        //len--;
        //int secondMax = arrOp.getSecondLargest_2Pass(arr, 5);
        //int secondMax = arrOp.getSecondLargest_1Pass(arr, 5);
        //int[] threeMaxs = arrOp.findThreeDiffLargest(arr);
        //var leaders = arrOp.findLeaders(arr);
        //var isSorted = arrOp.isSorted(arr);
        //var removedDuplicateArr = arrOp.removeDuplicate(arr);
        //var subArrays = arrOp.subArrays(arr);
        //var reversedArr = arrOp.reverseArray(arr, 2);
        //var rotatedArr = arrOp.arrayRotationJugglingAlgo(arr, 3, "left");
        var filteredArray = arrOp.moveZerosToEnd(arr);
        var temp = filteredArray[filteredArray.Length - 3];
        //Console.WriteLine("Rotated Array " + rotatedArr);


    }
}