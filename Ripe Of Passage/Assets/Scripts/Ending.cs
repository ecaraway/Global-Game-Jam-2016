using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Ending : MonoBehaviour {

	public Animator daikon;
	public Animator tomato;

	// Use this for initialization
	void Start ( )
	{
		daikon.enabled = false;
		tomato.enabled = false;
		StartCoroutine ( Example1 ( ) );
		StartCoroutine ( Example2 ( ) );
	}

	IEnumerator Example1 ( )
	{
		yield return new WaitForSeconds ( 27 );
		daikon.enabled = true;
		tomato.enabled = true;
	}

	IEnumerator Example2 ( )
	{
		yield return new WaitForSeconds ( 33 );
		SceneManager.LoadScene ("Credits");
	}
}
