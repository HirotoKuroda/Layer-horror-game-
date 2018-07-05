using UnityEngine;
using System.Collections;

public class lightcontroller : MonoBehaviour {

	public GameObject ll;
	public AudioClip se;
	public bool lightSwitch = true ;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire3")) {
			GetComponent<AudioSource>().PlayOneShot(se);

			if (lightSwitch == true) {
				Debug.Log ("light turn off");
				ll.SetActive (false);
				EnemyMove_useDistance.enemy = false;
				lightSwitch = false;
			}else if(lightSwitch==false){
				Debug.Log ("light turn on");
				ll.SetActive (true);
				EnemyMove_useDistance.enemy = true;
				lightSwitch = true;
			}
		}
	}
}