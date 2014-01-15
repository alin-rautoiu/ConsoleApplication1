﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
   
        public interface IStack
        {
            int Length { get; set; }
            int Capacity { get; set; }
            bool IsEmpty();
            void Push(int objectToPush);
            int Pull();
            void Clear();
        }
    
}
