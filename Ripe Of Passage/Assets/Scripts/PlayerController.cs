using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    

    private Vector3 mousePosition;
    private Vector3 worldPosition;
    private float cameraDif;
    public GameObject bullet;

    public int speed;
	// Use this for initialization
	void Start () {
        cameraDif = Camera.main.transform.position.y - transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        worldPosition = Camera.main.ScreenPointToRay(Input.mousePosition).GetPoint(cameraDif);
        worldPosition.z = transform.position.z;
        transform.LookAt(worldPosition);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Mouse Clicked");
            Instantiate(bullet, transform.position + (transform.forward*.8f), transform.rotation);

        }

	}

    //void FixedUpdate()
    //{
    //    float moveHorizontal = Input.GetAxis("Horizontal");
    //    float moveVertical = Input.GetAxis("Vertical");

    //    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    //    GetComponent<Rigidbody>().velocity = movement * speed;


    //}
}
