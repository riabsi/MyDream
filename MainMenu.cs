using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // دالة لبدء المهمة الأولى لفريق Crazy Baby
    public void StartGame()
    {
        Debug.Log("جاري تحميل غابة الصمت... استعدوا يا فريق Crazy Baby!");
        SceneManager.LoadScene("ForestMission_01");
    }

    // دالة لاختيار البطلة قبل البدء
    public void SelectHeroine(string name)
    {
        Debug.Log("البطلة المختارة هي: " + name);
    }

    // دالة للخروج من اللعبة
    public void QuitGame()
    {
        Debug.Log("تم الخروج من My Dream. نراك قريباً يا رياض!");
        Application.Quit();
    }
}
