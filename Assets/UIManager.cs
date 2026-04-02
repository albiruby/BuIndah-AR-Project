using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Daftar Halaman UI Utama")]
    public GameObject Panel_MainMenu;
    public GameObject Panel_StartAR;
    public GameObject Panel_Explore1;
    public GameObject Panel_Explore2;
    public GameObject Panel_HowToUse;
    public GameObject Panel_QuizMenuBaru; // <-- Nama diupdate di sini
    public GameObject Panel_About;

    // Array untuk menyimpan urutan halaman
    private GameObject[] allPanels;

    // Penanda posisi halaman saat ini (0 adalah MainMenu)
    private int currentIndex = 0;

    void Start()
    {
        // 1. Susun urutan halaman Navigasi di sini. 
        // PERHATIKAN: Panel Tanya1, Tanya2, Tanya3 TIDAK ADA DI SINI.
        allPanels = new GameObject[] {
            Panel_MainMenu,      // Index 0
            Panel_StartAR,       // Index 1
            Panel_Explore1,      // Index 2
            Panel_Explore2,      // Index 3
            Panel_HowToUse,      // Index 4
            Panel_QuizMenuBaru,  // Index 5 <-- Nama diupdate di sini
            Panel_About          // Index 6
        };

        // Mulai dari menu utama
        ShowMainMenu();
    }

    private void HideAllPanels()
    {
        foreach (GameObject panel in allPanels)
        {
            panel.SetActive(false);
        }
    }

    private void UpdateUI()
    {
        HideAllPanels();
        allPanels[currentIndex].SetActive(true);
    }

    // FUNGSI NEXT, BACK, HOME (LOOPING)
    public void NextPage()
    {
        currentIndex++;
        if (currentIndex >= allPanels.Length) { currentIndex = 0; }
        UpdateUI();
    }

    public void PreviousPage()
    {
        currentIndex--;
        if (currentIndex < 0) { currentIndex = allPanels.Length - 1; }
        UpdateUI();
    }

    public void Home()
    {
        ShowMainMenu();
    }

    // FUNGSI LAMA
    public void ShowMainMenu() { currentIndex = 0; UpdateUI(); }
    public void ShowStartAR() { currentIndex = 1; UpdateUI(); }
    public void ShowExplore1() { currentIndex = 2; UpdateUI(); }
    public void ShowExplore2() { currentIndex = 3; UpdateUI(); }
    public void ShowHowToUse() { currentIndex = 4; UpdateUI(); }
    public void ShowQuizMenu() { currentIndex = 5; UpdateUI(); }
    public void ShowAbout() { currentIndex = 6; UpdateUI(); }
}