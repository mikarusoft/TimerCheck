using UnityEngine;
using UnityEngine.UI;

public class StartUI : MonoBehaviour
{
    public Text buttonText;

    public void UpdateButtonText(string newText)
    {
        if (buttonText != null)
        {
            buttonText.text = newText;
            Debug.Log("Text updated to: " + newText);
        }
        else
        {
            Debug.LogWarning("Button Text component is not assigned!");
        }
    }
}