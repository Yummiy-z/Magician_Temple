using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleStates : MonoBehaviour
{
    static bool[] figured = new bool[2];
    public static void SetMachineStates(int index)
    {
        if (index<0||index>=figured.Length)
        {
            return;
        }
        figured[index] = true;
        foreach(bool f in figured)
        {
            if (!f)
            {
                return;//figured����false�򷵻أ�˵���л���δ�ƽ⣩ָ�˳������������˳�SetMachineStates
            }
        }
        if (TempleEvent.pass!=null)//���ί�в�Ϊ�գ���ί�а����������򷢲�ί��
        {
            TempleEvent.pass?.Invoke();
        }
    }
    
   
}
