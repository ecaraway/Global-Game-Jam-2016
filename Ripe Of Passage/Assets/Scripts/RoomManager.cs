using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RoomManager : MonoBehaviour 
{
	public int enemies;
	public GameObject arrow;
	public Image scroll;
	public Sprite replace;
	[HideInInspector]
	public bool levelClear = false;

	private void Start ( )
	{
		//Hide arrow
		arrow.SetActive ( false );
	}

	public void OnEnemyKill ( )
	{
		//Decrement enemy numbers
		enemies--;

		//Check for level clear
		if ( enemies <= 0 )
		{
			arrow.SetActive ( true );
			levelClear = true;
			scroll.sprite = replace;
		}
	}
}
