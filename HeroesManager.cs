using UnityEngine;

public class HeroesManager : MonoBehaviour
{
    // تعريف أسماء بطلات فريق Crazy Baby
    public enum Heroine { Layla, Roxy, Jade }
    
    public Heroine activeHeroine;

    void Start()
    {
        // البداية بـ "ليلا" كقائدة للفريق
        activeHeroine = Heroine.Layla;
        Debug.Log("فريق Crazy Baby مستعد! القائدة الحالية: " + activeHeroine);
    }

    // دالة للتبديل بين الفتيات أثناء اللعب
    public void SwitchHeroine(Heroine newHeroine)
    {
        activeHeroine = newHeroine;
        Debug.Log("تم التبديل.. أنت الآن تلعب بـ: " + activeHeroine);
        
        if(activeHeroine == Heroine.Roxy) {
            Debug.Log("روكسي: وضع التسلل والاختباء مفعل!");
        }
    }
}
