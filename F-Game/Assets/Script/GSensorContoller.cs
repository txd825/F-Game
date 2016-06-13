using UnityEngine;  
using System.Collections;  
using System;  
  
public class GSensorContoller : MonoBehaviour
{
    public float RotateSpeed = 1.0f;
    private Transform myTransform = null;
    private float x = 0.0f;
    private float y = 0.0f;
    private float z = 0.0f;
    private Vector3 g;
    private float theta = 0.0f;
    private float phi = 0.0f;
    private float turnAngle = 0.0f;

    void Awake()
    {
        myTransform = transform;
    }

    // Use this for initialization  
    void Start()
    {
    }

    // Update is called once per frame  
    void Update()
    {
        Vector3 g1 = new Vector3(Input.acceleration.x, Input.acceleration.y, -Input.acceleration.z);
        if (Vector3.Angle(g, g1) > 1.0f) g = g1;
        theta = Mathf.PI - Mathf.PI * Vector3.Angle(g, Vector3.forward) / 180.0f;
        phi = Mathf.PI * 240.0f / 180.0f;
        x = Mathf.Sin(theta) * Mathf.Cos(phi);
        y = Mathf.Cos(theta);
        z = Mathf.Sin(theta) * Mathf.Sin(phi);
        Quaternion targetRotation = Quaternion.LookRotation(new Vector3(x, y, z), Vector3.up);

        float temp = Mathf.Sqrt(g.x * g.x + g.y * g.y);
        if (temp != 0) turnAngle = Mathf.Acos(-g.y / temp);
        else turnAngle = 0.0f;
        turnAngle = turnAngle * 180.0f / Mathf.PI * (g.x > 0.0f ? 1.0f : -1.0f);
        Quaternion targetTurn = Quaternion.AngleAxis(-turnAngle, Vector3.forward);

        myTransform.rotation = Quaternion.Slerp(myTransform.rotation, targetRotation * targetTurn, Time.deltaTime * RotateSpeed);
    }

    void OnGUI()
    {
        GUI.Box(new Rect(5, 5, 500, 25), String.Format("G  x:{0:0.000},y:{1:0.000},z:{2:0.000}", g.x, g.y, g.z));
        GUI.Box(new Rect(5, 35, 500, 25), String.Format("theta:{0:0.000},phi:{1:0.000},turn:{2:0.000}", theta, phi, turnAngle));
        GUI.Box(new Rect(5, 65, 500, 25), String.Format("Camera face  x:{0:0.000},y:{1:0.000},z:{2:0.000}", x, y, z));
        GUI.Box(new Rect(5, 95, 500, 25), String.Format("Camera rotate x:{0:0.000},y:{1:0.000},z:{2:0.000}",
            myTransform.rotation.eulerAngles.x, myTransform.rotation.eulerAngles.y, myTransform.rotation.eulerAngles.z));
    }

}