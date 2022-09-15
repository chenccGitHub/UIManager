using UnityEngine.UI;
using UnityEngine;

public class SettingMenuView : View
{
    private Button settingBtn;
    public override void Init()
    {
        settingBtn = transform.Find("BackButton").GetComponent<Button>();
        settingBtn.onClick.AddListener(() =>
        {
            ViewManager.ShowMainMenu();
        });
    }
}
