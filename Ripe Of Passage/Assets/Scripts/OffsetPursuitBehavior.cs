using UnityEngine;
using System.Collections;

public class OffsetPursuitBehavior : MonoBehaviour
{

  
    private GameObject player;
    [SerializeField]
    private float speed = 2f;
    [SerializeField]
    private float stopDistance = 3f;


    void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector3 flee = player.transform.position - transform.position;
        Vector3 direction = flee;
        direction.Normalize();
        if (flee.magnitude > stopDistance) 
            transform.Translate(direction * speed * Time.deltaTime);
    }
}