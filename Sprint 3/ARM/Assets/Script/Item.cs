using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemType Type;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Plane")
            return;
        transform.SetParent(collision.transform);
    }
}

public enum ItemType 
{
    Cube,
    Sphere,
    Oblong,
}