using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WEMainMenuItemList : MonoBehaviour {

    public UnityAction<string> OnClick;
    [SerializeField]
    GameObject m_Viewport;
    [SerializeField]
    Text m_Text;
    [SerializeField]
    GameObject m_ItemPrefab;
    
    List<WEMenuItemBase> m_Items = new List<WEMenuItemBase>();

    public void SetText(string strText)
    {
        m_Text.text = strText;
    }

    public void AddItem(WEMenuItemBase newItem)
    {
        GameObject newButton = Instantiate(m_ItemPrefab);
        newButton.transform.SetParent(m_Viewport.transform);
        newButton.transform.localScale = Vector3.one;
        WEMainMenuItem menuItem = newButton.GetComponent<WEMainMenuItem>();
        menuItem.m_nID = m_Items.Count;
        menuItem.OnClick = HandleItemClick;
        menuItem.SetText(newItem.m_strItemName);
        m_Items.Add(newItem);
    }
    public void Clear()
    {
        m_Items.Clear();
        while (transform.childCount>0)
        {
            Destroy(transform.GetChild(0).gameObject);
        }
    }

    public void SetVisibility(bool bVisible)
    {
        m_Viewport.SetActive(bVisible);
    }

    void HandleItemClick(int nValue) {
        m_Items[nValue].OnClick();
    }

    public void HandleSelfClick()
    { 
        if (OnClick!=null)
        {
            OnClick(m_Items[0].m_strClassName);
        }
    }

    public void HandleSelfLostFocus()
    {
        SetVisibility(false);
    }
}
