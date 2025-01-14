using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public string selectedTime;
    public float timeLimit; // ユーザー設定時間
    public GameObject character; // 走るキャラクター
    public Text timerText;

    void Start()
    {
        // PlayerPrefsから選択された時間を取得
        selectedTime = PlayerPrefs.GetString("SelectedTime", "No Time Selected");
        Debug.Log("Received Time: " + selectedTime);

        // get data(string) to time(float)data.
        timeLimit = float.Parse(selectedTime);
        Debug.Log(timeLimit);

        UpdateTimerUI();
    }

    void Update()
    {
        
        if (timeLimit > 0)
        {
            timeLimit -= Time.deltaTime;
            Debug.Log("s:"+timeLimit);
            UpdateTimerUI();
            if (timeLimit <= 0)
            {
                Debug.Log("Start Run And Next Scene!");

                SceneManager.LoadScene("Result");

                //RunCharacterAnimation();
            }
        }
    }

    
    void UpdateTimerUI()
    {
        timerText.text = "Selected Time :" + Mathf.CeilToInt(timeLimit).ToString() + "s";
    }

    void RunCharacterAnimation()
    {
        Animator animator = character.GetComponent<Animator>();
        animator.SetTrigger("Run");
    }

}
