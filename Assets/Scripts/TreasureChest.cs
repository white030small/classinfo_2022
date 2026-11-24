using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    public GameObject closed;
    public GameObject opened;
    public UIManager uiManager;   // ä|ç› Panel è„ìI UIManager

    void Start()
    {
        closed.SetActive(true);
        opened.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name != "Player") return;
        opened.SetActive(true);
        closed.SetActive(false);
        uiManager.OpenPanel();
    }
}