using UnityEngine;

public class ForestInitializer : MonoBehaviour
{
    void Start()
    {
        Debug.Log("--- جاري بناء غابة Crazy Baby ---");
        
        // ضبط إضاءة الشمس لتكون مناسبة للغابة
        RenderSettings.ambientLight = new Color(0.2f, 0.5f, 0.2f); // لون مائل للخضرة
        
        Debug.Log("تم ضبط الإضاءة وتجهيز الأرضية لاستقبال الأبطال والجواسيس.");
    }
}
