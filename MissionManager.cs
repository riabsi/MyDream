using UnityEngine;
using UnityEngine.UI;

public class MissionManager : MonoBehaviour
{
    public int totalEnemies = 5;
    public int enemiesDefeated = 0;
    public Text missionStatusText;

    // دالة يتم استدعاؤها في كل مرة يموت فيها عدو
    public void EnemyKilled()
    {
        enemiesDefeated++;
        Debug.Log("عدو سقط! الباقي: " + (totalEnemies - enemiesDefeated));

        if (enemiesDefeated >= totalEnemies)
        {
            MissionComplete();
        }
    }

    void MissionComplete()
    {
        Debug.Log("تمت المهمة بنجاح يا فريق Crazy Baby!");
        Debug.Log("غابة الصمت أصبحت آمنة الآن.");
        // هنا يمكن إضافة كود لفتح المرحلة التالية (المدينة المهجورة)
    }
}
