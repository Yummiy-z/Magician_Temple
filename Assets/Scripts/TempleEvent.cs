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
    Action�������ռ�System��һ���������ͱ�������������ί�У���֧���Է�����ʽ��������
    ��Ч��������*/
    public static Action<int> figure;
    public static Action rotate, pass;
    //���б���������Ϊ��̬���Ա�ֱ��ͨ����������
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
