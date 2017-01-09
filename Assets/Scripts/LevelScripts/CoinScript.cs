using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

    public Vector3 angle;
    public AudioClip audioClip;
    public ParticleSystem particle;

    AudioSource audioSource;

    // Use this for initialization
    void Start () {
        Debug.Log("testes");
        if (audioClip) {
            Debug.Log("clip");
            audioSource = gameObject.GetComponentInParent<AudioSource>();
            audioSource.clip = audioClip;
        }
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(angle * Time.deltaTime);	
	}

    public void OnCollect()
    {
        if (audioSource)
        {
            audioSource.PlayOneShot(audioClip);
        }

        ParticleSystem obj = Instantiate(particle, transform.position + new Vector3(0.0f, 1f), transform.rotation);
        Destroy(obj, obj.main.duration);

        Destroy(gameObject);
    }
}
