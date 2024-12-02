using Unity.VisualScripting;
using UnityEngine;

public class MiddlePipe : MonoBehaviour
{
    Manager logicManager;
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            logicManager.AddPoint(1);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicManager = GameObject.FindWithTag(triggeringTag).GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
