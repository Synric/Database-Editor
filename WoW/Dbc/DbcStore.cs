using System.IO;

namespace DatabaseEditor.Dbc
{
    public static class DbcStore
    {
        public static DbcTable Map { get; private set; }
        public static DbcTable Spell { get; private set; }
        public static DbcTable Area { get; private set; }
        public static DbcTable Family { get; private set; }
        public static DbcTable Faction { get; private set; }
        public static DbcTable Emote { get; private set; }
        public static DbcTable TotemCategory { get; private set; }
        public static DbcTable Language { get; private set; }
        public static DbcTable PageMaterial { get; private set; }
        public static DbcTable Holiday { get; private set; }
        public static DbcTable HolidayNames { get; private set; }
        public static DbcTable SkillLine { get; private set; }

        public static void LoadFiles()
        {
            string dbc_path = Properties.Settings.Default.DBC_Path;

            Map           = LoadFile($"{dbc_path}Map.dbc");
            Spell         = LoadFile($"{dbc_path}Spell.dbc");
            Area          = LoadFile($"{dbc_path}AreaTable.dbc");
            Family        = LoadFile($"{dbc_path}CreatureFamily.dbc");
            Faction       = LoadFile($"{dbc_path}Faction.dbc");
            Emote         = LoadFile($"{dbc_path}Emotes.dbc");
            TotemCategory = LoadFile($"{dbc_path}TotemCategory.dbc");
            Language      = LoadFile($"{dbc_path}Languages.dbc");
            PageMaterial  = LoadFile($"{dbc_path}PageTextMaterial.dbc");
            Holiday       = LoadFile($"{dbc_path}Holidays.dbc");
            HolidayNames  = LoadFile($"{dbc_path}HolidayNames.dbc");
            SkillLine     = LoadFile($"{dbc_path}SkillLine.dbc");
        }

        public static DbcTable LoadFile(string path)
        {
            return new DbcTable(File.OpenRead(path), true); 
        }
    }
}
