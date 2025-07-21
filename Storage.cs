using System;
using System.Collections.Generic;

public class Storage<T>
{
    private List<T> lista = new List<T>();

public int Antal
{
    get { return lista.Count; }
}
    
public void LäggTill(T objekt)
    {
        lista.Add(objekt);
    }

    public void SkrivUtAlla()
    {
        Console.WriteLine("Innehåll i Storage:");
        foreach (T objekt in lista)
        {
            Console.WriteLine(objekt);
        }
    }
}
