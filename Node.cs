﻿namespace CustomStack
{
    internal class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
