using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISequence : Nodes {

    public override void ActionExecute()
    {
        foreach (Nodes node in ChildNodesList)
        {
            node.ActionExecute();
            if (node.HasFailed())
            {
                Failed();
                return;
            }

            else if (node.isRunning())
            {
                Running();
                return;
            }
        }

        Success();
        return;
    }

}
