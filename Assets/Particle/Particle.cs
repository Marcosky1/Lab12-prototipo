using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle
{
    private Vector3 position;
    private Vector3 direction;
    private Vector3 velocity;
    private float speed;
    private float lifetime;
    private float age = 0f;
    private float currentTime;

    private readonly ParticleType type;

    public Particle(Vector3 position, ParticleType type, Vector3 direction)
    {
        this.position = position;
        this.type = type;
        this.direction = direction;
        this.velocity = Vector3.up * type.Speed;
        this.lifetime = UnityEngine.Random.Range(1f, 3f);
    }

    public bool Update(float deltaTime)
    {
        age += deltaTime;
        position += direction * speed * deltaTime;

        return age < lifetime;
    }
}

