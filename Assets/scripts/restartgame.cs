using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restartgame : MonoBehaviour {
	
	public AudioClip se;

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource>().PlayOneShot(se);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			SceneManager.LoadScene("Open");
		}
		if (Input.GetButtonDown("Fire1")) {
			SceneManager.LoadScene("Open");
		}
		if (Input.GetButtonDown("Fire2")) {
			SceneManager.LoadScene("Open");
		}
		if (Input.GetButtonDown("Fire3")) {
			SceneManager.LoadScene("Open");
		}
	}
}
