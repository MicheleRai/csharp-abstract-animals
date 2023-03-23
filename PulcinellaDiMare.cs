using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PulcinellaDiMare : Animale, IVolante, INuotante
{
    public override void Razza()
    {
        Console.WriteLine("Pulcinella di mare");
    }
    public override void Verso()
    {
        Console.WriteLine("Cip Cip Cip");
    }
    public override void Dieta()
    {
        Console.WriteLine("Carnivoro");
    }
    public void Volare()
    {
        Console.WriteLine("So volare!!!");
    }
    public void Nuotare()
    {
        Console.WriteLine("So nuotare!!!");
    }
}
