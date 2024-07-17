using DataStructuresAndAlgorithms.LinkedList;

class DSA
{
    public static void Main()
    {
        MyLinkedList<String> l1 = new MyLinkedList<String>();
        l1.AddDataToFront("Umer");
        l1.AddDataToFront("Ali");
        l1.AddDataToFront("Ahmed");
        l1.AddDataToFront("Saad");

        l1.AddDataToEnd("Data to End");

        l1.AddDataBefore("Before Ahmed", "Ahmed");
        l1.AddDataBefore("Before Saad", "Saad");
        l1.AddDataBefore("Before End", "Data to End");

        l1.AddDataAfter("Data after Mid", "Ahmed");
        l1.AddDataAfter("Data after End", "Data to End");
        l1.AddDataAfter("Data after start", "Before Saad");

        l1.Display();
    }
}