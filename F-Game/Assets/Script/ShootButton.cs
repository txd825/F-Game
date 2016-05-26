using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;

public class ShootButton : MonoBehaviour {

    public GameObject bullet;
    public GameObject point;
    public float bulletspeed;
    public GameObject firepartical;

    public void pull()
    {

        print("你成功了");
        GameObject x = Instantiate(bullet);
        x.transform.position = point.transform.position;
        x.transform.up = point.transform.forward;
        x.GetComponent<Rigidbody>().velocity = point.transform.forward * bulletspeed * 10;
        firepartical.GetComponent<ParticleSystem>().Play();


    }
}
