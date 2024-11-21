using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class MovementController : MonoBehaviour
{
    public event Action pickupEvent;
    public TMP_Text scoreText;
    public int score;
    private Rigidbody rb;
    public float thrust = 1;

    public void collectScore()
    {
        score++;
        pickupEvent();
        if (score == 8)
        {
            SceneManager.LoadScene("poziom02");
        }
        else
            scoreText.text = "Score: " + score;

        if (score == 11)
        {
            SceneManager.LoadScene("endScene");
        }
    }

    public void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(0, 0, thrust, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(0, 0, -thrust, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(-thrust, 0, 0, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(thrust, 0, 0, ForceMode.Acceleration);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }
}
