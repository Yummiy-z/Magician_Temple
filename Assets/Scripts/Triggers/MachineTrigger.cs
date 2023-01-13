using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineTrigger : MonoBehaviour
{
    public int index;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="machineTrigger")
        {
            TempleEvent.figure?.Invoke(index);
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
