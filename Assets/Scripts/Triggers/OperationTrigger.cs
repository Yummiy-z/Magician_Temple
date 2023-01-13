using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationTrigger : MonoBehaviour
{
    bool inArea;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            inArea = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inArea = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inArea&&Input.GetMouseButtonDown(1))
        {
            TempleEvent.rotate?.Invoke();
        }
        //OnTriggerStay 执行频率不够高，所以在Update中检测
    }
}
