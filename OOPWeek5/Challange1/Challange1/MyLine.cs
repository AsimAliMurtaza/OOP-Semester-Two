﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange1
{
    internal class MyLine
    {
        MyPoint begin;
        MyPoint end;

        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }
        public MyPoint getBegin() 
        { return begin; }
        public MyPoint getEnd() 
        { return end;}
        public void setBegin(MyPoint begin)
        { this.begin = begin; }
        public void setEnd(MyPoint end) 
        {  this.end = end; }
        public double getLength()
        { return end.distanceWithObject(begin); }
        public double getLengthFromZero()
        { return end.distanceWithZero(); }
        public double getGradient() 
        { return (end.Y - begin.Y) / (end.X - begin.X); }
    }
}
