using System;
using System.Collections.Generic;

namespace TacoBellAPI.Models;

public class Burrito
{
    public int Id { get; set; }

    public string Name { get; set; }

    public float Cost { get; set; }

    public bool Bean { get; set; }
    
    public Burrito(string _name, float _cost, bool _bean)
    {
        Name= _name;
        Cost= _cost;
        Bean= _bean;
    }
}
