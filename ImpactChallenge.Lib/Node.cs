using System;

namespace ImpactChallenge.Lib
{
    public class Node<T> where T : IEquatable<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
    }
}