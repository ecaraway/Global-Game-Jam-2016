using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Stairs : MonoBehaviour {

	public RoomManager room;
	public string NextLevel;

	private void OnTriggerEnter2D ( Collider2D col )
	{
		if ( col.gameObject.tag == "Player" && room.levelClear )
		{
			Debug.Log ( "ok load" );
			SceneManager.LoadScene ( NextLevel );
		}
			
	}
}