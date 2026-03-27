using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Daftar Halaman UI")]
    public GameObject Panel_MainMenu;
    public GameObject Panel_StartAR;
    public GameObject Panel_Explore1;
    public GameObject Panel_Explore2;
    public GameObject Panel_HowToUse;
    public GameObject Panel_QuizMenu;
    public GameObject Panel_About;

    void Start()
    {
        // Munculkan Menu Utama saat start
        ShowMainMenu();
    }

    // Fungsi sakti untuk mematikan semua halaman
    private void HideAllPanels()
    {
        Panel_MainMenu.SetActive(false);
        Panel_StartAR.SetActive(false);
        Panel_Explore1.SetActive(false);
        Panel_Explore2.SetActive(false);
        Panel_HowToUse.SetActive(false);
        Panel_QuizMenu.SetActive(false);
        Panel_About.SetActive(false);
    }

    // Fungsi navigasi yang dipanggil tombol
    public void ShowMainMenu() { HideAllPanels(); Panel_MainMenu.SetActive(true); }
    public void ShowStartAR() { HideAllPanels(); Panel_StartAR.SetActive(true); }
    public void ShowExplore1() { HideAllPanels(); Panel_Explore1.SetActive(true); }
    public void ShowExplore2() { HideAllPanels(); Panel_Explore2.SetActive(true); }
    public void ShowHowToUse() { HideAllPanels(); Panel_HowToUse.SetActive(true); }
    public void ShowQuizMenu() { HideAllPanels(); Panel_QuizMenu.SetActive(true); }
    public void ShowAbout() { HideAllPanels(); Panel_About.SetActive(true); }
}