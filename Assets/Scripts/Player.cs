using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public float positionSpeed = 10f;
    public float rotationSpeed = 60f;
    public float firstGame = 1f;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * positionSpeed * Time.fixedDeltaTime);
        //transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * positionSpeed * Time.fixedDeltaTime);
        //Translate����
        /*
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * rotationSpeed*Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down * rotationSpeed * Time.fixedDeltaTime);
        }
        */
        //transform.Rotate(Vector3.up * Input.GetAxis("Mouse X")*10);
        //transform.Rotate(Vector3.left * Input.GetAxis("Mouse Y") * 10); ;
        //transform.GetChild(0).localEulerAngles = new Vector3(Input.GetAxis("Vertical") * 10, 0, Input.GetAxis("Horizontal") * -10);
        //ֱ��ʹ��������ֵ��ûʹ��Translate
    }
    RaycastHit hitInfo;
    private void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (Input.GetMouseButtonDown(0))
        {

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        */
        if (Input.GetMouseButtonDown(0)&& Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
        {
            agent.SetDestination(hitInfo.point);
        }
    }
}
