using System.Buffers;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdMover : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed = 5f;
    [SerializeField] InputAction Botton = new InputAction(type: InputActionType.Button);
    bool birdIsAlive = true;
   
    Manager logicManager;
    [SerializeField] string triggeringTag;

    void OnEnable()
    {
        // Enable the InputAction when the object is active
        Botton.Enable();
    }

    void OnDisable()
    {
        // Disable the InputAction when the object is disabled
        Botton.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        logicManager = GameObject.FindWithTag(triggeringTag).GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Botton.WasPressedThisFrame() && birdIsAlive)
        {
            rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicManager.GameOver();
        birdIsAlive = false;
    }
}
