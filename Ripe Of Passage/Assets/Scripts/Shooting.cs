using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    [SerializeField]
    private GameObject bulletPrefab;

    private Vector3 mousePosition;
    private Vector3 worldPosition;
    private float cameraDif;

    //public int speed;


    // Use this for initialization
    void Start()
    {
        cameraDif = Camera.main.transform.position.y - transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //mouse controls
        worldPosition = Camera.main.ScreenPointToRay(Input.mousePosition).GetPoint(cameraDif);
        worldPosition.z = transform.position.z;
        //transform.LookAt(worldPosition);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Mouse Clicked");
            Instantiate(bulletPrefab, transform.position + (transform.forward * .8f), transform.rotation);

        }
        //arrow controls
        if(Input.GetKey(KeyCode.UpArrow)){
            worldPosition = Camera.main.ScreenPointToRay();
            worldPosition.z = transform.position.z;
            Debug.Log("UpArrow Pressed");
            Instantiate(bulletPrefab, transform.position + (transform.forward * .8f), transform.rotation);
        }
        
        if(Input.GetKey(KeyCode.DownArrow)){
            worldPosition = Camera.main.ScreenPointToRay();
            worldPosition.z = transform.position.z;
            Debug.Log("DownArrow Pressed");
            Instantiate(bulletPrefab, transform.position + (transform.forward * .8f), transform.rotation);
        }
        
          if(Input.GetKey(KeyCode.RightArrow)){
            worldPosition = Camera.main.ScreenPointToRay();
            worldPosition.z = transform.position.z;
            Debug.Log("RightArrow Pressed");
            Instantiate(bulletPrefab, transform.position + (transform.forward * .8f), transform.rotation);
        }
        
          if(Input.GetKey(KeyCode.LeftArrow)){
            worldPosition = Camera.main.ScreenPointToRay();
            worldPosition.z = transform.position.z;
            Debug.Log("LeftArrow Pressed");
            Instantiate(bulletPrefab, transform.position + (transform.forward * .8f), transform.rotation);
        }

    }
}
