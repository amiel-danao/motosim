using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MotorDetails : MonoBehaviour
{
    MotorbikeController motorbikeController;
    TMP_Text t1,t2,t3,t4,t5;
    GameObject c1,c2;
    WheelHit hit;
    void Start()
    {
        motorbikeController = FindObjectOfType<MotorbikeController>();
        t1 = GameObject.Find("Velocity").GetComponent<TMP_Text>();
        t2 = GameObject.Find("Lean").GetComponent<TMP_Text>();
        t3 = GameObject.Find("Omega").GetComponent<TMP_Text>();
        t4 = GameObject.Find("Steer").GetComponent<TMP_Text>();
        t5 = GameObject.Find("Rear").GetComponent<TMP_Text>();
        c1 = GameObject.Find("/MotorcycleWRider/WheelHolderForward/WCollider");
        c2 = GameObject.Find("/MotorcycleWRider/WheelHolderBack/WCollider");

    }

    // Update is called once per frame
    void Update()
    {
        var realSpeed = motorbikeController.rb.velocity.magnitude*2;
        t1.text = ((int)realSpeed).ToString();
        if(realSpeed>90)
            t1.color = Color.red;
        else
            t1.color = Color.white;
        var lean = motorbikeController.transform.eulerAngles.z<180?motorbikeController.transform.eulerAngles.z:motorbikeController.transform.eulerAngles.z-360;
        t2.text = "Lean Angle [deg] : " + lean;
        if(lean>40||lean<-40)
        t2.color = Color.red;
        else
        t2.color = Color.white;
        t3.text = "Control ω [rad⋅s−1] : " + motorbikeController.controlAngle;
        t4.text = "Steer Angle [deg] : " + c1.GetComponent<WheelCollider>().steerAngle;
        c2.GetComponent<WheelCollider>().GetGroundHit(out hit);
        t5.text = "Rear Grip Force [N] : " + hit.force;
    }
}
