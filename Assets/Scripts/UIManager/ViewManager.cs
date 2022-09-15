using System.Collections.Generic;
using UnityEngine;

public class ViewManager
{
    public static Dictionary<string, View> views = new Dictionary<string, View>();
    /// <summary>
    /// 主菜单
    /// </summary>
    private static string mainMenu = "MainMenuView";
    public ViewManager()
    {
        views = UIRoot.GetAllView();
        Initialization();
    }
    /// <summary>
    /// 初始化
    /// </summary>
    private void Initialization()
    {
        ShowMainMenu();
    }
    /// <summary>
    /// 获取UI
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T GetView<T>() where T : View
    {
        foreach (var view in views)
        {
            if (view.Value is T tView)
            {
                return tView;
            }
        }
        return null;
    }
    /// <summary>
    /// 显示UI
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static void Show<T>() where T : View
    {
        foreach (var itemView in views)
        {
            if (itemView.Value is T)
            {
                itemView.Value.Show();
            }
        }
    }
    /// <summary>
    /// 显示需要打开的UI且关闭其它所有UI
    /// </summary>
    /// <param name="view"></param>
    /// <param name="remember"></param>
    public static void Show(View view)
    {
        foreach (var itemView in views)
        {
            itemView.Value.Hide();
        }
        view.Show();
    }
    /// <summary>
    /// 关闭UI
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static void Close<T>() where T : View
    {
        foreach (var itemView in views)
        {
            if (itemView.Value is T)
            {
                itemView.Value.Hide();
            }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static void ShowMainMenu()
    {
        foreach (var itemView in views)
        {
            itemView.Value.Init();
        }
        if (!views.ContainsKey(mainMenu))
        {
            return;
        }
        Show(views[mainMenu]);
    }

}
