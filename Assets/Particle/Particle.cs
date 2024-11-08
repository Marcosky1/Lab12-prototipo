using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle
{
    public Vector3 Position { get; set; }
    public Vector3 Velocity { get; set; }
    public float Lifetime { get; set; }
    public ParticleMaterial Material { get; set; }

    public Particle(Vector3 position, Vector3 velocity, float lifetime, ParticleMaterial material)
    {
        Position = position;
        Velocity = velocity;
        Lifetime = lifetime;
        Material = material;
    }

    public void Update()
    {
        Position += Velocity;
        Lifetime -= Time.deltaTime;
    }

    public void Draw()
    {
        Console.WriteLine($"Dibujando partícula en {Position} con material {Material.Color}");
    }
}

