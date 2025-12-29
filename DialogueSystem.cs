using UnityEngine;
using System.Collections;

public class DialogueSystem : MonoBehaviour
{
    void Start()
    {
        Debug.Log("--- تفعيل نظام الحوارات السينمائي ---");
        StartCoroutine(PlayStoryDialogue());
    }

    IEnumerator PlayStoryDialogue()
    {
        yield return new WaitForSeconds(2); // انتظار ثانيتين حتى تظهر الشخصيات
        
        Debug.Log("ليلا: الأكواخ تبدو هادئة جداً اليوم، هل تعتقدين أننا بأمان يا ماريا؟");
        
        yield return new WaitForSeconds(4); // وقت للقراءة
        
        Debug.Log("ماريا: لا أدري يا ليلا، لكن الضباب كثيف.. علينا الاحتماء بالداخل بسرعة.");
        
        yield return new WaitForSeconds(3);
        Debug.Log("النظام: (تم تسجيل الحوار في ذاكرة القصة)");
    }
}
