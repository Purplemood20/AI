using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class TobyManager : MonoBehaviour
{
    private NavMeshAgent agent;


    public List<TargetPoint> targetPoints = new List<TargetPoint>();

    private int indexNextDestination = 0;
    private Vector3 actualDestination;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        NextDestination();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(agent.remainingDistance<= agent.stoppingDistance)
        {
            NextDestination();
        }
    }

    private void NextDestination()
    {
        actualDestination = targetPoints[indexNextDestination].GivePoint();
        agent.SetDestination(actualDestination);
        indexNextDestination++;
        if(indexNextDestination>= targetPoints.Count)
        {
            indexNextDestination = 0;
        }
    }
}
