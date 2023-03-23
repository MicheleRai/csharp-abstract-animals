using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Squalo : Animale, INuotante
{
    public override void Razza()
    {
        Console.WriteLine("Squalo");
    }
    public override void Verso()
    {
        Console.WriteLine("Blob Blob Blob");
    }
    public override void Dieta()
    {
        Console.WriteLine("Carnivoro");
    }
    public void Nuotare()
    {
        Console.WriteLine("Sto nuotando!!!");
    }
}
