using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Splash : MonoBehaviour 
{
	public GameObject ggj;
	public GameObject name;

	private void Start ( )
	{
		name.SetActive ( false );
		StartCoroutine ( Example1 ( ) );
		StartCoroutine ( Example2 ( ) );
	}

	IEnumerator Example1 ( )
	{
		yield return new WaitForSeconds ( 3 );
		ggj.SetActive ( false );
		name.SetActive ( true );
	}

	IEnumerator Example2 ( )
	{
		yield return new WaitForSeconds ( 6 );
		SceneManager.LoadScene ( "TitleSceen" );
	}

}
