﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IVolante
{
    void Volare()
    {
        Console.WriteLine("Sto volando!!!");
    }
}
public interface INuotante
{
    void Nuotare()
    {
        Console.WriteLine("Sto nuotando!!!");
    }
}
