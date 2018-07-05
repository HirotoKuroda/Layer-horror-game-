using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour {

	// Use this for initialization
	void Start () {

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
