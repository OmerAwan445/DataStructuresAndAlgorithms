
namespace DataStructuresAndAlgorithms.LinkedList
{
    public interface IMyLinkedList<T>
    {
        // Insertion Opertions
        public void AddDataToFront(T Data);
        public void AddDataToEnd(T Data);
        public void AddDataBefore(T newData, T existingData);
        public void AddDataAfter(T newData, T existingData);
        
        // Display Operations
        public void Display();


    }
}
