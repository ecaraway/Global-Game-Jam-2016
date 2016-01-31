using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MusicManager : MonoBehaviour {

	static MusicManager _instance;

	public AudioSource audio;

	static public bool isActive
	{
		get
		{
			return _instance != null;
		}
	}

	static public MusicManager instance
	{
		get
		{
			if ( _instance == null )
			{
				_instance = Object.FindObjectOfType ( typeof ( MusicManager ) ) as MusicManager;

				if ( _instance == null )
				{
					GameObject go = new GameObject ( "_musicmanager" );
					DontDestroyOnLoad ( go );
					_instance = go.AddComponent<MusicManager> ( );
				}
			}
			return _instance;
		}
	}

	private void OnLevelWasLoaded ()
	{
		string name = SceneManager.GetActiveScene().name;
		Debug.Log ( name );
		if ( name == "Instructions" || name == "Level1" || name == "Level2" || name == "Level3" )
		{
			if ( !audio.isPlaying )
				audio.Play ( );
		}
		else
		{
			audio.Stop ( );
		}
	}
}
