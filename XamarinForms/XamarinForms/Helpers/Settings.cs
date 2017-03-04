// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace XamarinForms.Helpers
{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters. 
  /// </summary>
  public static class Settings
  {
    private static ISettings AppSettings
    {
      get
      {
        return CrossSettings.Current;
      }
    }

    #region Setting Constants

    private const string SettingsKey = "settings_key";
    private static readonly string SettingsDefault = string.Empty;

        
        const string VornameKey = "vorname";
        private static readonly string VornameDefault = "Hans";

        const string KeglerListKey = "keglerlist";
        private static readonly string KeglerListDefault = "[{'_imageUri':'bug_full.png','_vorname':'Katze 1','_nachname':'sjdksjd','_initialWurf':0,'_leben':0,'_isActive':false}]";

        #endregion


        public static string GeneralSettings
    {
      get
      {
        return AppSettings.GetValueOrDefault<string>(SettingsKey, SettingsDefault);
      }
      set
      {
        AppSettings.AddOrUpdateValue<string>(SettingsKey, value);
      }
    }

        public static string Vorname
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(VornameKey, VornameDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(VornameKey, value);
            }
        }

        public static string KeglerList
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(KeglerListKey, KeglerListDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(KeglerListKey, value);
            }
        }

    }
}