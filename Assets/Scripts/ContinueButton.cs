using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    public void Gostart()
    {
        SceneManager.LoadScene("Startui");
    }
}
