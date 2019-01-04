using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class WEMainMenu : MonoBehaviour {

    public static WEMainMenu _Instance;
    public RectTransform m_MenuRoot;
    public RectTransform m_ClassItemPrefab;
    Dictionary<string, WEMainMenuItemList> m_ClassItems = new Dictionary<string, WEMainMenuItemList>();
    private void Awake()
    {
        _Instance = this;
    }
    
    public void AddMenuItem (WEMenuItemBase menuItem)
    {
        if (!m_ClassItems.ContainsKey(menuItem.m_strClassName))
        {
            WEMainMenuItemList newItem = CreateClassItemList();
            newItem.OnClick = HandleItemGroupClick;
            newItem.SetText(menuItem.m_strClassName);
            m_ClassItems.Add(menuItem.m_strClassName, newItem);

        }
        m_ClassItems[menuItem.m_strClassName].AddItem(menuItem);
    }

    WEMainMenuItemList CreateClassItemList()
    {
        RectTransform newItem = Instantiate(m_ClassItemPrefab);
        newItem.SetParent(m_MenuRoot);
        newItem.localScale = Vector3.one;
        return newItem.GetComponent<WEMainMenuItemList>();
    }

    void HandleItemGroupClick(string strTitle)
    {
        m_ClassItems[strTitle].SetVisibility(true);
    }
}
