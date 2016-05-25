using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
    {
        print("got you");
        Destroy(this.gameObject);
    }

    
}
