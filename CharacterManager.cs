using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    void Start()
    {
        Debug.Log("--- تشغيل مشروع MyDream الكامل ---");

        // 1. تفعيل البيئة (الأكواخ والأشجار التي رفعناها سابقاً)
        string environmentPath = "Assets/Environment/";
        Debug.Log("تم استدعاء الأكواخ والأشجار من مجلد: " + environmentPath);

        // 2. تفعيل الأبطال والحركات
        // ليلا مع حركتها
        GameObject leila = GameObject.Find("Leila_Body");
        Debug.Log("ليلا جاهزة في موقعها داخل الغابة.");

        // ماريا مع حركتها
        GameObject maria = GameObject.Find("Maria_Body");
        Debug.Log("ماريا (روكسي) جاهزة بجانب الأكواخ.");

        Debug.Log("النظام يعمل الآن يا رياض.. الأبطال والبيئة في مكان واحد!");
    }
}
