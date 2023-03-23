using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Aquila : Animale, IVolante
{
    public override void Razza()
    {
        Console.WriteLine("Aquila");
    }
    public override void Verso()
    {
        Console.WriteLine("Screech Screech Screech");
    }
    public override void Dieta()
    {
        Console.WriteLine("Carnivoro");
    }
    public void Volare()
    {
        Console.WriteLine("Sto volando!!!");
    }
}
