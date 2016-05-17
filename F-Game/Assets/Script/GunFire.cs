using UnityEngine;
using System.Collections;

public class GunFire : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if(Time.frameCount%5 == 0)
            {
                print("fire");
               
            }
        }
	
	}

    
}
