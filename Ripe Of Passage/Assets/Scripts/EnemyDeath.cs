using UnityEngine;
using System.Collections;

public class EnemyDeath : MonoBehaviour {

    [SerializeField]
    private GameObject deadEnemy;
    private GameManager gm;


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
            Debug.Log("Enemy hit by bullet");        
            Destroy(gameObject);
            Instantiate(deadEnemy, transform.position, Quaternion.identity);
        }


    }

}
