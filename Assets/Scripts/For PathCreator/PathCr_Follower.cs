using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class PathCr_Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed;
    float distaceTravelled;
    
    void Start()
    {
        distaceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distaceTravelled);
    }
    
    void Update()
    {
        
    }
}
