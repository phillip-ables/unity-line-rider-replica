using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tail : MonoBehaviour {
    LineRenderer rend;
    List<Vector2> line;
    public float pointDistance;

    private void Start()
    {
        rend = GetComponent<LineRenderer>();
        line = new List<Vector2>();
        SetPoint();
    }

    private void Update()
    {
        if(Vector2.Distance(line.Last(), transform.position) > pointDistance)
        {
            SetPoint();
        }
    }

    void SetPoint()
    {
        line.Add(transform.position);
        rend.positionCount = line.Count;
        rend.SetPosition(line.Count - 1, transform.position);
    }
}
