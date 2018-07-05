using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour {

	public Transform player;
	public float limitDistance = 1000f;

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

				SceneManager.LoadScene("Clear");
			}
		}
}
