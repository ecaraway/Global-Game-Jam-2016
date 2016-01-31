using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

	private SpriteRenderer sprite;
	private Animator anim;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("w") && Input.GetKey ("a") || Input.GetKey ("a") && Input.GetKey ("w")) {
			anim.SetInteger ("Direction", 1);
			sprite.flipX = false;
			Debug.Log("W+A");
		} else if (Input.GetKey ("w") && Input.GetKey ("d") || Input.GetKey ("d") && Input.GetKey ("w")) {
			anim.SetInteger ("Direction", 7);
			sprite.flipX = true;
			Debug.Log("W+D");
		}else if (Input.GetKey ("a") && Input.GetKey ("s") || Input.GetKey ("s") && Input.GetKey ("a")) {
			anim.SetInteger ("Direction", 3);
			sprite.flipX = false;
			Debug.Log("A+S");
		}else if (Input.GetKey ("s") && Input.GetKey ("d") || Input.GetKey ("d") && Input.GetKey ("s")) {
			anim.SetInteger ("Direction", 5);
			sprite.flipX = true;
			Debug.Log("S+D");
		}else if (Input.GetKey ("w")) {
			anim.SetInteger ("Direction", 0);
			sprite.flipX = false;
			Debug.Log("w");
		}else if (Input.GetKey ("a")) {
			anim.SetInteger ("Direction", 2);
			sprite.flipX = false;
			Debug.Log("a");
		}else if (Input.GetKey ("s")) {
			anim.SetInteger ("Direction", 4);
			sprite.flipX = false;
			Debug.Log("s");
		}else if (Input.GetKey ("d")) {
			anim.SetInteger ("Direction", 6);
			sprite.flipX = true;
			Debug.Log("d");
		}
	}
}
