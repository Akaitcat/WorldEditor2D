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
    Dictionary<string, List<WEMenuItemBase>> m_MenuItems = new Dictionary<string, List<WEMenuItemBase>>();
    Dictionary<string, Dropdown> m_ClassItems = new Dictionary<string, Dropdown>();
    private void Awake()
    {
        _Instance = this;
    }
    
    public void AddMenuItem (WEMenuItemBase menuItem)
    {
        if (!m_MenuItems.ContainsKey(menuItem.m_strClassName))
        {
            m_MenuItems.Add(menuItem.m_strClassName,new List<WEMenuItemBase>());
            RectTransform newClassItem = Instantiate(m_ClassItemPrefab);
            m_ClassItems.Add(menuItem.m_strClassName, newClassItem.GetComponent<Dropdown>());
            WEMainMenuClassItem classItem = newClassItem.GetComponent<WEMainMenuClassItem>();
            classItem.OnItemClick = OnClickMenuItem;
        }
        m_ClassItems[menuItem.m_strClassName].options.Add(new Dropdown.OptionData(menuItem.m_strItemName));
    }

    void OnClickMenuItem(string strClassName,string strItemName)
    {
        Debug.Log("点击了"+ strClassName+"#"+ strItemName);
    }
}
