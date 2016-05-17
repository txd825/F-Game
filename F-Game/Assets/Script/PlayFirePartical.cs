
using UnityEngine;
using System.Collections;

public class PlayFirePartical : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
       /** if (Input.GetKey(KeyCode.Mouse0))
        {
            gameObject.GetComponent<ParticleSystem>().Play();
            gameObject.GetComponent<ParticleSystem>().Pause();
            gameObject.GetComponent<ParticleSystem>().Stop();
        }**/
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            gameObject.GetComponent<ParticleSystem>().Play();
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            //gameObject.GetComponent<ParticleSystem>().Pause();
            gameObject.GetComponent<ParticleSystem>().Stop();
        }

    }
}
