using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class GroundTrigger : MonoBehaviour
{
    public Transform targetPose;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            TempleEvent.transmit?.Invoke(targetPose);
            //委托的括号包括订阅者的实参，当委托发布时，括号传入实参，执行订阅了该委托的方法，使用该参数
            //也可以写作transmit?.Invoke(targerPose) ,若event(事件）不为null，确认事件是否有订阅者，则invoke，这是C#6的新语法。 ?.称为空值传播运算符。
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
