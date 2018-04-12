using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tail : MonoBehaviour {
    LineRenderer rend;
    List<Vector2> line;
    public Transform head;
    public float pointDistance;

    private void Start()
    {
        rend = GetComponent<LineRenderer>();
        line = new List<Vector2>();
        SetPoint();
    }

    private void Update()
    {
        if(Vector2.Distance(line.Last(), head.position) > pointDistance)
        {
            SetPoint();
        }
    }

    void SetPoint()
    {
        line.Add(head.position);
        rend.positionCount = line.Count;
        rend.SetPosition(line.Count - 1, head.position);
    }
}
