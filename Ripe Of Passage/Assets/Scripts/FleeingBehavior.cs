using UnityEngine;
using System.Collections;

public class FleeingBehavior : MonoBehaviour
{

    private GameObject player;
    [SerializeField]
    private float speed = 2f;
    


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
        Vector3 flee = transform.position - player.transform.position;
        flee.Normalize();
        transform.Translate(flee * speed * Time.deltaTime);
    }
}
