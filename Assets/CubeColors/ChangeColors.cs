using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeColors : MonoBehaviour
{
    private Renderer _renderer;
    private MaterialPropertyBlock _propBlock;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _propBlock = new MaterialPropertyBlock();
    }

    private void Update()
    {
        // Obtenemos el MaterialPropertyBlock actual
        _renderer.GetPropertyBlock(_propBlock);

        // Configuramos un color aleatorio
        _propBlock.SetColor("_Color", GetRandomColor());

        // Aplicamos el MaterialPropertyBlock al renderer
        _renderer.SetPropertyBlock(_propBlock);
    }

    private Color GetRandomColor()
    {
        int randomIndex = Random.Range(0, 3);
        switch (randomIndex)
        {
            case 0: return Color.red;
            case 1: return Color.green;
            case 2: return Color.blue;
            default: return Color.white;
        }
    }
}
