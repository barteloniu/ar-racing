using UnityEngine;
using System.Collections;

public class auto : MonoBehaviour {

    public float maxSpeed;
    public float maxSteerAngle;

    public WheelCollider fl;
    public WheelCollider fr;
    public WheelCollider bl;
    public WheelCollider br;

	void Start ()
    {
	
	}
	
	void FixedUpdate ()
    {
        float speed = maxSpeed * Input.GetAxis("Vertical");
        float angle = maxSteerAngle * Input.GetAxis("Horizontal");
        fl.motorTorque = speed;
        fr.motorTorque = speed;
        bl.motorTorque = speed;
        br.motorTorque = speed;

        fl.steerAngle = angle;
        fr.steerAngle = angle;
	}
}
