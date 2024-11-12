using UnityEngine;

public class Particle : MonoBehaviour
{
    private Vector3 position;
    private Vector3 direction;
    private Vector3 velocity;
    private float lifetime;
    private float age = 0f;
    private ParticleTypeData typeData;

    public void Initialize(ParticleTypeData typeData)
    {
        this.typeData = typeData;
        this.direction = Vector3.up;
        this.velocity = direction * typeData.speed;
        this.lifetime = Random.Range(1f, 3f);
        this.position = transform.position;
    }

    public bool UpdateParticle(float deltaTime)
    {
        age += deltaTime;
        position += velocity * deltaTime;
        transform.position = position;
        return age < lifetime;
    }
}
