using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballroll : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float Hmove =Input.GetAxis("Horizontal");
        float Vmove =Input.GetAxis("Vertical");
        Vector3 ballmove= new Vector3(Hmove,0.0f,Vmove);
        rb.AddForce(ballmove);
    }
}
