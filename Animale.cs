using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Animale
{
    public abstract void Razza();
    public void Dormi() => Console.WriteLine("Zzzz...");

    public abstract void Verso();

    public abstract void Dieta();

}
