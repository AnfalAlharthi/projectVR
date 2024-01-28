using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture2D brushTexture; // Assign the desired brush texture in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        Renderer renderer = other.GetComponent<Renderer>();
        if (renderer != null)
        {
            Material material = renderer.material;
            material.SetTexture("_MainTex", brushTexture);
        }
    }
}