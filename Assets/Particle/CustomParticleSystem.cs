using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomParticleSystem : MonoBehaviour
{
    [SerializeField] private GameObject particlePrefab;
    [SerializeField] private float spawnRate = 10f;
    [SerializeField] private Vector3 spawnRange = new Vector3(1f, 1f, 1f);
    [SerializeField] private float particleLifetime = 2f;

    private float spawnTimer = 0f;
    private List<Particle> particles = new List<Particle>();
    private ParticleType particleType;

    void Start()
    {
        Material material = particlePrefab.GetComponent<MeshRenderer>().sharedMaterial; 
        Color color = material.color;
        float speed = 5f;
        particleType = ParticleType.GetSharedParticle(material, color, speed);
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= 1f / spawnRate)
        {
            Vector3 randomPosition = transform.position + new Vector3(
                Random.Range(-spawnRange.x, spawnRange.x),
                Random.Range(-spawnRange.y, spawnRange.y),
                Random.Range(-spawnRange.z, spawnRange.z)
            );

            GameObject particleObject = Instantiate(particlePrefab, randomPosition, Quaternion.identity);
            Particle particle = particleObject.GetComponent<Particle>();

            if (particle != null)
            {
                particle.Initialize(particleType);
                particles.Add(particle);
            }

            Destroy(particleObject, particleLifetime);

            spawnTimer = 0f;
        }

        particles.RemoveAll(p => !p.Update(Time.deltaTime));
    }
}
