using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlaca : MonoBehaviour
{
    public bool pause;
    [SerializeField]
    float v = 0.02f;
    private float xAxis, zAxis;
    private Transform Mtransform;

    [SerializeField]
    float speed = 0.02f;
    // Use this for initialization
    void Start()
    {
        Mtransform = GetComponent<Transform>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "final")
        {
            Vector3 vec = new Vector3(0.16f, 4.767042f, -4.71f);
            Quaternion temp = new Quaternion(0, 0, 0, 0);
            gameObject.transform.SetPositionAndRotation(vec, temp);
        }
    }



    // Update is called once per frame
    void Update()
    {

        /*xAxis = Input.GetAxis("Horizontal");

                   zAxis = Input.GetAxis("Vertical");
                   Vector3 move = new Vector3(xAxis, 0, zAxis);
                   Mtransform.Translate(move * speed * Time.deltaTime);*/




        if (Time.timeScale == 1f)
        {

                transform.Translate(Vector3.forward * v);
            
        }

        if (Time.timeScale == 0f)
        {

             if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.forward * -v);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.forward * v);
            }
        }

        
        
       
           

     

    }



}