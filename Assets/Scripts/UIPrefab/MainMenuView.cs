using UnityEngine.UI;
public class MainMenuView : View
{
    private Button mainBtn;
    public override void Init()
    {
        mainBtn = transform.Find("MainButton").GetComponent<Button>();
        mainBtn.onClick.AddListener(() =>
        {
            ViewManager.Show(ViewManager.views["SettingMenuView"]);
        });
    }
}
