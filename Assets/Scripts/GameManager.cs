using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform player, rotateCube;
    public GameObject[] lights;
    public GameObject fence;
    public static Action<int> action;
    // Start is called before the first frame update
    void Start()
    {
        //���Ľ�ɫλ��
        TempleEvent.transmit+=Position;
        //���õƵ�״̬�����رպ��
        TempleEvent.figure+=Test;
        //Χ����״̬,�򻯸�ʽд��
        TempleEvent.pass+=(() => { fence.SetActive(false); });
        //������ת45��
        TempleEvent.rotate+= () => {rotateCube.Rotate(Vector3.up*45,Space.Self); };
        //CountRotate(() => { rotateCube.Rotate(Vector3.up * 45, Space.Self); });
        GameManager.action += PrintHello;
        GameManager.action += PrintNumber;
        GameManager.action += DebugNumber;
        Foreach(action);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Position(Transform pos)
    {
        player.position = pos.position;
        player.rotation = pos.rotation;
    }
    private void Test(int index)
    {
        TempleStates.SetMachineStates(index);
        lights[index].SetActive(false);
    }
    /*
    private void CountRotate(Action rotate)
    {

        rotate?.Invoke();
    }
    */
    private void Foreach(Action<int> action)
    {
        for(int i = 1; i < 11; i++)
        {
            action?.Invoke(i);
        }
    }
    private void PrintNumber(int num)
    {
        if (num % 2 !=0)
        {
            print(num+1);

        }
        
    }
    private void DebugNumber(int num)
    {
        if (num%2==0)
        {
            print(num);

        }
    }
    private void PrintHello(int num)
    {
        if (num%3==0)
        {
            print("Hello World!");

        }   
    }
}
