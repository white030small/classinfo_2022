using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Image PlayerHealth;
    public PlayerStatus ps;

    void Start()
    {
        PlayerHealth.fillAmount = (float)ps.CurrentHP / (float)ps.MaxHP;
    }

    public void UpdateUI()
    {
        PlayerHealth.fillAmount = (float)ps.CurrentHP / (float)ps.MaxHP;
    }
}
