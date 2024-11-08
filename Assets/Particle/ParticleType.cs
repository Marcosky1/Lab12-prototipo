using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleType
{
    public Material Material { get; private set; }
    public Color Color { get; private set; }
    public readonly float Speed;

    private ParticleType(Material material, Color color, float speed)
    {
        Material = material;
        Color = color;
        Speed = speed;
    }

    private static readonly Dictionary<string, ParticleType> particleTypes = new Dictionary<string, ParticleType>();

    public static ParticleType GetSharedParticle(Material material, Color color, float speed)
    {
        string key = $"{material.name}_{color}_{speed}";

        if (!particleTypes.ContainsKey(key))
        {
            particleTypes[key] = new ParticleType(material, color, speed);
        }

        return particleTypes[key];
    }
}
