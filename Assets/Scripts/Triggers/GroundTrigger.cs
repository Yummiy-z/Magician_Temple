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
            //ί�е����Ű��������ߵ�ʵ�Σ���ί�з���ʱ�����Ŵ���ʵ�Σ�ִ�ж����˸�ί�еķ�����ʹ�øò���
            //Ҳ����д��transmit?.Invoke(targerPose) ,��event(�¼�����Ϊnull��ȷ���¼��Ƿ��ж����ߣ���invoke������C#6�����﷨�� ?.��Ϊ��ֵ�����������
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
