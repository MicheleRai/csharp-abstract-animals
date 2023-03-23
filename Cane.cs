using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cane : Animale
{
    public override void Razza()
    {
        Console.WriteLine("Cane");
    }
    public override void Verso()
    {
        Console.WriteLine("Bau Bau Bau");
    }
    public override void Dieta()
    {
        Console.WriteLine("Onnivoro");
    }
}
