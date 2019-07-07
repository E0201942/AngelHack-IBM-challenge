// ShowGoldenPath
using UnityEngine;
using UnityEngine.AI;

public class ShowPath : MonoBehaviour
{
    public Transform target;
    private NavMeshPath path;
    private float elapsed = 0.0f;
    LineRenderer line;
    NavMeshAgent agent;

    void Start()
    {
        path = new NavMeshPath();
        line = GetComponent<LineRenderer>();
        agent = GetComponent<NavMeshAgent>();
        NavMesh.CalculatePath(transform.position, target.position, NavMesh.AllAreas, path);
        //agent.SetDestination(target.position);
        line.positionCount= path.corners.Length;
        getPath(path);

    }
    void getPath(NavMeshPath path)
    {
        
        line.SetPosition(0, transform.position); //set the line's origin
        
         //create the path

       
    }
   
    
    void Update()
    {
        // Update the way to the goal every second.
        elapsed += Time.deltaTime;
        if (elapsed > 1f)
        {
            elapsed -= 1f;
            NavMesh.CalculatePath(transform.position, target.position, NavMesh.AllAreas, path);
        }
       
        line.positionCount = path.corners.Length;
        
        for (int i = 1; i < path.corners.Length; i++)
        {
            line.SetPosition(i, path.corners[i-1]); //go through each corner and set that to the line renderer's position
        }
        
    }
}
