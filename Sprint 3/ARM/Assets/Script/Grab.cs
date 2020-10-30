using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public MechanicalArm Arm;

    // 开始接触
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject != null && collider.gameObject.tag == "Item")
            Arm.Grab(collider.gameObject);
    }

    // 接触结束
    void OnTriggerExit(Collider collider)
    {

    }

    // 接触持续中
    void OnTriggerStay(Collider collider)
    {

    }
}
