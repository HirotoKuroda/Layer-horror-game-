using UnityEngine;
using System.Collections;

//敵の動き制御。距離を考慮するタイプ
public class EnemyMove_useDistance : MonoBehaviour {

	public Transform player;    //プレイヤーを代入
	public float speed = 3; //移動速度
	public float limitDistance = 1000f; //敵キャラクターがどの程度近づいてくるか設定(この値以下には近づかない）
	public AudioClip se;
	float Timer = 0.0f;

	private Animator anim;

	public static bool enemy = true;

	private bool isGround = false;

	//ゲーム開始時に一度
	void Start () {
		//Playerオブジェクトを検索し、参照を代入
		player = GameObject.FindGameObjectWithTag("Player").transform;

		anim = GetComponent<Animator>();
	}

	//毎フレームに一度
	void Update () {
		
		if (gameover.dead==true) {
			this.enabled = false;
		}
		if (gameover.dead==false) {
			this.enabled = true;
		}
			Vector3 playerPos = player.position;                 //プレイヤーの位置
			Vector3 direction = playerPos - transform.position; //方向と距離を求める。
			float distance = direction.sqrMagnitude;            //directionから距離要素だけを取り出す。
			direction = direction.normalized;                   //単位化（距離要素を取り除く）
			direction.y = 0f;                                   //後に敵の回転制御に使うためY軸情報を消去。これにより敵上下を向かなくなる。

		if (enemy == true) {
			//プレイヤーの距離が一定未満であれば、敵キャラクターはプレイヤーへ近づく
			if (distance < limitDistance) {

				anim.SetBool ("Walk", true);

				//プレイヤーとの距離が制限値以内なので普通に近づく
				transform.position = transform.position + (direction * speed * Time.deltaTime);

				//プレイヤーの方を向く
				transform.rotation = Quaternion.LookRotation (direction);

				//重力落下処理（プレイヤーの距離関係なく下に移動する）
//		Vector3 rayPos = transform.position;
//		rayPos.y -= 1f;
//
//		//地面衝突判定処理。（今回は直接座標を操作しているため実装したが、直接座標操作はあまり好ましくないため
//		//後でUnityのキャラクター操作機能を用いた敵キャラクターの実装を紹介する。）
//		if (!Physics.Raycast(rayPos, Vector3.down, 0.5f)) {
//			//地面からわずかに浮くのは、わざとである。（キャラクター操作機能（CharacterControllerを用いれば起きない））
//			transform.position = transform.position + (Vector3.down * 9.8f * Time.deltaTime);
//		}
//		//地面判定線を見れるようにする
//		Debug.DrawRay (rayPos, Vector3.down*1/10);
//
//		//敵のY座標が-5以下の時自身を削除
//				if (transform.position.y <= -5f) {
//					Destroy(gameObject);
//				}

				if (Timer > 0) {

					Timer -= Time.deltaTime;

				}

				if (Timer <= 0) {
					Debug.Log ("タイマーが0になりました");
					GetComponent<AudioSource> ().PlayOneShot (se);
					Timer = 11.5f;
				}
			}
		} else if (enemy == false) {
			anim.SetBool ("Walk", false);
		}
		if (distance >= limitDistance) {
			anim.SetBool ("Walk", false);
			//			//プレイヤーとの距離が制限値以上なので、後退する。
			//			transform.position = transform.position - (direction * speed * Time.deltaTime);
		}
	}
}