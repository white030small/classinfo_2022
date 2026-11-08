using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    public GameObject closed;
    public GameObject opened;

    void Start()
    {
        closed.SetActive(true);
        opened.SetActive(false);
    }

    void OnTriggerStay2D(Collider other)
    {
        if (other.gameObject.name != "Player") return;
        opened.SetActive(true);
        closed.SetActive(false);
    }
}
