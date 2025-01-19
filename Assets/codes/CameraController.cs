using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    public void updatePosition()
    {
        transform.position = offset + player.transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        updatePosition();
    }
}
