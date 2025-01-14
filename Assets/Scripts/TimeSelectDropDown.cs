using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class TimeSelectDropDown : MonoBehaviour
{
    public Dropdown dropdown; // ドロップダウンUIをアタッチ

    void Start()
    {
        // 動的に追加するオプションのリストを定義
        List<string> timeOptions = new List<string>()
        {
           "10", "20","30", "40", "50", "59"
        };

        // DropdownのOptionsをクリア
        dropdown.ClearOptions();

        // 定義したリストをDropdownに設定
        dropdown.AddOptions(timeOptions);

        // デフォルト選択を設定（任意）
        dropdown.value = 0; // 最初の値を選択
    }
}
