﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T>? Next { get; set; }

        public Node<T>? Prev { get; set; }

        public Node(T value)
        {
            Next = null;
            Value = value;
            Prev = null;
        }

    }
}
