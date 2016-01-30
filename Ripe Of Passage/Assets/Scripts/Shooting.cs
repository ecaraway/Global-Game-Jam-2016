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
        worldPosition.y = transform.position.y;
        

        Quaternion temp = transform.rotation;
        

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Mouse Clicked");
            transform.LookAt(worldPosition);
            Instantiate(bulletPrefab, transform.position + (transform.forward.normalized * .8f), transform.rotation);

        }
        //arrow controls
        if(Input.GetKey(KeyCode.UpArrow)){
            Debug.Log("UpArrow Pressed");
            transform.Rotate(-10f, 0f , 0f);
            Instantiate(bulletPrefab, transform.position + (transform.forward.normalized * .8f), transform.rotation);
        }
        
        if(Input.GetKey(KeyCode.DownArrow)){
            Debug.Log("DownArrow Pressed");
            transform.Rotate(10f, 0f, 0f);
            Instantiate(bulletPrefab, transform.position + (transform.forward.normalized * .8f), transform.rotation);
        }
        
          if(Input.GetKey(KeyCode.RightArrow)){
              Debug.Log("RightArrow Pressed");
              transform.Rotate(0f, 10f, 0f);
              Instantiate(bulletPrefab, transform.position + (transform.forward.normalized * .8f), transform.rotation);
        }
        
          if(Input.GetKey(KeyCode.LeftArrow)){
              Debug.Log("LeftArrow Pressed");
              transform.Rotate(0f, -10f, 0f);
              Instantiate(bulletPrefab, transform.position + (transform.forward.normalized * .8f), transform.rotation);
        }
        
        
        

        transform.rotation = temp;

    }
}
