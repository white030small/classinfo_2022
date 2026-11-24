using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // 讓其他腳本可以用 SceneSwitcher.Instance 找到這個物件
    public static SceneSwitcher Instance;

    private int currentIndex;   // 目前場景的編號

    void Awake()
    {
        Instance = this;
        currentIndex = SceneManager.GetActiveScene().buildIndex;   // 獲得場景編號
    }

    public void LoadNextScene()    // 切換到下一個場景
    {
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void ReloadScene()    // 重新載入目前的場景
    {
        SceneManager.LoadScene(currentIndex);
    }
}