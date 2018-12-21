using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WEMainMenuClassItem : MonoBehaviour {
    Dropdown m_Dropdown;
    public UnityAction<string,string> OnItemClick;
	// Use this for initialization
	void Start () {
        m_Dropdown = GetComponent<Dropdown>();
        m_Dropdown.onValueChanged.AddListener(OnItemValueChange);
    }
	
	// Update is called once per frame
	void OnItemValueChange(int nValue) {
        if (OnItemClick!=null)
        {
            OnItemClick(m_Dropdown.captionText.text, m_Dropdown.options[nValue].text);
        }
	}
}
