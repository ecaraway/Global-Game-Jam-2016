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

    }

    // Update is called once per frame
    void Update()
    {
    //    float lockPos = 0f;
    //    transform.rotation = Quaternion.Euler(lockPos, lockPos, transform.rotation.eulerAngles.z);
        transform.rotation = Quaternion.Euler(0f, 0f, transform.rotation.eulerAngles.z);
        transform.position = new Vector3(transform.position.x, transform.position.y, -.5f);


        transform.position += transform.forward * speed;

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
