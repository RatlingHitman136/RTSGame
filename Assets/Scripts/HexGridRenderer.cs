using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class HexGridRenderer
    {
        HexGridData MapData;

        HexColumnRenderer[] hexColumnRenderers;

        public HexGridRenderer(HexGrid hexGrid)
        {
            this.MapData = hexGrid.MapData;
            hexColumnRenderers = new HexColumnRenderer[MapData.width];

            GameObject MeshPart = new GameObject("Mesh Part");

            MeshPart.transform.parent = hexGrid.transform;

            for (int x = 0;x < MapData.width;x++)
            {
                InitColumn(x, hexGrid, MeshPart.transform);
            }

        }

        public void UpdateHexGridMesh(Vector3[] HexagonsToUpdate)
        {
            List<HexColumnRenderer> ColumsToUpdate = new List<HexColumnRenderer>();

            foreach(Vector3 HexagonCoord in HexagonsToUpdate)
            {
                if (HexagonCoord.x == 0)
                {
                    ColumsToUpdate.Add(hexColumnRenderers[(int)HexagonCoord.x]);
                }
                else
                {
                    ColumsToUpdate.Add(hexColumnRenderers[(int)HexagonCoord.x]);
                    ColumsToUpdate.Add(hexColumnRenderers[(int)HexagonCoord.x-1]);
                }
            }

            Debug.Log(ColumsToUpdate.Count);
            //for (int i = 0; i < ColumsToUpdate.Count; i++)
            //{
            //    ColumsToUpdate[i].UpdateColumn(i);
            //}
            for(int x = 0;x< MapData.width;x++)
            {
                hexColumnRenderers[x].UpdateColumn(x);
            }
        }

        void InitColumn(int x, HexGrid hexGrid, Transform MeshPart)
        {
            hexColumnRenderers[x] = new HexColumnRenderer(x, hexGrid, MeshPart);
        }

    }
}
