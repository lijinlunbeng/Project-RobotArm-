using Boo.Lang;
using UnityEngine;

public class MovePlane : MonoBehaviour
{
    public GameObject Plane;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            var plane = Instantiate(Plane);
            plane.SetActive(true);
            plane.transform.SetParent(transform);
            plane.transform.localPosition = new Vector3(i * 10, 0, 0);
            plane.name = "Plane";
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name != "Plane")
            return;
        Destroy(collider.gameObject);
        var plane = Instantiate(Plane);
        plane.SetActive(true);
        plane.transform.SetParent(transform);
        plane.transform.localPosition = new Vector3(0, 0, 0);
        plane.name = "Plane";
    }
}