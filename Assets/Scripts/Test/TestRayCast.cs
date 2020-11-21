using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRayCast : MonoBehaviour
{
    public HexGrid hexGrid;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hexGrid.TryRaycastHexGrid(out Vector3 output,Camera.main.ScreenPointToRay(Input.mousePosition));
        }
    }
}
