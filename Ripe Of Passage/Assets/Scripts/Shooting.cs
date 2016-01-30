using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private int bulletSpeed = 10;


    private Vector3 mousePosition;
    private Vector3 worldPosition;
    private float cameraDif;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        worldPosition = Camera.main.ScreenPointToRay(Input.mousePosition).GetPoint(cameraDif);
        worldPosition.y = transform.position.y;
        transform.LookAt(worldPosition);
        

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 shootDirection = new Vector3(Input.mousePosition.x - this.transform.position.x, Input.mousePosition.y - this.transform.position.y, 0).normalized;
            GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position + (transform.forward * .8f), transform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(shootDirection * bulletSpeed, ForceMode.VelocityChange);
        }
	
	}
}
