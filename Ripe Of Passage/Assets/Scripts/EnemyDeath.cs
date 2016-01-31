using UnityEngine;
using System.Collections;

public class EnemyDeath : MonoBehaviour {

    [SerializeField]
    private GameObject deadEnemy;
    private GameManager gm;


	public RoomManager room;

	// Use this for initialization
	void Start () {
        gm.numOfEnemies++;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Bullet(Clone)")
        {
<<<<<<< HEAD
            Debug.Log("Enemy hit by bullet");        
=======
            Debug.Log("Enemy hit by bullet");
			room.OnEnemyKill ( );
>>>>>>> 7f8e6c07edc69ab30a4aa694d8bcffa66f717a93
            Destroy(gameObject);
            Instantiate(deadEnemy, transform.position, Quaternion.identity);
        }


    }

}
