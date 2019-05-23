using UnityEngine;

public class ScreenView : MonoBehaviour
{
    [SerializeField] GameEvent tapEvent_ = null;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tapEvent_.Notify(this, null);
        }
    }
}
