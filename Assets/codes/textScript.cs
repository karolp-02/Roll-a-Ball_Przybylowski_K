using UnityEngine;
using TMPro;

public class textScript : MonoBehaviour
{
    public GameObject player;
    public TMP_Text scoreText;
    public MovementController mc;

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + mc.score;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mc = player.GetComponent<MovementController>();
        player = GameObject.FindGameObjectWithTag("Player");
        mc.pickupEvent += UpdateScoreText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
