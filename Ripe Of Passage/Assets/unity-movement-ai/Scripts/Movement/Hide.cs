using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(SteeringBasics))]
[RequireComponent(typeof(Evade))]
public class Hide : MonoBehaviour {
    public float distanceFromBoundary = 0.6f;

    private SteeringBasics steeringBasics;
    private Evade evade;

    // Use this for initialization
    void Start () {
        steeringBasics = GetComponent<SteeringBasics>();
        evade = GetComponent<Evade>();
	}

    public Vector3 getSteering(Rigidbody2D target, ICollection<Rigidbody2D> obstacles)
    {
        Vector3 bestHidingSpot;
        return getSteering(target, obstacles, out bestHidingSpot);
    }

    public Vector3 getSteering(Rigidbody2D target, ICollection<Rigidbody2D> obstacles, out Vector3 bestHidingSpot)
    {
        //Find the closest hiding spot
        float distToClostest = Mathf.Infinity;
        bestHidingSpot = Vector3.zero;

        foreach(Rigidbody2D r in obstacles)
        {
            Vector3 hidingSpot = getHidingPosition(r, target);

            float dist = Vector3.Distance(hidingSpot, transform.position);

            if(dist < distToClostest)
            {
                distToClostest = dist;
                bestHidingSpot = hidingSpot;
            }
        }

        //If no hiding spot is found then just evade the enemy
        if(distToClostest == Mathf.Infinity)
        {
            return evade.getSteering(target);
        }

        //Debug.DrawLine(transform.position, bestHidingSpot);

        return steeringBasics.arrive(bestHidingSpot);
    }

    private Vector3 getHidingPosition(Rigidbody2D obstacle, Rigidbody2D target)
    {
        float distAway = SteeringBasics.getBoundingRadius(obstacle.transform) + distanceFromBoundary;

        Vector3 dir = obstacle.position - target.position;
        dir.Normalize();

        return new Vector3 ( obstacle.position.x, obstacle.position.y, 0 ) + dir * distAway;
    }
}
