using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Nodes {

    public List<Nodes> ChildNodesList = new List<Nodes>();
    public AIBehaviorForObject AIB;


    public enum NodeStates
    {
        FAILURE,
        RUNNING,
        SUCCESS
    }

    NodeStates myNodeStates;

    //does nothing untill a action execute overrrides this with a function
    //can only be don in inheritence
    //
    public virtual void ActionExecute()
    {

    }

    public void AddChild(Nodes node)
    {
        node.AIB = AIB;
        ChildNodesList.Add(node);
    }

    public void Success()
    {
        this.myNodeStates = NodeStates.SUCCESS;
     //   Debug.Log(this.GetType().ToString() + "success");
    }

    public void Running()
    {
        this.myNodeStates = NodeStates.RUNNING;
    //    Debug.Log(this.GetType().ToString() + "running");
    }

    public void Failed()
    {
        this.myNodeStates = NodeStates.FAILURE;

//        Debug.Log(this.GetType().ToString() + "fail");
    }

    public bool Succeeded()
    {
        return this.myNodeStates.Equals(NodeStates.SUCCESS);
    }

    public bool isRunning()
    {
        return this.myNodeStates.Equals(NodeStates.RUNNING);
    }

    public bool HasFailed()
    {
        return this.myNodeStates.Equals(NodeStates.FAILURE);
    }

}
