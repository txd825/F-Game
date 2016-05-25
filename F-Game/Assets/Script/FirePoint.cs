using UnityEngine;
using System.Collections;

public class FirePoint : MonoBehaviour {

    public GameObject bullet;
    public GameObject point;
    public float bulletspeed;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Mouse0))
        {
           if(Time.frameCount%5 == 0)
           {
                GameObject x = Instantiate(bullet);
                x.transform.position = point.transform.position;
                x.transform.up = point.transform.forward;
                x.GetComponent<Rigidbody>().velocity = point.transform.forward * bulletspeed*10;
           }
        }
	
	}
}
