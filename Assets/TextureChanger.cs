using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureChanger : MonoBehaviour
{
    public Material newMaterial; // The material with the new texture

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is happening with the desired object
        if (collision.gameObject.CompareTag("OtherObject"))
        {
            // Change the material of the object to the new material
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material = newMaterial;
        }
    }
}