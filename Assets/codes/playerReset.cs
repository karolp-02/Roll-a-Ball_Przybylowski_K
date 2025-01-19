using UnityEngine;
using UnityEngine.SceneManagement;

public class playerReset : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // reset poziomu gdy gracz wypadnie poza mape
        SceneManager.LoadScene("poziom02");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
