namespace ImpactChallenge.Console
{
    using ImpactChallenge.Lib;
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            
            linkedList.AddAfter(2, 10);
            linkedList.AddBefore(4, 11);

            var res = linkedList[0]; 
            res = linkedList[1]; 
            res = linkedList[2]; 
            res = linkedList[3];
            
            System.Console.WriteLine(linkedList.Contains(4));
            
            

        }
    }
}