using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WEUIManager : MonoBehaviour {
    public static WEUIManager _Instance;
    private void Awake()
    {
        _Instance = this;
    }
    [SerializeField]
    RectTransform m_UIPanelRoot;
    public RectTransform UIPanelRoot
    {
        get
        {
            return m_UIPanelRoot;
        }
    }
    void Start () {
        WEMainMenu._Instance.AddMenuItem(new OpenFileWindow());
	}
}
