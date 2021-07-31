using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private int metalCollected = 0;
    public TextMeshProUGUI metalInfoText;

    public void CollectMetal()
    {
        incrementCollectedMetal();
        UpdateUI();
        CheckIfWon();
    }

    public int CollectedMetal()
    {
        return metalCollected;
    }

    private void incrementCollectedMetal()
    {
        metalCollected += 1;
    }

    private void CheckIfWon()
    {
        if (metalCollected != 3) return;

        GameObject.FindWithTag("Manager").GetComponent<Manager>().DisplayFinalScreen();
    }

    private void UpdateUI()
    {
        metalInfoText.text = metalCollected.ToString();
    }
}
