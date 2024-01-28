using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource a;
    [SerializeField] public AudioClip Player;


    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.AudioClip Player = a.clip;
    }

    // Update is called once per frame
    public void PlayPlayer()
    {

        a.PlayOneShot(Player);
    }
}