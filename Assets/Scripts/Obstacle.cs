using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] Creature player;

    [Header("Audio")]
    [SerializeField] AudioSource audioSource; // or GetComponent<AudioSource>()
    [SerializeField] AudioClip[] audioClips = new AudioClip[4];

    int clipIndex;

    // Start is called before the first frame update
    void Start()
    {    
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            // Decrement creature health
            player.DecrementHealth();

            clipIndex = Random.Range(0, 4);

            audioSource.PlayOneShot(audioClips[clipIndex]); // unity can handle up to 32 audio clips for each audo source

        }
    }
}
