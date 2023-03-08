using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;

    // Update is called once per frame
    void Update()
    {
        nameText.text = $"{DataPersistance.PlayerStats.TextUser}";
    }
}
