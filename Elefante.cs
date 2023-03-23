using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Elefante : Animale
{
    public override void Razza()
    {
        Console.WriteLine("Elefante");
    }
    public override void Verso()
    {
        Console.WriteLine("Iiiiiih");
    }
    public override void Dieta()
    {
        Console.WriteLine("Erbivoro");
    }
}
