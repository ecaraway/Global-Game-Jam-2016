using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
	public Image eye;
	public GameObject pupil;
	public Sprite open;
	public Sprite close;

	public float openTimer = 5f;
	public float closeTimer = 0.3f;
	private float currentTimer;

	private bool isOpen = true;

	private void Start ()
	{
		currentTimer = openTimer;
	}

	private void Update ()
	{
		currentTimer -= Time.deltaTime;
		if ( currentTimer < 0 )
		{
			if ( isOpen )
			{
				eye.sprite = close;
				pupil.SetActive ( false );
				currentTimer = closeTimer;
				isOpen = false;
			}
			else
			{
				eye.sprite = open;
				pupil.SetActive ( true );
				currentTimer = openTimer;
				isOpen = true;
			}
		}
	}

	public void OnStartClick()
	{
		SceneManager.LoadScene ( "Opening Cutscene" );
	}

	public void OnQuitClick()
	{
		Application.Quit ( );
	}
}
