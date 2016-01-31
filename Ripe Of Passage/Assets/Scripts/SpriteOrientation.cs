using UnityEngine;
using System.Collections;

public class SpriteOrientation : MonoBehaviour {

	public string orientation;
	//public float rot;

	private SpriteRenderer sprite;
	private Animator anim;
	private SteeringBasics sb;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
		anim = GetComponent<Animator> ();
		sb = GetComponent<SteeringBasics> ();
	}
	
	// Update is called once per frame
	void Update () {
		//rotation in degrees
		//float rot = transform.localEulerAngles.z;
		//transform.rotation.Set(0,0,0,0);
		float rot = sb.rot;
		//rot = rotation;

		//MODSSS
		//if (rot < 0f) {
		//	rot = rot % -360f + 360f; //just convert to positive to keep things manageable
		//} else {
		//	rot = rot % 360f;
		//}

		//Handling of Sprite Direction
		if ( rot == 0 )
		{
			orientation = "0";
			anim.SetInteger ( "Direction", 4 );
			sprite.flipX = false;
		}
		else if (rot > 337.5f && rot < 360f || rot > 0f && rot <= 22.5f) {
			orientation = "U";
			//sprite.sprite = U;
			anim.SetInteger("Direction", 0);
			sprite.flipX = false;
			//sprite.flipY = false;
		}else if(rot > 22.5f && rot <= 67.5f) {
			orientation = "UL";
			//sprite.sprite = UL;
			anim.SetInteger("Direction", 1);
			sprite.flipX = false;
			//sprite.flipY = false;
		}else if(rot > 67.5f && rot <= 112.5f) {
			orientation = "L";
			//sprite.sprite = L;
			anim.SetInteger("Direction", 2);
			sprite.flipX = false;
			//sprite.flipY = false;
		}else if(rot > 112.5f && rot <= 157.5f) {
			orientation = "DL";
			//sprite.sprite = DL;
			anim.SetInteger("Direction", 3);
			sprite.flipX = false;
			//sprite.flipY = true;
		}else if(rot > 157.5f && rot <= 202.5f) {
			orientation = "D";
			//sprite.sprite = D;
			anim.SetInteger("Direction", 4);
			sprite.flipX = false;
			//sprite.flipY = true;
		}else if(rot > 202.5f && rot <= 247.5f) {
			orientation = "DR";
			//sprite.sprite = DR;
			anim.SetInteger("Direction", 5);
			sprite.flipX = true;
			//sprite.flipY = true;
		}else if(rot > 247.5f && rot <= 292.5f) {
			orientation = "R";
			//sprite.sprite = R;
			anim.SetInteger("Direction", 6);
			sprite.flipX = true;
			//sprite.flipY = false;
		}else if(rot > 292.5f && rot <= 337.5f) {
			orientation = "UR";
			//sprite.sprite = UR;
			anim.SetInteger("Direction", 7);
			sprite.flipX = true;
			//sprite.flipY = false;
		}
	}
}
