using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class open : MonoBehaviour {

	public AudioClip se;

	private float startTime = 0; 
	bool putJump;
	bool sound1;
	private float deltaTime;

	// Use this for initialization
	void Start () {
		putJump = false;
		deltaTime = 0;
		sound1 = true;
	}

	// Update is called once per frame
	void Update () {
		Debug.Log (deltaTime);

		if (Input.GetButtonDown("Jump")) {
			putJump = true;

			if (sound1) {
				GetComponent<AudioSource>().PlayOneShot(se);
				sound1 = false;
			}
		}

		if (putJump == false) {
			startTime = Time.time;
		} 
		if (Input.GetButtonDown("Fire1")) {
			putJump = true;

			if (sound1) {
				GetComponent<AudioSource>().PlayOneShot(se);
				sound1 = false;
			}
		}

		if (putJump == false) {
			startTime = Time.time;
		} 
		if (Input.GetButtonDown("Fire2")) {
			putJump = true;

			if (sound1) {
				GetComponent<AudioSource>().PlayOneShot(se);
				sound1 = false;
			}
		}

		if (putJump == false) {
			startTime = Time.time;
		} 
		if (Input.GetButtonDown("Fire3")) {
			putJump = true;

			if (sound1) {
				GetComponent<AudioSource>().PlayOneShot(se);
				sound1 = false;
			}
		}

		if (putJump == false) {
			startTime = Time.time;
		} 

		deltaTime = Time.time - startTime;

		if (deltaTime > 2.0f) {
			SceneManager.LoadScene ("Untitled");

		}
	}
}
