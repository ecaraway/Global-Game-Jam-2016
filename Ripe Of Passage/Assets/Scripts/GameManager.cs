using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public int numOfEnemies = 0;//LEAVE IT ZERO
    [SerializeField]
    private string nextLevel = "";

    
     
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollision2D(Collider2D col)
    {
        if (col.gameObject.name == "Player" && numOfEnemies == 0)
        {
            Application.LoadLevel(nextLevel);
        }
    }


}
