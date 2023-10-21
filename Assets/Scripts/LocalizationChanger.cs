using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocalizationChanger : MonoBehaviour
{
    public void SetLocalization(string language)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale(language);
    }
}
