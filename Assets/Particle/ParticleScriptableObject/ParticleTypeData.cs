using UnityEngine;

[CreateAssetMenu(fileName = "NewParticleType", menuName = "Particles/ParticleType")]
public class ParticleTypeData : ScriptableObject
{
    public Material material;
    public Color color;
    public float speed;
}
