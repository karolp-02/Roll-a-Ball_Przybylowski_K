using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private AudioSource collectSound;
    // Start is called before the first frame update
    void Start()
    {
        collectSound = GameObject.Find("pickup").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collision)
    {
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
