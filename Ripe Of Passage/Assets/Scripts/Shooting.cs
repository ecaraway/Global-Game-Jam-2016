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
        

        Quaternion temp = transform.rotation;
        

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Mouse Clicked");
            transform.LookAt(worldPosition);
            Instantiate(bulletPrefab, transform.position + (transform.forward * .8f), transform.rotation);

        }
        //arrow controls
        if(Input.GetKey(KeyCode.UpArrow)){
            Debug.Log("UpArrow Pressed");
            transform.LookAt(worldPosition);
            Instantiate(bulletPrefab, transform.position + (transform.forward * .8f), transform.rotation);
        }
        
        if(Input.GetKey(KeyCode.DownArrow)){
            Debug.Log("DownArrow Pressed");
            transform.LookAt(worldPosition);
            Instantiate(bulletPrefab, transform.position + (transform.forward * .8f), transform.rotation);
        }
        
          if(Input.GetKey(KeyCode.RightArrow)){
              Debug.Log("RightArrow Pressed");
              transform.LookAt(worldPosition);
            Instantiate(bulletPrefab, transform.position + (transform.forward * .8f), transform.rotation);
        }
        
          if(Input.GetKey(KeyCode.LeftArrow)){
              Debug.Log("LeftArrow Pressed");
              transform.LookAt(worldPosition);
            Instantiate(bulletPrefab, transform.position + (transform.forward * .8f), transform.rotation);
        }

        transform.rotation = temp;

    }
}
