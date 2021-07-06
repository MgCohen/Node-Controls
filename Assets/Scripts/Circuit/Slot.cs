using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public Circuit circuit;
    Node node;

    public bool CheckSlotEmpty()
    {
        return node;
    }

    public void DropNode(Node droppedNode)
    {
        Debug.Log(1);
        droppedNode.transform.position = transform.position;

        droppedNode.currentSlot.node = null;
        droppedNode.currentSlot = this;
        node = droppedNode;
        circuit.AttachNode(droppedNode, transform.localPosition.RoundVector2());
    }

    public List<Node> GetConnectedNodes() => circuit.GetConnectedNodes(node);
}
