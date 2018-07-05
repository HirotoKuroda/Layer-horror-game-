using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {

	public Transform player;
	public float limitDistance = 1000f;
	public AudioClip se;
	private bool scene = false;
	float Timer = 1.3f;
	public static bool dead = false;

	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	// Update is called once per frame
	void Update () {
		
		Vector3 playerPos = player.position;                 //プレイヤーの位置
		Vector3 direction = playerPos - transform.position; //方向と距離を求める。
		float distance = direction.sqrMagnitude;            //directionから距離要素だけを取り出す。
		direction = direction.normalized;                   //単位化（距離要素を取り除く）
		direction.y = 0f; 

		if (distance < limitDistance){
			if (Timer == 1.3f) {
				GetComponent<AudioSource> ().PlayOneShot (se);
				dead = true;
//				
			}
			if (Timer > 0) {
				Timer -= Time.deltaTime;
			}

			if (Timer <= 0) {
				Debug.Log ("タイマーが0になりました");
				dead = false;
				SceneManager.LoadScene("GameOVER");
			}
		}
	}
//	public static bool getDead(){
//		return dead;
//	}
}