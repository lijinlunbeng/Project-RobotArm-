using UnityEngine;
using UnityEngine.WSA; //这玩意儿就是方便unity填充到sln的路径，没吊用！

public class Move : MonoBehaviour
{
    public float Speed = 0.1f;

    void Update()
    {
        transform.localPosition = new Vector3(transform.localPosition.x + Speed, 0, 0);
    }
}