using UnityEngine;
using UnityEngine.SceneManagement;

public class startStopScript : MonoBehaviour
{
    public Rigidbody rb;
    private bool stop = false;
    private float timer = 0;
    private float stopTime = 5;
    private float startTime = 5;

    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public Material red;
    public Material green;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= startTime + stopTime)
        {
            timer = 0f;
        }

        stop = timer >= startTime;

        if (stop)
        {
            setEmission(light1, red);
            setEmission(light2, red);
            setEmission(light3, red);

            if (rb.linearVelocity.magnitude > 0.2f)
            {
                SceneManager.LoadScene("poziom03");
            }
        }
        else
        {
            setEmission(light1, green);
            setEmission(light2, green);
            setEmission(light3, green);
        }
    }

    // Funkcja pomocnicza do ustawiania materiału i odświeżania emisji
    private void setEmission(GameObject obj, Material material)
    {
        Renderer renderer = obj.GetComponent<Renderer>();
        renderer.material = material;

        // Pobierz kolor emisji z materiału
        Color emissionColor = material.GetColor("_EmissionColor");

        // Wymuś odświeżenie emisji dla Global Illumination
        DynamicGI.SetEmissive(renderer, emissionColor);
    }
}
