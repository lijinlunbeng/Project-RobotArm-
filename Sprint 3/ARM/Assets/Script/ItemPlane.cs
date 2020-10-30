using DG.Tweening;
using UnityEngine;

public class ItemPlane : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Sphere;
    public GameObject Oblong;
    
    public float CreateTime = 1;

    public void Start()
    {
        DOVirtual.Float(0, CreateTime, 1f, (float time) =>
        {
            if (time == CreateTime)
                Create();
        });
    }

    public void Create()
    {
        var random = Random.Range(1, 4);
        switch (random)
        {
            case 1:
                var cube = Instantiate(Cube);
                cube.SetActive(true);
                break;
            case 2:
                var sphere = Instantiate(Sphere);
                sphere.SetActive(true);
                break;
            case 3:
                var oblong = Instantiate(Oblong);
                oblong.SetActive(true);
                break;
        }
        DOVirtual.Float(0, CreateTime, 1, (float time) =>
        {
            if (time == CreateTime)
                Create();
        });
    }
}