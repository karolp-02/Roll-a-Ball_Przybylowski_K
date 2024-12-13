using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem collectParticle;
    private AudioSource collectSound;
    // Start is called before the first frame update
    void Start()
    {
        collectParticle = GetComponentInChildren<ParticleSystem>();
        collectSound = GameObject.Find("pickup").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        collectParticle.transform.parent = null; //odlaczam particle system od prefabu gracza aby nie znikal razem z nim
        collectParticle.Play();
        collision.gameObject.GetComponent<MovementController>().collectScore();
        collectSound.Play();
        Debug.Log("Zdobyto punkt");
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, (85 * Time.deltaTime), 0);
    }
}
