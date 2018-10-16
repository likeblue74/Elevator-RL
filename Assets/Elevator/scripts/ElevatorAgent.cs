using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;


class ElevatorAgent:Agent
{


    static Building building;

    MOVE_STATE recv_action;

    Elevator elevator;

    public override void InitializeAgent()
    {
        elevator = gameObject.GetComponent<Elevator>();
        elevator.InitializeAgent();
    }




    public override void AgentReset()
    {
        base.AgentReset();

    }

    public override void CollectObservations()
    {
        

        elevator.CollectObservations(this);

    }



    // to be implemented by the developer
    public override void AgentAction(float[] vectorAction, string textAction)
    {
        float reward = 0;
        elevator.AgentAction(vectorAction, textAction, out reward);
        AddReward(reward);

    }

}

