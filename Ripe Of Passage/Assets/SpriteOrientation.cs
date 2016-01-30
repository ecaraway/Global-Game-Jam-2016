using UnityEngine;
using System.Collections;

public class SpriteOrientation : MonoBehaviour {

	public string orientation;
	//public float rot;

	public SpriteRenderer sprite;
	public Sprite U, UL, L, DL, D, DR, R, UR;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		//rotation in degrees
		float rotation = transform.localEulerAngles.z;
		//rot = rotation;

		//MODSSS
		if (rotation < 0f) {
			rotation = rotation % -360f + 360f; //just convert to positive to keep things manageable
		} else {
			rotation = rotation % 360f;
		}

		//Handling of Sprite Direction
		if (rotation > 337.5f && rotation < 360f || rotation >= 0f && rotation <= 22.5f) {
			orientation = "U";
			//sprite.sprite = U;
		}else if(rotation > 22.5f && rotation <= 67.5f) {
			orientation = "UL";
			//sprite.sprite = UL;
		}else if(rotation > 67.5f && rotation <= 112.5f) {
			orientation = "L";
			//sprite.sprite = L;
		}else if(rotation > 112.5f && rotation <= 157.5f) {
			orientation = "DL";
			//sprite.sprite = DL;
		}else if(rotation > 157.5f && rotation <= 202.5f) {
			orientation = "D";
			//sprite.sprite = D;
		}else if(rotation > 202.5f && rotation <= 247.5f) {
			orientation = "DR";
			//sprite.sprite = DR;
		}else if(rotation > 247.5f && rotation <= 292.5f) {
			orientation = "R";
			//sprite.sprite = R;
		}else if(rotation > 292.5f && rotation <= 337.5f) {
			orientation = "UR";
			//sprite.sprite = UR;
		}
	}
}
