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
        line.Add(transform.position);
    }

    private void Update()
    {
        if(Vector2.Distance(line.Last(), transform.position) > pointDistance)
        {
            SetPoint();
        }
    }
}
