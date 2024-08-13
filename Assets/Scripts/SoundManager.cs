using UnityEngine;

public class SoundManager : MonoBehaviour {
    public GameObject btMusicOn, btMusicOff, btnVibrateOn, btnVibrateOff;
    public AudioSource audioSource;
    public AudioClip bgMusic;
    public AudioClip winSound;
    public AudioClip loseSound;

    private const string MusicPrefsKey = "MusicOn";

    void Start() {
        // Kiểm tra trạng thái bật/tắt nhạc từ PlayerPrefs và áp dụng nó
        bool musicOn = PlayerPrefs.GetInt(MusicPrefsKey, 1) == 1; // Mặc định là bật
        UpdateMusicState(musicOn);
    }

    public void BtMusicOnAppear() {
        audioSource.PlayOneShot(bgMusic);
        btMusicOn.SetActive(true);
        btMusicOff.SetActive(false);

        // Lưu trạng thái bật nhạc vào PlayerPrefs
        PlayerPrefs.SetInt(MusicPrefsKey, 1);
        PlayerPrefs.Save();
    }

    public void BtMusicOnDisappear() {
        btMusicOn.SetActive(false);
        btMusicOff.SetActive(true);
        audioSource.Stop();

        // Lưu trạng thái tắt nhạc vào PlayerPrefs
        PlayerPrefs.SetInt(MusicPrefsKey, 0);
        PlayerPrefs.Save();
    }

    private void UpdateMusicState(bool musicOn) {
        // Áp dụng trạng thái bật/tắt nhạc
        if (musicOn) {
            BtMusicOnAppear();
        } else {
            BtMusicOnDisappear();
        }
    }

    public void VibrateBtn() {
        if (btnVibrateOn.activeSelf) {
            btnVibrateOn.SetActive(false);
            btnVibrateOff.SetActive(true);
        } else {
            btnVibrateOn.SetActive(true);
            btnVibrateOff.SetActive(false);
        }
    }
}
