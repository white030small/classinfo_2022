using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject UIPanel;

    void Start()
    {
        UIPanel.SetActive(false);
    }

    // Next Stage 按鈕用
    public void GoNextStage()
    {
        SceneSwitcher.Instance.LoadNextScene();//呼叫SceneSwitcher切換到下一場景
    }

    // Replay 按鈕用
    public void Replay()
    {
        SceneSwitcher.Instance.ReloadScene();//呼叫SceneSwitcher重新載入場景
    }

    public void OpenPanel()
    {
        UIPanel.SetActive(true);
    }

    public void ClosePanel()
    {
        UIPanel.SetActive(false);
    }
}