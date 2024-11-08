using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem
{
    private List<Particle> particles = new List<Particle>();
    private ParticleFactory factory = new ParticleFactory();

    public void AddParticle(Vector3 position, Vector3 velocity, float lifetime, string color, string texture)
    {
        var material = factory.GetMaterial(color, texture);
        Particle particle = new Particle(position, velocity, lifetime, material);
        particles.Add(particle);
    }

    public void Update()
    {
        foreach (var particle in particles)
        {
            particle.Update();
        }
    }

    public void Draw()
    {
        foreach (var particle in particles)
        {
            particle.Draw();
        }
    }
}

