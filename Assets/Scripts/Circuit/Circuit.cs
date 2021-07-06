using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Circuit : MonoBehaviour
{
    public Bot bot;
    public Dictionary<Vector2Int, Node> nodes = new Dictionary<Vector2Int, Node>();

    public List<Node> GetConnectedNodes(Node node)
    {
        List<Node> connectedNodes = new List<Node>();
        Vector2Int position = node.currentSlot.transform.localPosition.RoundVector2();
        foreach (var direction in Directions.directions)
        {
            var pos = position + direction;
            Node nextNode;
            if (nodes.TryGetValue(pos, out nextNode)) connectedNodes.Add(nextNode);
        }
        return connectedNodes;
    }

    public void ResetCircuit()
    {
        foreach(var node in nodes.Values)
        {
            node.used = false;
        }
    }

    public void AttachNode(Node node, Vector2Int position)
    {
        if (nodes.ContainsValue(node))
        {
            var entry = nodes.First(x => x.Value == node);
            nodes.Remove(entry.Key);
        }
        Debug.Log(position);
        nodes.Add(position, node);
        node.bot = bot;
    }

    private void Update()
    {
        ResetCircuit();
        foreach(var node in nodes.Values)
        {
            if (node is ITick tick) tick.Tick();   
        }
    }

}
