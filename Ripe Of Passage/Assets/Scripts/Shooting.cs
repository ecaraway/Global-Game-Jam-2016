using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private int bulletSpeed = 1;

    private Vector3 mousePosition;
    private Vector3 worldPosition;
    private float cameraDif;
    private float cameraX;
    private float cameraY;
    public float timeBetweenBull = 1;
    private float timestamp;


    //public int speed;


    // Use this for initialization
    void Start()
    {
        cameraDif = Camera.main.transform.position.x - transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        //mouse controls
        worldPosition = Camera.main.ScreenPointToRay(Input.mousePosition).GetPoint(cameraDif);

        cameraX = Input.mousePosition.x;
        cameraY = Input.mousePosition.y;

        worldPosition.z = transform.position.z;

        Quaternion temp = transform.rotation;
        

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Mouse Clicked");




        //    transform.LookAt(worldPosition);
        //    Vector3 direction = Camera.main.ScreenToWorldPoint(new Vector3(cameraX, cameraY, transform.position.z)) - transform.position;
        //    GameObject bull = (GameObject)Instantiate(bulletPrefab, transform.position + (transform.forward * .8f), Quaternion.LookRotation(direction));
        //    bull.GetComponent<Rigidbody2D>().AddForce(worldPosition * bulletSpeed);
        //    bull.GetComponent<Rigidbody2D>().transform.rotation = Quaternion.Euler(0f, 0f, 0f);
             Vector3 myPos = transform.position;
        //     float x = Input.mousePosition.x;
        //     float y = Input.mousePosition.y; 
             Vector3 direction = Camera.main.ScreenPointToRay(Input.mousePosition).GetPoint(cameraDif);

             transform.LookAt(worldPosition);
             GameObject bull = (GameObject)Instantiate(bulletPrefab, myPos + (transform.forward.normalized * .6f), transform.rotation); 
             bull.GetComponent<Rigidbody2D>().AddForce(transform.forward * bulletSpeed);
             bull.GetComponent<Rigidbody2D>().transform.rotation = Quaternion.LookRotation(Vector3.forward , transform.forward );
                 //Quaternion.AngleAxis(Mathf.Atan2(transform.forward.y, transform.forward.x) * Mathf.Rad2Deg, Vector3.forward);



        }
        //bullet cooldown
        if(Time.time >= timestamp){
        //arrow controls
            if(Input.GetKey(KeyCode.UpArrow)){
                Vector3 myPos = transform.position;
                Debug.Log("UpArrow Pressed");
                transform.Rotate(-100, 0f , 0f);
                GameObject bull = (GameObject)Instantiate(bulletPrefab, myPos + (transform.forward.normalized*.2f), transform.rotation); 
                bull.GetComponent<Rigidbody2D>().AddForce(transform.forward * bulletSpeed);
                bull.GetComponent<Rigidbody2D>().transform.rotation = Quaternion.LookRotation(Vector3.forward , transform.forward );
                timestamp = Time.time + timeBetweenBull;
            }
            
            if(Input.GetKey(KeyCode.DownArrow)){
                Vector3 myPos = transform.position;
                Debug.Log("DownArrow Pressed");
                transform.Rotate(100, 0f, 0f);
                GameObject bull = (GameObject)Instantiate(bulletPrefab, myPos + (transform.forward.normalized*.2f), transform.rotation); 
                bull.GetComponent<Rigidbody2D>().AddForce(transform.forward * bulletSpeed);
                bull.GetComponent<Rigidbody2D>().transform.rotation = Quaternion.LookRotation(Vector3.forward , transform.forward );
                timestamp = Time.time + timeBetweenBull;
            }
            
            if(Input.GetKey(KeyCode.RightArrow)){
                Vector3 myPos = transform.position;
                Debug.Log("RightArrow Pressed");
                transform.Rotate(0f, 100, 0f);
                GameObject bull = (GameObject)Instantiate(bulletPrefab, myPos + (transform.forward.normalized*.2f), transform.rotation); 
                bull.GetComponent<Rigidbody2D>().AddForce(transform.forward * bulletSpeed);
                bull.GetComponent<Rigidbody2D>().transform.rotation = Quaternion.LookRotation(Vector3.forward , transform.forward );
                timestamp = Time.time + timeBetweenBull;
            }
            
            if(Input.GetKey(KeyCode.LeftArrow)){
                Vector3 myPos = transform.position;
                Debug.Log("LeftArrow Pressed");
                transform.Rotate(0f, -100, 0f);
                GameObject bull = (GameObject)Instantiate(bulletPrefab, myPos + (transform.forward.normalized*.2f), transform.rotation); 
                bull.GetComponent<Rigidbody2D>().AddForce(transform.forward * bulletSpeed);
                bull.GetComponent<Rigidbody2D>().transform.rotation = Quaternion.LookRotation(Vector3.forward , transform.forward );
                timestamp = Time.time + timeBetweenBull;
            }
        }
        

        transform.rotation = temp;

    }
}
