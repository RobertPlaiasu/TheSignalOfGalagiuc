using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSpriteRenderer : MonoBehaviour
{
    private int sortingOrderBase = 5000;
    private int offset = -10;
    private Renderer myRenderer;
    public bool isPlayer = false;
    public bool runOnlyOnce = true;
    private void Awake()
    {
        if (isPlayer == false)
        {
            myRenderer = gameObject.GetComponent<Renderer>();
        }
    }

    private void LateUpdate()
    {
        if (isPlayer == true)
        {
            foreach (Transform child in transform) {
                child.GetComponent<Renderer>().sortingOrder = 
                    (int) (sortingOrderBase - transform.position.y + 10);
            }
        }
        else
        {
            myRenderer.sortingOrder = (int) (sortingOrderBase - transform.position.y - offset);
            if (runOnlyOnce == true) Destroy(this);
        }
    }
}
