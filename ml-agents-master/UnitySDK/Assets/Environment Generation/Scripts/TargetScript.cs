using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetScript : MonoBehaviour
{
    public static int resourceAmount;
    public static int targetAmount;
    public List<float> timeTillDeath;
    public List<int> vehicleType;
    public Vector3[] resourcesLocations = new Vector3[resourceAmount];
    public Vector3[] targetLocations = new Vector3[targetAmount];
    public List<float> evacuationTime1;
    public List<float> evacuationTime2;
    public List<float> evacuationTime3;
    public List<float> evacuationTime4;
    public List<float> evacuationTime5;
    private NavMeshPath path;
    bool hasUpdated = false;
    // Start is called before the first frame update
    void Start()
    {
        path = new NavMeshPath();
        GameObject cube1 = GameObject.Find("Cube (1)");
        GameObject cube2 = GameObject.Find("Cube (2)");
        GameObject cube3 = GameObject.Find("Cube (3)");
        GameObject cube4 = GameObject.Find("Cube (4)");
        GameObject cube5 = GameObject.Find("Cube (5)");
        GameObject target1 = GameObject.Find("Target");
        GameObject target2 = GameObject.Find("Target (1)");
        GameObject target3 = GameObject.Find("Target (2)");
        GameObject target4 = GameObject.Find("Target (3)");
        GameObject target5 = GameObject.Find("Target (4)");
        ShowPath showpath1 = cube1.GetComponent<ShowPath>();
        ShowPath showpath2 = cube2.GetComponent<ShowPath>();
        ShowPath showpath3 = cube3.GetComponent<ShowPath>();
        ShowPath showpath4 = cube4.GetComponent<ShowPath>();
        NavMesh.CalculatePath(cube1.transform.position, target1.transform.position, NavMesh.AllAreas, path);
        float distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime1.Add(distance);
        NavMesh.CalculatePath(cube1.transform.position, target2.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime1.Add(distance);
        NavMesh.CalculatePath(cube1.transform.position, target3.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime1.Add(distance);
        NavMesh.CalculatePath(cube1.transform.position, target4.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime1.Add(distance);
        NavMesh.CalculatePath(cube1.transform.position, target5.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime1.Add(distance);
        NavMesh.CalculatePath(cube2.transform.position, target1.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime2.Add(distance);
        NavMesh.CalculatePath(cube2.transform.position, target2.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime2.Add(distance);
        NavMesh.CalculatePath(cube2.transform.position, target3.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime2.Add(distance);
        NavMesh.CalculatePath(cube2.transform.position, target4.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime2.Add(distance);
        NavMesh.CalculatePath(cube2.transform.position, target5.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime2.Add(distance);
        NavMesh.CalculatePath(cube3.transform.position, target1.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime3.Add(distance);
        NavMesh.CalculatePath(cube3.transform.position, target2.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime3.Add(distance);
        NavMesh.CalculatePath(cube3.transform.position, target3.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime3.Add(distance);
        NavMesh.CalculatePath(cube3.transform.position, target4.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime3.Add(distance);
        NavMesh.CalculatePath(cube3.transform.position, target5.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime3.Add(distance);
        NavMesh.CalculatePath(cube4.transform.position, target1.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime4.Add(distance);
        NavMesh.CalculatePath(cube4.transform.position, target2.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime4.Add(distance);
        NavMesh.CalculatePath(cube4.transform.position, target3.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime4.Add(distance);
        NavMesh.CalculatePath(cube4.transform.position, target4.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime4.Add(distance);
        NavMesh.CalculatePath(cube4.transform.position, target5.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime4.Add(distance);
        evacuationTime5.Add(Vector3.Distance(target1.transform.position, cube5.transform.position));
        evacuationTime5.Add(Vector3.Distance(target2.transform.position, cube5.transform.position));
        evacuationTime5.Add(Vector3.Distance(target3.transform.position, cube5.transform.position));
        evacuationTime5.Add(Vector3.Distance(target4.transform.position, cube5.transform.position));
        evacuationTime5.Add(Vector3.Distance(target5.transform.position, cube5.transform.position));

    }

    // Update is called once per frame
    void Update()
    {
        if (!hasUpdated)
        {
            updateVariables();
            hasUpdated = true;
        }
        
    }

    void updateVariables()
    {
        GameObject cube1 = GameObject.Find("Cube (1)");
        GameObject cube2 = GameObject.Find("Cube (2)");
        GameObject cube3 = GameObject.Find("Cube (3)");
        GameObject cube4 = GameObject.Find("Cube (4)");
        GameObject cube5 = GameObject.Find("Cube (5)");
        GameObject target1 = GameObject.Find("Target");
        GameObject target2 = GameObject.Find("Target (1)");
        GameObject target3 = GameObject.Find("Target (2)");
        GameObject target4 = GameObject.Find("Target (3)");
        GameObject target5 = GameObject.Find("Target (4)");
        ShowPath showpath1 = cube1.GetComponent<ShowPath>();
        ShowPath showpath2 = cube2.GetComponent<ShowPath>();
        ShowPath showpath3 = cube3.GetComponent<ShowPath>();
        ShowPath showpath4 = cube4.GetComponent<ShowPath>();
        
       
        NavMesh.CalculatePath(cube1.transform.position, target1.transform.position, NavMesh.AllAreas, path);
        float distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime1[0] = (distance);
        NavMesh.CalculatePath(cube1.transform.position, target2.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime1[1] = (distance);
        NavMesh.CalculatePath(cube1.transform.position, target3.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime1[2] = (distance);
        NavMesh.CalculatePath(cube1.transform.position, target4.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime1[3] = (distance);
        NavMesh.CalculatePath(cube1.transform.position, target5.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime1[4] = (distance);
        NavMesh.CalculatePath(cube2.transform.position, target1.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime2[0] = (distance);
        NavMesh.CalculatePath(cube2.transform.position, target2.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime2[1] = (distance);
        NavMesh.CalculatePath(cube2.transform.position, target3.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime2[2] = (distance);
        NavMesh.CalculatePath(cube2.transform.position, target4.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime2[3] = (distance);
        NavMesh.CalculatePath(cube2.transform.position, target5.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime2[4] = (distance);
        NavMesh.CalculatePath(cube3.transform.position, target1.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime3[0] = (distance);
        NavMesh.CalculatePath(cube3.transform.position, target2.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime3[1] = (distance);
        NavMesh.CalculatePath(cube3.transform.position, target3.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime3[2] = (distance);
        NavMesh.CalculatePath(cube3.transform.position, target4.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime3[3] = (distance);
        NavMesh.CalculatePath(cube3.transform.position, target5.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime3[4] = (distance);
        NavMesh.CalculatePath(cube4.transform.position, target1.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime4[0] = (distance);
        NavMesh.CalculatePath(cube4.transform.position, target2.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime4[1] = (distance);
        NavMesh.CalculatePath(cube4.transform.position, target3.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime4[2] = (distance);
        NavMesh.CalculatePath(cube4.transform.position, target4.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime4[3] = (distance);
        NavMesh.CalculatePath(cube4.transform.position, target5.transform.position, NavMesh.AllAreas, path);
        distance = 0;
        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            distance += Vector3.Distance(path.corners[i], path.corners[i + 1]);
        }
        evacuationTime4[4] = (distance);
        evacuationTime5[0]=(Vector3.Distance(target1.transform.position, cube5.transform.position));
        evacuationTime5[1]=(Vector3.Distance(target2.transform.position, cube5.transform.position));
        evacuationTime5[2]=(Vector3.Distance(target3.transform.position, cube5.transform.position));
        evacuationTime5[3]=(Vector3.Distance(target4.transform.position, cube5.transform.position));
        evacuationTime5[4]=(Vector3.Distance(target5.transform.position, cube5.transform.position));
    }
}
