using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFileWindow : WEMenuItemBase {

    GameObject m_OpenFileWindowCache;

    public OpenFileWindow()
    {
        m_strClassName = "文件";
        m_strItemName = "打开...";
        m_strPrefabPath = "Resources/Prefabs/OpenFileWindowPrefab";
    }


    public override void OnClick()
    {
        ShowWindow();
    }

    void ShowWindow()
    {
        if (!m_OpenFileWindowCache)
        {
            m_OpenFileWindowCache = Resources.Load<GameObject>(m_strPrefabPath);
        }
        GameObject window = GameObject.Instantiate(m_OpenFileWindowCache);
        window.transform.SetParent(WEUIManager._Instance.UIPanelRoot);
    }
}
