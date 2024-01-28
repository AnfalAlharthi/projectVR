using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spill: MonoBehaviour
{

    ParticleSystem _particleSystem;
    //  public AudioSource _audioSource;
    public SoundManager aa;

    void Start()
    {
        _particleSystem = GetComponent<ParticleSystem>();
        //  _audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Angle(Vector3.down, transform.forward) < 80f)

        {

            _particleSystem.Play();
            aa.PlayPlayer();

            // _audioSource.Play();
        }


        else
        {
            _particleSystem.Stop();
            // _audioSource.Stop();
        }



    }
}