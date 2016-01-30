using UnityEngine;
using System.Collections;

public class EnemyPathFollowing : MonoBehaviour {

    //path points

    [SerializeField]
    private GameObject startP;
    [SerializeField]
    private GameObject point1;
    [SerializeField]
    private GameObject point2;
    [SerializeField]
    private GameObject point3;
    [SerializeField]
    private GameObject point4;
    [SerializeField]
    private GameObject point5;
    [SerializeField]
    private GameObject point6;



    [SerializeField]
    private float speed = 4f;
    private int step;

    private GameObject[] points;

    // Use this for initialization
    void Start()
    {

        points = new GameObject[7];

        points[0] = startP;
        points[1] = point1;
        points[2] = point2;
        points[3] = point3;
        points[4] = point4;
        points[5] = point5;
        points[6] = point6;




    }

    // Update is called once per frame
    void Update()
    {


        Vector3 seek = points[step].transform.position - transform.position;
        if (seek.magnitude < .1)
            step++;
        if (step >= 7)
            step = 0;
        seek.Normalize();
        transform.Translate(seek * speed * Time.deltaTime);


    }
}
