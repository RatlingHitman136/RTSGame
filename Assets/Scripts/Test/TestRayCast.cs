using Assets.Scripts;
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
            if(hexGrid.TryRaycastHexGrid(out Vector3 output,Camera.main.ScreenPointToRay(Input.mousePosition)));
            {
                Debug.Log(output);
                hexGrid.UpdateCellHeight(output, 1f);
            }

        }
    }
}
