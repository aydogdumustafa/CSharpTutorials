﻿using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Insan insan = new Insan(new Ceket());
            insan.Yaz();
        }
    }
}
