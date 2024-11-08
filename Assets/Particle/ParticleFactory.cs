using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ParticleFactory
{
    private Dictionary<string, ParticleMaterial> materials = new Dictionary<string, ParticleMaterial>();

    public ParticleMaterial GetMaterial(string color, string texture)
    {
        string key = $"{color}-{texture}";
        if (!materials.ContainsKey(key))
        {
            materials[key] = new ParticleMaterial(color, texture);
        }
        return materials[key];
    }
}

