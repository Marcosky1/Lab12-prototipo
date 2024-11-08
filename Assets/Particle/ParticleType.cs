using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleType
{
    public Material Material { get; private set; }
    public Color Color { get; private set; }
    public readonly float Speed;

    public ParticleType(Material material, Color color, float speed)
    {
        Material = material;
        Color = color;
        Speed = speed;
    }

    public static ParticleType GetSharedParticle(Material material, Color color, float speed)
    {
        return new ParticleType(material, color, speed);
    }
}
