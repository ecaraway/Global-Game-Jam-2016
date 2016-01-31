using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CutsceneAudio : MonoBehaviour {

	public AudioClip a1, a2, a3, a4;
	private AudioSource audSource;
	private Animator anim;
	public AnimatorStateInfo asi;

	public bool a1HasPlayed, a2HasPlayed, a3HasPlayed, a4HasPlayed;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		audSource = GetComponent<AudioSource> ();

		//a2.LoadAudioData();
		a1HasPlayed = a2HasPlayed = a3HasPlayed = a4HasPlayed = false;
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log(anim.GetCurrentAnimatorStateInfo(0).tagHash.ToString());

		asi = anim.GetCurrentAnimatorStateInfo (0);
		if (asi.IsName ("Still Scenes")) {
			if(!a1HasPlayed){
				audSource.PlayOneShot (a1,2f);
				a1HasPlayed = true;
			}
		}else if (asi.IsName ("Still Scene 2")) {
			if(!a2HasPlayed){
				audSource.PlayOneShot (a2,1f);
				a2HasPlayed = true;
			}
		}else if (asi.IsName ("Still Scene 3")) {
			if(!a3HasPlayed){
				audSource.PlayOneShot (a3,1f);
				a3HasPlayed = true;
			}
		}else if (asi.IsName ("Cutscene Still 4")) {
			if(!a4HasPlayed){
				audSource.PlayOneShot (a4,1f);
				a4HasPlayed = true;
			}
		}

		if ( a4HasPlayed && !audSource.isPlaying )
			SceneManager.LoadScene ( "Instructions" );
	}
}
