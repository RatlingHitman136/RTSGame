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
        HexGridData UploadedData;

        HexColumnRenderer[] hexColumnRenderers;
        public HexGridRenderer(HexGrid hexGrid)
        {
            this.UploadedData = hexGrid.MapData;
            hexColumnRenderers = new HexColumnRenderer[UploadedData.width];

            GameObject MeshPart = new GameObject("Mesh Part");

            MeshPart.transform.parent = hexGrid.transform;

            for (int x = 0;x < UploadedData.width;x++)
            {
                InitColumn(x, hexGrid, MeshPart.transform);
            }

        }

        //public UpdateHexGridMesh(Vector3[] HexagonsToUpdate)
        //{

        //}

        void InitColumn(int x, HexGrid hexGrid, Transform MeshPart)
        {
            hexColumnRenderers[x] = new HexColumnRenderer(x, hexGrid, MeshPart);
        }

    }
}
