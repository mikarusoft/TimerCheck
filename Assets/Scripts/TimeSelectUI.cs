using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class TimeSelectUI : MonoBehaviour
{
    public Dropdown dropdown; // UnityのDropdown

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TimeSelectDropDown tdd = GetComponent<TimeSelectDropDown>();
        tdd.dropdown = dropdown;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ドロップダウンの値が変更されたときに呼ばれるメソッド
    public void OnDropdownValueChanged()
    {
        string selectedValue = dropdown.options[dropdown.value].text;
        Debug.Log("Selected Time: " + selectedValue);

        // 選択されたデータをPlayerPrefsに保存
        PlayerPrefs.SetString("SelectedTime", selectedValue);

        // 次のシーンに移動
        UnityEngine.SceneManagement.SceneManager.LoadScene("Timer");
    }
}