using System;

namespace ImpactChallenge.Lib
{
    
    /// <summary>
    /// A simple Linked List
    /// </summary>
    /// <typeparam name="T">The type of values in the LinkedList</typeparam>
    public interface ILinkedList<T> where T : IEquatable<T>
    {
        /// <summary>
        /// Add an item to the starting position.
        /// </summary>
        /// <param name="obj"></param>
        void AddFirst(T obj);
        
        /// <summary>
        /// Add an item to the last position.
        /// </summary>
        /// <param name="obj"></param>
        void AddLast(T obj);
        
        /// <summary>
        /// Add an item after a specific item is found
        /// </summary>
        /// <param name="after"></param>
        /// <param name="obj"></param>
        void AddAfter(T after, T obj);
        
        /// <summary>
        /// Add an item before a specific item is found
        /// </summary>
        /// <param name="before"></param>
        /// <param name="obj"></param>
        void AddBefore(T before, T obj);

        /// <summary>
        /// Find and return the first item in the list if matched with obj.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        T Find(T obj);
        
        /// <summary>
        /// Find and return the last item in the list if matched with obj.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        T FindLast(T obj);

        /// <summary>
        /// Checks if a specific item is in the list.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        bool Contains(T obj);

        /// <summary>
        /// Returns the first item found.
        /// </summary>
        /// <returns></returns>
        T GetFirst();
        
        /// <summary>
        /// Returns the last item found.
        /// </summary>
        /// <returns></returns>
        T GetLast();
        
        /// <summary>
        /// Returns an item given an index.
        /// </summary>
        /// <param name="index"></param>
        T this[uint index] { get; }

    }
}