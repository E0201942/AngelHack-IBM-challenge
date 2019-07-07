// ShowGoldenPath
using UnityEngine;
using UnityEngine.AI;

public class HelicopterPath : MonoBehaviour
{
    public Transform target;
    private NavMeshPath path;
    private float elapsed = 0.0f;
    LineRenderer line;
    NavMeshAgent agent;
    public float speed;
    void Start()
    {
        path = new NavMeshPath();
        line = GetComponent<LineRenderer>();

        line.positionCount = 2;
        getPath(path);

    }
    void getPath(NavMeshPath path)
    {

        line.SetPosition(0, new Vector3(transform.position.x, 1, transform.position.z)); //set the line's origin
        line.SetPosition(1, new Vector3(target.position.x, 1, target.position.z));

        //create the path


    }


    void Update()
    {
        float step = speed * Time.deltaTime;

        getPath(path);
        // Update the way to the goal every second.
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.transform.position.x, 10, target.transform.position.z), step);

    }
}
