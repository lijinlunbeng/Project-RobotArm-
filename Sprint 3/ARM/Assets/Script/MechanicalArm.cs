using DG.Tweening; //中间计算
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering; //呈现

public class MechanicalArm : MonoBehaviour
{
    public List<Node> NodeList = new List<Node>();
    public GameObject Claw;
    public GameObject Container;
    private GameObject target;
    private bool isGrab;
    private bool isStartGrab;
    public UI UI;

    public float GrabTime = 1;
    public float PlaceTime = 1;
    public float StandbyTime = 1;

    public uint ContainerMax;
    private List<GameObject> itemList = new List<GameObject>();

    //更新
    private void Update()
    {
        if (isGrab && target != null)
            target.transform.position = Claw.transform.position;
        //var angle = NodeList[0].transform.position - target.transform.position;
        //Quaternion rotate = Quaternion.LookRotation(angle);
        //NodeList[0].transform.DORotate(new Vector3(rotate.eulerAngles.x - 60, rotate.eulerAngles.y + 180, rotate.eulerAngles.z), 0.5f, RotateMode.Fast);
        //angle = NodeList[1].transform.position - target.transform.position;
        //rotate = Quaternion.LookRotation(angle);
        //NodeList[1].transform.DORotate(new Vector3(rotate.eulerAngles.x + 30, rotate.eulerAngles.y + 180, rotate.eulerAngles.z), 1f, RotateMode.Fast);
        //angle = NodeList[2].transform.position - target.transform.position;
        //rotate = Quaternion.LookRotation(angle);
        //NodeList[2].transform.DORotate(new Vector3(rotate.eulerAngles.x + 80, rotate.eulerAngles.y + 180, rotate.eulerAngles.z), 1.5f, RotateMode.Fast);
    }

    public void StartGrab()
    {
        if (isStartGrab)
            return;
        isStartGrab = true;
        //Debug.LogError("开始抓取");
        //x,y,z
        NodeList[0].transform.DORotate(new Vector3(-50, transform.localEulerAngles.y - 180, NodeList[0].transform.eulerAngles.z), GrabTime, RotateMode.Fast);
        NodeList[1].transform.DORotate(new Vector3(0, transform.localEulerAngles.y - 180, NodeList[1].transform.eulerAngles.z), GrabTime, RotateMode.Fast);
        NodeList[2].transform.DORotate(new Vector3(50, transform.localEulerAngles.y - 180, NodeList[2].transform.eulerAngles.z), GrabTime, RotateMode.Fast);
    }

    //nodelist代表了关节点 0代表了底座 1代表了第二个圆球 2代表了头顶圆球

    public void Standby()
    {
        if (!isGrab && !isStartGrab)
        {
            //Debug.LogError("待机");
            NodeList[0].transform.DORotate(new Vector3(-60, transform.localEulerAngles.y - 180, NodeList[0].transform.eulerAngles.z), StandbyTime, RotateMode.Fast);
            NodeList[1].transform.DORotate(new Vector3(0, transform.localEulerAngles.y - 180, NodeList[1].transform.eulerAngles.z), StandbyTime, RotateMode.Fast);
            NodeList[2].transform.DORotate(new Vector3(0, transform.localEulerAngles.y - 180, NodeList[2].transform.eulerAngles.z), StandbyTime, RotateMode.Fast);
        }
    }

    public void Place()
    {
        //Debug.LogError("释放");
        NodeList[0].transform.DORotate(new Vector3(-60, transform.localEulerAngles.y, NodeList[0].transform.eulerAngles.z), PlaceTime, RotateMode.Fast);
        NodeList[1].transform.DORotate(new Vector3(-20, transform.localEulerAngles.y, NodeList[1].transform.eulerAngles.z), PlaceTime, RotateMode.Fast);
        NodeList[2].transform.DORotate(new Vector3(0, transform.localEulerAngles.y, NodeList[2].transform.eulerAngles.z), PlaceTime, RotateMode.Fast);
        DOVirtual.Float(0, PlaceTime, 1f, (float time) =>
        {
            if (time == PlaceTime)
            {
                isStartGrab = false;
                isGrab = false;
                Standby();
                target.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                DOVirtual.Float(0, 0.5f, 0.5f, (float time2) =>
                {
                    if (time2 == 0.5f && itemList.Count >= ContainerMax)
                    {
                        itemList.ForEach(x =>
                        {
                            Destroy(x); //把盒子里的去掉！
                        });
                        itemList.Clear();
                    }
                });
            }
        });
    }

    public void Grab(GameObject grabTarget)
    {
        if (isGrab)
            return;
        //Debug.LogError("抓到目标");
        isGrab = true;
        target = grabTarget;
        Place();
        var item = grabTarget.GetComponent<Item>();
        UI.AddItem(item);
        grabTarget.transform.SetParent(Container.transform);
        itemList.Add(target);
    }
}