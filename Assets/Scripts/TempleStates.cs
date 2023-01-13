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
                return;//figured中有false则返回（说明有机关未破解）指退出整个方法，退出SetMachineStates
            }
        }
        if (TempleEvent.pass!=null)//如果委托不为空（即委托绑定了术），则发布委托
        {
            TempleEvent.pass?.Invoke();
        }
    }
    
   
}
