using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

	private bool soundplayed=false;

	// Update is called once per frame
	void Update () {
		if (!soundplayed && transform.localPosition.y < 0.05f) {
			soundplayed = true;
			StartCoroutine (DelayPlaysound ());
		}
	}
		
	IEnumerator DelayPlaysound(){
		yield return new WaitForSeconds (.2f);
		GetComponent<AudioSource> ().Play ();
	}

	public void movecar(){
		transform.localPosition += new Vector3 (0,10,0);
		transform.eulerAngles += new Vector3 (5, 20, 5);
		soundplayed = false;
	}
}
