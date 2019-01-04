using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WEMenuItemBase {
    public string m_strClassName;
    public string m_strItemName;
    public string m_strPrefabPath;

    public abstract void OnClick();
}
