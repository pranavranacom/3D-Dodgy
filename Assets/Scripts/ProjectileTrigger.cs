using UnityEngine;

public class ProjectileTrigger : MonoBehaviour
{
    [SerializeField] GameObject[] projectileGroups;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Projectile triggered by: " + other.gameObject.name);
            foreach (GameObject projectileGroup in projectileGroups)
            {
                projectileGroup.SetActive(true);
            }
        }
    }
}
