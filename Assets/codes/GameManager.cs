using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    private GameObject[] collectible;
    int maxScore;
    public MovementController mc;

    private void UpdateLevel()
    {
        if (mc.score == maxScore && maxScore == 8)
        {
            SceneManager.LoadScene("poziom02");
        }
        else if (mc.score == maxScore && maxScore == 13)
             {
                 SceneManager.LoadScene("poziom03");
             }
        else if (mc.score == maxScore && maxScore == 4)
             {
                 SceneManager.LoadScene("endScene");
             }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        mc = player.GetComponent<MovementController>();
        collectible = GameObject.FindGameObjectsWithTag("Collect");
        maxScore = collectible.Length;
        Debug.Log("Liczba obiektow do zebrania wynosi: " + maxScore);
        mc.changeEvent += UpdateLevel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
