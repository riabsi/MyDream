using UnityEngine;

public class ForestInitializer : MonoBehaviour
{
    void Start()
    {
        // تفعيل الضباب لجعل الغابة تبدو عميقة وواقعية
        RenderSettings.fog = true;
        RenderSettings.fogColor = new Color(0.1f, 0.2f, 0.1f); // ضباب أخضر غامق
        RenderSettings.fogDensity = 0.05f;

        Debug.Log("تم إضافة الضباب الجوي للغابة بنجاح.");
    }
}
