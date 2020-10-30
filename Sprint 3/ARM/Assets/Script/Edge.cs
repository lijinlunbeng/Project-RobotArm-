using UnityEngine;

public class Edge : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Item")
            Destroy(collider.gameObject);
    }
}