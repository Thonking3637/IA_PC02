using UnityEngine;

public class Agent : SBAgent
{
    public Transform target;
    public Transform centro;

    public bool Figure = true;

    void Start()
    {
        maxSpeed = 10f;
        maxSteer = 1f;
        target = GameObject.Find("Target").transform;
        centro = GameObject.Find("Centro").transform;
    }

    void Update()
    {

        if (Figure)
        {
            velocity += SteeringBehaviours.Circle(this, target, centro, 4); 
        }
        else {
            velocity += SteeringBehaviours.Rectangulo(this, target, centro, 2, 3);
        }
      
        transform.position += velocity * Time.deltaTime;
    }

   
}
