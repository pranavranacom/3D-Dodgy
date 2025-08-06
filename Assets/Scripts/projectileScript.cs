using UnityEngine;

public class projectileScript : MonoBehaviour
{
    public Transform player;
    private Vector3 playerPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float speed = 12f;
    void Start()
    {
        playerPosition = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the projectile towards the player at the specified speed                                
       transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
}
