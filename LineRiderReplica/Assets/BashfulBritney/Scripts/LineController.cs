using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour {
    public GameObject linePrefab;
    Line activeLine;

	void Start () {
    }
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject lineGo = Instantiate(linePrefab);
            activeLine = linePrefab.GetComponent<Line>();
        }
        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }
        if(activeLine != null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.updateLine(mousePos);
        }
    }
}
