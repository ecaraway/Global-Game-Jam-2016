using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

    public float speed = 1;
    private GameObject player;


    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
<<<<<<< HEAD
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += (transform.forward*speed);
        transform.position = new Vector3(transform.position.x, transform.position.y, -.5f);
=======

    }

    // Update is called once per frame
    void Update()
    {
    //    float lockPos = 0f;
    //    transform.rotation = Quaternion.Euler(lockPos, lockPos, transform.rotation.eulerAngles.z);
        transform.rotation = Quaternion.Euler(0f, 0f, transform.rotation.eulerAngles.z);
        transform.position = new Vector3(transform.position.x, transform.position.y, -.5f);


        transform.position += transform.forward * speed;
>>>>>>> 3349db17d33b16379af0726d1418da0ae5858819

        //deletes if bullet is very far away(off screen)
        Vector3 diff = transform.position - player.transform.position;
        if (diff.magnitude > 100f)
            Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D  col)
    {
        Debug.Log("Bullet hit something");
        if(col.gameObject.name != "Player")
        {
            Destroy(gameObject);
        }


    }
}
