using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // 次のシーンの名前を指定
    [SerializeField] private string nextSceneName;

    // ボタンクリックで呼ばれるメソッド
    public void LoadNextScene()
    {
        if (!string.IsNullOrEmpty(nextSceneName))
        {
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.LogError("次のシーン名が設定されていません！");
        }
    }
}
