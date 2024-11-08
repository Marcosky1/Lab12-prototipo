using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleMaterial
{
    public string Color { get; set; }
    public string Texture { get; set; }

    public ParticleMaterial(string color, string texture)
    {
        Color = color;
        Texture = texture;
    }
}

