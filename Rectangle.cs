using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDomainAccountEncapsulation
{
    class Rectangle
    {
        private int size;
        public int Size
        {
            get { return size; }
            set
            {
                if (value<0)
                {
                    size = 1;
                }
                else
                size = value; 
            }
        }
        private int most;
        public int Most
        {
            get { return most; }
            set {
                if (value < 0)
                { most = 1; }
                else
                { most = value; }
            }
        }
        private int domain;
        public int Domain
        {
           get { return domain = size * most; } set { domain = value; }
        }
    }
}
