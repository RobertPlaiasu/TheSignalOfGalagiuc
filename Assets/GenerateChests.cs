using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GenerateChests : MonoBehaviour
{
    public GameObject spawnpoints;
    public GameObject chest;
    
    void Start()
    {
        int max = spawnpoints.transform.childCount;
        int[] randomNumbers = new int[6];
        
        for (int i = 0; i < 5; i++)
        {
            int rand;
            bool containsNumber = true;
            while (containsNumber)
            {
                rand = UnityEngine.Random.Range(0, max);
                containsNumber = false;

                if (i > 0)
                {
                    foreach (int n in randomNumbers) {
                        if (n == rand)
                        {
                            containsNumber = true;
                        }
                    }
                }

                if (!containsNumber)
                {
                    randomNumbers[i] = rand;
                    Instantiate(chest, spawnpoints.transform.GetChild(rand).transform.position, Quaternion.identity);
                }
            }
        }
    }
}
