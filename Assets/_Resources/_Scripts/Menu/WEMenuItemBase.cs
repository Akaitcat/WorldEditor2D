using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WEMenuItemBase {
    public string m_strClassName;
    public string m_strItemName;

    public abstract void OnClick();
}
