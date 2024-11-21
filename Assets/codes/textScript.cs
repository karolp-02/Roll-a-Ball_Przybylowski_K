using UnityEngine;
using TMPro;
using UnityEditor.Build;

public class textScript : MonoBehaviour
{
    public GameObject player;
    public TMP_Text scoreText;

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + player.score;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.pickupEvent += UpdateScoreText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
