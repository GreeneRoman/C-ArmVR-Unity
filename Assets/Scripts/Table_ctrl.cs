using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Table_ctrl : MonoBehaviour
{
    public Button Tbl_Up;

    private void Start()
    {
        // Subscribe to the button's onClick event
        Tbl_Up.onClick.AddListener(OnButtonPressed);
    }


    public void OnButtonPressed()
    {
        Tbl_Up.onClick.AddListener(OnButtonPressed);
        Debug.Log( "Button Up pressed!");
    }

  
}
