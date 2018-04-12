using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Line : MonoBehaviour {
    public LineRenderer lineRend;
    public EdgeCollider2D lineCol;
    private List<Vector2> points;

    public void updateLine(Vector2 mousePos)
    {
        if(points == null)
        {
            points = new List<Vector2>();
            setPoint(mousePos);
        }
        //by the skin of my teeth did i make it
        if(Vector2.Distance(points.Last(), mousePos) > .01f)
        {
            setPoint(mousePos);
        }
    }

    public void setPoint(Vector2 point)
    {
        points.Add(point);
        lineRend.positionCount = points.Count;
        lineRend.SetPosition(points.Count - 1, point);

        if(points.Count > 1)
        {
            lineCol.points = points.ToArray();
        }
    }

}
