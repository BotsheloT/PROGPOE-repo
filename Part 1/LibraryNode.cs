using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    public class LibraryNode<T>
    {
        public T Data { get; set; }
        public LibraryNode<T> Parent  {get; set;}
        public List<LibraryNode<T>> Children { get; set; }

        public int GetHeight()
        {
            int height = 1;
            LibraryNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }


            return height;
        }
    }
}
