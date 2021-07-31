using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Chest : MonoBehaviour
{
    public TextMeshProUGUI tip;
    private bool chestMayBeOpen = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.E) && chestMayBeOpen)
        {
            OpenChest();
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            ChestMayBeOpen(true);
        }
    }
    
    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            ChestMayBeOpen(false);
        }
    }

    private void ChestMayBeOpen(bool val)
    {
        // tip.gameObject.SetActive(val);
        chestMayBeOpen = val;
    }
    
    private void OpenChest()
    {
        GameObject.FindWithTag("Player").GetComponent<Player>().CollectMetal();
        Destroy(gameObject);
    }
}
