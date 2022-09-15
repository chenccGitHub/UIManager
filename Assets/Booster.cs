using UnityEngine;

public class Booster : MonoBehaviour
{
    private void Awake()
    {
        Instantiate(Resources.Load<Transform>("UIRoot"));
        new ViewManager();
    }
}
