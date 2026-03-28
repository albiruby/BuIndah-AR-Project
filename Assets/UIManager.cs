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

    // Array untuk menyimpan urutan halaman
    private GameObject[] allPanels;

    // Penanda posisi halaman saat ini (0 adalah MainMenu)
    private int currentIndex = 0;

    void Start()
    {
        // 1. Susun urutan halaman di sini. 
        // Jika kamu ingin mengubah urutan Next/Back, ubah urutan baris di bawah ini.
        allPanels = new GameObject[] {
            Panel_MainMenu,  // Index 0
            Panel_StartAR,   // Index 1
            Panel_Explore1,  // Index 2
            Panel_Explore2,  // Index 3
            Panel_HowToUse,  // Index 4
            Panel_QuizMenu,  // Index 5
            Panel_About      // Index 6
        };

        // Mulai dari menu utama
        ShowMainMenu();
    }

    // Fungsi sakti untuk mematikan semua halaman
    private void HideAllPanels()
    {
        foreach (GameObject panel in allPanels)
        {
            panel.SetActive(false);
        }
    }

    // Fungsi inti untuk memunculkan halaman berdasarkan index saat ini
    private void UpdateUI()
    {
        HideAllPanels();
        allPanels[currentIndex].SetActive(true);
    }

    // ==========================================
    // FUNGSI BARU: NEXT, BACK, HOME (LOOPING)
    // ==========================================

    public void NextPage()
    {
        currentIndex++; // Tambah 1 ke index

        // Looping: Jika index melebihi batas jumlah halaman, kembalikan ke 0
        if (currentIndex >= allPanels.Length)
        {
            currentIndex = 0;
        }
        UpdateUI();
    }

    public void PreviousPage()
    {
        currentIndex--; // Kurangi 1 dari index

        // Looping: Jika index kurang dari 0, lempar ke halaman paling terakhir
        if (currentIndex < 0)
        {
            currentIndex = allPanels.Length - 1;
        }
        UpdateUI();
    }

    public void Home()
    {
        ShowMainMenu();
    }

    // ==========================================
    // FUNGSI LAMA (Tetap dipertahankan agar tombol menu tidak rusak)
    // ==========================================

    public void ShowMainMenu() { currentIndex = 0; UpdateUI(); }
    public void ShowStartAR() { currentIndex = 1; UpdateUI(); }
    public void ShowExplore1() { currentIndex = 2; UpdateUI(); }
    public void ShowExplore2() { currentIndex = 3; UpdateUI(); }
    public void ShowHowToUse() { currentIndex = 4; UpdateUI(); }
    public void ShowQuizMenu() { currentIndex = 5; UpdateUI(); }
    public void ShowAbout() { currentIndex = 6; UpdateUI(); }
}