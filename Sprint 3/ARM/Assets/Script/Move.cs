using UnityEngine;
using UnityEngine.WSA;

public class Move : MonoBehaviour
{
    public float Speed = 0.1f;

    void Update()
    {
        transform.localPosition = new Vector3(transform.localPosition.x + Speed, 0, 0);
    }
}