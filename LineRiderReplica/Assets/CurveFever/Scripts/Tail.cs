using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tail : MonoBehaviour {
    LineRenderer rend;
    List<Vector2> trail;
    private void Update()
    {
        trail = new List<Vector2>();
    }

    public void tailUpdate(Vector2 playerData)
    {
        if(trail != null)
        {
            addPoint(playerData);
        }

        if(Vector2.Distance(trail.Last(), playerData) > .2)
        {
            addPoint(playerData);
        }
    }

    void addPoint(Vector2 playerPos)
    {
        trail.Add(playerPos);
        rend.positionCount = trail.Count;
        rend.SetPosition(trail.Count - 1, playerPos);

        
    }
}
