using UnityEngine;

public class Dropper : MonoBehaviour
{
    public int timer = 3;
    private Rigidbody rb;
    private bool hasDropped = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasDropped == false)
        {
            if (Time.time > timer)
            {
                rb.useGravity = true;
                hasDropped = true;
                Debug.Log("Object has dropped and gravity is now enabled.");
            }
        }
    }
}
