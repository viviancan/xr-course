using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandMove : MonoBehaviour
{
    public Transform location;
    public Vector3 position;
    public float moveSpeed;
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) | Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow) | Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }


        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed, Space.Self);
        }
        
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * turnSpeed, Space.Self);
        }
        
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * turnSpeed, Space.Self);
        }
        
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * turnSpeed, Space.Self);
        }
        

        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.C))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * turnSpeed, Space.Self);
        }

        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * turnSpeed, Space.Self);
    }
    public void DoSprint()
    {
        Debug.Log($"{transform.position}");
    }
}
