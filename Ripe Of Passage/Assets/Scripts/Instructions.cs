using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Instructions : MonoBehaviour {

	public float timeLeft = 3.0f;

	// Update is called once per frame
	void Update () 
	{
		timeLeft -= Time.deltaTime;
		if ( timeLeft < 0 )
		{
			SceneManager.LoadScene ( "Level1" );
		}
		
	}
}
