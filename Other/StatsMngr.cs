using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsMngr : MonoBehaviour
{
    public static StatsMngr Instance { get; private set; }

    private TextMeshProUGUI life;
    private TextMeshProUGUI ammo;
    private TextMeshProUGUI stamina;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        life = transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>();
        ammo = transform.GetChild(3).gameObject.GetComponent<TextMeshProUGUI>();
        stamina = transform.GetChild(5).gameObject.GetComponent<TextMeshProUGUI>();
    }

    public void SetAmmo(int count)
    {
        ammo.text = count.ToString() + "/8";
    }

    public void SetLife(int life)
    {
        this.life.text = life.ToString() + "%";
    }

    public void SetStamina(int stam)
    {
        stamina.text = stam.ToString() + "%";
    }
}
