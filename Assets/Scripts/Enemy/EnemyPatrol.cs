using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    public Transform[] patrolPoints;
    int enemySpeed;
    int targetWayPoint;
    float reachThreshold;
    float rotationSpeed;
  
    void Start()
    {
        reachThreshold = 0.2f;
        enemySpeed = 2;
        targetWayPoint = 0;
        rotationSpeed = 1f;
    }

    void Update()
    {
       
        transform.position = Vector3.MoveTowards(transform.position,
                                                patrolPoints[targetWayPoint].position,
                                                enemySpeed * Time.deltaTime
                                                );


        Vector3 wayPointDirection = patrolPoints[targetWayPoint].position;
        Vector3 targetDirection = (wayPointDirection - transform.position).normalized;

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed*Time.deltaTime);
        

        if (Vector3.Distance(transform.position, patrolPoints[targetWayPoint].position) < reachThreshold)
        {
            targetWayPoint = (targetWayPoint + 1) % patrolPoints.Length;
           
        }
    }
}
