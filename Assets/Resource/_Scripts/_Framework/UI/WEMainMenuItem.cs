using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WEMainMenuItem : MonoBehaviour {
    public Text m_Text;
    public int m_nID;
    public Action<int> OnClick;

    public void SetText(string strText)
    {
        m_Text.text = strText;
    }

    public void HandleSelfClick()
    {
        if (OnClick!=null)
        {
            OnClick(m_nID);
        }
    }
}
