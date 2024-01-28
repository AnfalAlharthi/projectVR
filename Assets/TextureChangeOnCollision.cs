using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureChangeOnCollision : MonoBehaviour
{

    public Texture collisionTexture; // The texture to change to when a collision occurs
    private Renderer objectRenderer; // Reference to the object's renderer

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        objectRenderer.material.mainTexture = collisionTexture;
    }
}