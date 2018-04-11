using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Line : MonoBehaviour {
    public LineRenderer lineRend;
    public EdgeCollider2D lineCol;
    private List<Vector2> points;

    void updateList(Vector2 mousePos)
    {
        if(points == null)
        {
            points = new List<Vector2>();
            setPoint(mousePos);
        }
        //by the skin of my teeth did i make it
        if(Vector2.Distance(points.Last(), mousePos) > .1f)
        {
            setPoints(mousePoint);
        }
    }

}
