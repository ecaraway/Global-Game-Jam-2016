using UnityEngine;
using System.Collections;

public class EnemyDeath : MonoBehaviour {

    [SerializeField]
    private GameObject deadEnemy;

	public RoomManager room;
    public AudioSource butts;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Bullet(Clone)")
        {
            butts.PlayOneShot(butts.clip, 1);
            Debug.Log("Enemy hit by bullet");
			room.OnEnemyKill ( );
            Destroy(gameObject);
            Instantiate(deadEnemy, transform.position, Quaternion.identity);
        }


    }

}
