using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    private int hitCount = 0;
    void OnCollisionEnter(Collision collisionedObject)
    {
        Debug.Log("Player hit something: " + collisionedObject.gameObject.name);
        hitCount++;
        Debug.Log("Hitpoints now: " + hitCount);

        if (collisionedObject.gameObject.CompareTag("Obstacle"))
        {
            ChangeColor(collisionedObject.gameObject, Color.black);
        }
    }

    private void ChangeColor(GameObject gameObject, Color color)
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer != null)
        {
            MeshRenderer collisionedObjectMeshRenderer = gameObject.GetComponent<MeshRenderer>();
            Material collisionedObjectMaterial = collisionedObjectMeshRenderer.material;
            collisionedObjectMaterial.color = color;
        }
    }
}
