﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structuri
{
    internal class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node(T Value)
        { 
            this.Value = Value;
            Next = null;
        }
    }
}
