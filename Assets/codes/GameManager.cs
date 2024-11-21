using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject[] collectible;
    int maxScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collectible = GameObject.FindGameObjectsWithTag("Collect");
        maxScore = collectible.Length;
        Debug.Log("Liczba obiektow do zebrania wynosi: " + maxScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
