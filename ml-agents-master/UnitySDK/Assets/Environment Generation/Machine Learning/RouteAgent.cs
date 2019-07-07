using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class RouteAgent : Agent
{
   
    int count = 0;
    public int[] targets = new int[5];
    public int[] resources = new int[5];
    public float[] timeTaken = new float[5] { 0f, 0f, 0f, 0f, 0f };
    public override void CollectObservations()
    {
        GameObject variables = GameObject.Find("VariableStore");
        TargetScript things = variables.GetComponent<TargetScript>();


        for (int i =0; i< things.timeTillDeath.Count; i++)
        {
            AddVectorObs(things.timeTillDeath[i]);
        }
        for (int i = 0; i < things.evacuationTime1.Count; i++)
        {
            AddVectorObs(things.evacuationTime1[i]);
        }
        for (int i = 0; i < things.evacuationTime2.Count; i++)
        {
            AddVectorObs(things.evacuationTime2[i]);
        }
        for (int i = 0; i < things.evacuationTime3.Count; i++)
        {
            AddVectorObs(things.evacuationTime3[i]);
        }
        for (int i = 0; i < things.evacuationTime4.Count; i++)
        {
            AddVectorObs(things.evacuationTime4[i]);
        }
        for (int i = 0; i < things.evacuationTime5.Count; i++)
        {
            AddVectorObs(things.evacuationTime5[i]);
        }
        for (int i = 0; i < targets.Length; i++)
        {
            AddVectorObs(targets[i]);
        }
        for (int i = 0; i < resources.Length; i++)
        {
            AddVectorObs(resources[i]);
        }


    }

    public override void AgentAction(float[] vectorAction, string textAction)
    {
        count++;
        GameObject variables = GameObject.Find("VariableStore");
        GameObject resource = GameObject.Find("Cube (1)");
        GameObject targetted = GameObject.Find("Target");
        List<float> timings = new List<float>();
        TargetScript things = variables.GetComponent<TargetScript>();
        targets[(int)vectorAction[0]] = (int)vectorAction[1];
        resources[(int)vectorAction[0]] = (int)vectorAction[2];
        if (count == 5) {
            int rewards = 0;
            for (int i = 0; i < targets.Length - 1; i++)
            {
                for (int j = i + 1; j < targets.Length; j++)
                {
                    if (targets[j] == targets[i])
                    {
                        AddReward(-0.2f);
                    }
                }
            }
            for(int i = 0; i< 5; i++)
            {
                switch (targets[i])
                {
                    case (0):
                        targetted = GameObject.Find("Target");
                        break;
                    case (1):
                        targetted = GameObject.Find("Target (1)");
                        break;
                    case (2):
                        targetted = GameObject.Find("Target (2)");
                        break;
                    case (3):
                        targetted = GameObject.Find("Target (3)");
                        break;
                    case (4):
                        targetted = GameObject.Find("Target (4)");
                        break;
                }
                switch (resources[i])
                {
                    case (0):
                        timings = things.evacuationTime1;
                        GameObject.Find("Cube (1)").GetComponent<ShowPath>().target = targetted.transform;
                        
                        break;
                    case (1):
                        timings = things.evacuationTime2;
                        GameObject.Find("Cube (2)").GetComponent<ShowPath>().target = targetted.transform;
                        break;
                    case (2):
                        timings = things.evacuationTime3;
                        GameObject.Find("Cube (3)").GetComponent<ShowPath>().target = targetted.transform;
                        break;
                    case (3):
                        timings = things.evacuationTime4;
                        GameObject.Find("Cube (4)").GetComponent<ShowPath>().target = targetted.transform;
                        break;
                    case (4):
                        timings = things.evacuationTime5;
                        GameObject.Find("Cube (5)").GetComponent<HelicopterPath>().target = targetted.transform;
                        break;
                }
                
                
                

                if ((timings[targets[i]] + timeTaken[resources[i]])< things.timeTillDeath[targets[i]])
                {
                    AddReward(0.4f);
                    rewards++;
                }
                timeTaken[resources[i]] += timings[targets[i]];
               
            }

            if (rewards == 5)
            {
                Debug.Log(targets);
                Debug.Log(resources);
               
            }
            Done();
            
        }
        

    }

    public override void AgentReset()
    {
        count = 0;
        for (int i = 0; i < 5; i++)
        {
            timeTaken[i] = 0;
            targets[i] = 0;
            resources[i] = 0;
        }

    }

}
