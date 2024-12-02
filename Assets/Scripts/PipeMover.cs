using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float deadZone = -25;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
