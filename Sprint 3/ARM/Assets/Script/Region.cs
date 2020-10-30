using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Region : MonoBehaviour
{
    public MechanicalArm Arm;

    // 开始接触
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Item")
            Arm.StartGrab();
    }

    // 接触结束
    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Item")
            Arm.Standby();
    }

    // 接触持续中
    void OnTriggerStay(Collider collider)
    {

    }
}
