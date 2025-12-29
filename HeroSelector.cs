using UnityEngine;
using UnityEngine.UI;

public class HeroSelector : MonoBehaviour
{
    // تعريف البطلات الثلاث لفريق Crazy Baby
    public string[] heroines = { "Layla", "Roxy", "Jade" };
    public int currentSelection = 0;

    // دالة للانتقال للبطلة التالية في القائمة
    public void NextHeroine()
    {
        currentSelection = (currentSelection + 1) % heroines.Length;
        Debug.Log("البطلة المختارة الآن: " + heroines[currentSelection]);
        
        // تشغيل صوت "اختيار" خفيف (يمكنك استخدام أحد الأصوات التي رفعتها)
        PlaySelectionSound();
    }

    void PlaySelectionSound()
    {
        Debug.Log("تم تشغيل صوت الاختيار من مجلد Audio_Assets");
    }

    // زر تأكيد الاختيار وبدء المهمة
    public void ConfirmSelection()
    {
        Debug.Log("تم تأكيد الاختيار! ستبدأ المغامرة بـ: " + heroines[currentSelection]);
        // هنا يتم الانتقال لغابة الصمت
    }
}
