using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryHighlight : MonoBehaviour
{
    [SerializeField] RectTransform highlighter;

    public void Show(bool b)
    {
        highlighter.gameObject.SetActive(b);
    }

    public void SetSize(InventoryItem targetitem)
    {
        Vector2 size = new Vector2();
        size.x = targetitem.WIDTH * ItemGrid.tileSizeWidth;
        size.y = targetitem.HEIGHT * ItemGrid.tileSizeHeight;
        highlighter.sizeDelta = size;
    }

    public void SetPosition(ItemGrid targetGrid, InventoryItem targetItem)
    {

        Vector2 pos = targetGrid.CalculatePositionGrid(
            targetItem,
            targetItem.onGridPositionX,
            targetItem.onGridPositionY
            );

        highlighter.localPosition = pos;
    }

    public void SetParent(ItemGrid targetGrid)
    {
        if(targetGrid == null) { return; }
        highlighter.SetParent(targetGrid.GetComponent<RectTransform>());
    }

    public void SetPosition(ItemGrid targetGrid, InventoryItem targetitem, int posX, int posY)
    {
        Vector2 pos = targetGrid.CalculatePositionGrid(
            targetitem,
            posX,
            posY
            );
        highlighter.localPosition = pos;
    }
}
