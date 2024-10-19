using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public static class UIComponentChecker
{
    public static bool CheckForComponent<T>() where T : MonoBehaviour
    {
        var pointerData = new PointerEventData(EventSystem.current);
        pointerData.position = Input.mousePosition;

        List<RaycastResult> results = new();
        EventSystem.current.RaycastAll(pointerData, results);

        foreach (RaycastResult result in results)
        {
            if (result.gameObject.GetComponentInParent<T>())
            {
                return true;
            }
        }

        return false;
    }

    public static int CheckForComponents<T>() where T : MonoBehaviour
    {
        int components = 0;

        var pointerData = new PointerEventData(EventSystem.current);
        pointerData.position = Input.mousePosition;

        List<RaycastResult> results = new();
        EventSystem.current.RaycastAll(pointerData, results);

        foreach (RaycastResult result in results)
        {
            if (result.gameObject.GetComponentInParent<T>())
            {
                components++;
            }
        }

        return components;
    }

    public static List<T> GetComponents<T>() where T : MonoBehaviour
    {
        var pointerData = new PointerEventData(EventSystem.current);
        pointerData.position = Input.mousePosition;

        List<RaycastResult> results = new();
        EventSystem.current.RaycastAll(pointerData, results);
        List<T> components = new();

        foreach (RaycastResult result in results)
        {
            T resultComponent = result.gameObject.GetComponentInParent<T>();
            if (resultComponent != null)
            {
                components.Add(resultComponent);
            }
        }

        return components;
    }
}
