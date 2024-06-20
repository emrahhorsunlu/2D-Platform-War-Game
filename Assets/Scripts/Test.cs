using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Test : MonoBehaviour
{
    public TextMeshProUGUI myLabel;
    private int number;
    // Start is called before the first frame update
    void Start()
    {
        number = 0;
    }

    public void ButtonClicked()
    {
        number++;
        myLabel.GetComponent<TextMeshProUGUI>().text = number.ToString();
    }
}
