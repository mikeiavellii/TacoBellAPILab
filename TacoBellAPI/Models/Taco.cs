using System;
using System.Collections.Generic;

namespace TacoBellAPI.Models;

public class Taco
{
    public int Id { get; set; }

    public string Name { get; set; }

    public float Cost { get; set; }

    public bool SoftShell { get; set; }

    public bool Dorito { get; set; }

    public Taco(string _name, float _cost, bool _softShell, bool _dorito)
    {
        Name = _name;
        Cost = _cost;
        SoftShell = _softShell;
        Dorito = _dorito;
    }
}
