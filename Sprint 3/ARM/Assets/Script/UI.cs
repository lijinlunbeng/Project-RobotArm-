using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text Cube;
    public Text Sphere;
    public Text Oblong;

    public uint CubeNumber;
    public uint SphereNumber;
    public uint OblongNumber;

    public void AddItem(Item item)
    {
        switch (item.Type)
        {
            case ItemType.Cube:
                CubeNumber++;
                Cube.text = "Cube Count：" + CubeNumber;
                break;
            case ItemType.Sphere:
                SphereNumber++;
                Sphere.text = "Sphere Count：" + SphereNumber;
                break;
            case ItemType.Oblong:
                OblongNumber++;
                Oblong.text = "Oblong Count：" + OblongNumber;
                break;
        }
    }
}
