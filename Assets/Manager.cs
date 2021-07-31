using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Manager : MonoBehaviour
{
    public GameObject EndDisplay;
    public TextMeshProUGUI InfoText;
    
    public void DisplayFinalScreen()
    {
        EndDisplay.SetActive(true);
        InfoText.text = "Ai reu?it să aduni " + 
                        GameObject.FindWithTag("Player").GetComponent<Player>().CollectedMetal().ToString() + 
                        "/3 bucă?i de metal, în " + 
                        gameObject.GetComponent<Timer>().text.text +
                        " timp.";
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
