using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    private int hitCount = 0;

    void OnCollisionEnter(Collision collisionedObject)
    {
        Debug.Log("Player hit something: " + collisionedObject.gameObject.name);

        if (collisionedObject.gameObject.name != "Land")
        {
            MeshRenderer collisionedObjectMeshRenderer = collisionedObject.gameObject.GetComponent<MeshRenderer>();
            Material collisionedObjectMaterial = collisionedObjectMeshRenderer.material;
            collisionedObjectMaterial.color = Color.black;
            hitCount++;
            Debug.Log("Hitpoints now: " + hitCount);
        }
    }
}
