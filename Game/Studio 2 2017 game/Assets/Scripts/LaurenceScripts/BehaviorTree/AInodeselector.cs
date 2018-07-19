using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AInodeselector : Nodes {

    public override void ActionExecute()
    {
        foreach (Nodes node in ChildNodesList)
        {
            node.ActionExecute();
            if (node.Succeeded())
            {
                Success();
                return;
            }

            else if (node.isRunning())
            {
                Running();
                return;
            }

        }

        Failed();
        return;
    }
}
