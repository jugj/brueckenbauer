using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musik : MonoBehaviour
{
    public AudioClip normalMusik;
    public AudioClip hoehleMusik;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = normalMusik;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x >= 18 && gameObject.transform.position.x <= 64 && audioSource.clip != hoehleMusik) {
            audioSource.clip = hoehleMusik;
            audioSource.Play();
        }
        else if((gameObject.transform.position.x < 18 || gameObject.transform.position.x > 64) && audioSource.clip != normalMusik) {
            audioSource.clip = normalMusik;
            audioSource.Play();
        }
    }
}
