using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rawan : MonoBehaviour
{  public Texture collisionTexture; // The texture to change to when a collision occurs
private Renderer objectRenderer; // Reference to the object's renderer
private Texture originalTexture; // The object's original texture

private void Start()
{
    objectRenderer = GetComponent<Renderer>();
    originalTexture = objectRenderer.material.mainTexture;
}

private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.tag == "TextureChangeTag")
    {
        objectRenderer.material.mainTexture = collisionTexture;
    }
}

private void OnCollisionExit(Collision collision)
{
    objectRenderer.material.mainTexture = originalTexture;
}
}