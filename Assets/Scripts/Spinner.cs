using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private Vector3 rotateAngles = new Vector3(0, 100, 0);
    // Update is called once per frame
    void Update()
    {
        // Make the object rotate in Y axis at a speed of 100 degrees per second
        transform.Rotate(rotateAngles * Time.deltaTime, Space.Self);
    }
}
