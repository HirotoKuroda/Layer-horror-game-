using UnityEngine;
using System.Collections;

public class voice : MonoBehaviour {
	
	public AudioClip se;
	float Timer = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Timer > 0) {

			Timer -= Time.deltaTime;

		}

		if (Timer <= 0) {
			Debug.Log("タイマーが0になりました");
			GetComponent<AudioSource>().PlayOneShot(se);
			Timer=8.5f;
		}

	}
}
