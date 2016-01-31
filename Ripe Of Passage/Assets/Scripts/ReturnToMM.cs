using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ReturnToMM : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ( Example ( ) );
	}

	IEnumerator Example ( )
	{
		yield return new WaitForSeconds ( 10 );
		SceneManager.LoadScene ( "TitleScreen" );
	}
}
