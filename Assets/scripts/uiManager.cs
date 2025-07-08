using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class uiManager : MonoBehaviour
{
    public DineroManager dinero;
    public VidaManager vida;
    public TMP_Text dineroUI;
    public TMP_Text vidaUI;

    // Update is called once per frame
    void Update()
    {
        dineroUI.text = "Dinero: $" + dinero.playerMoney.ToString();
        vidaUI.text = "Vida: " + vida.life.ToString();
    }
}
