using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float speed = 1;
    private GameObject player;


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward*speed;

        //deletes if bullet is very far away(off screen)
        Vector3 diff = transform.position - player.transform.position;
        if(diff.magnitude > 100f)
            Destroy(gameObject);
	}

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Bullet hit something");
        Destroy(gameObject);
        
    }
}
