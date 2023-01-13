using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events; 
public class TempleEvent : MonoBehaviour
{
    public static Action<Transform> transmit;
    /*public delegate void _Action(Transform newText);   
    public static _Action transmit = Print;
    Action是命名空间System的一个特殊类型变量，该类型是委托，且支持以泛型形式设置术因
    等效于这两行*/
    public static Action<int> figure;
    public static Action rotate, pass;
    //所有变量都声明为静态，以便直接通过类名访问
    //Start is called before the first frame update
    //public static UnityEvent<Transform> transmit;
    //public static UnityEvent<int> figure;
    //public static UnityEvent rotate, pass;
    public UnityEvent<int> action;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
