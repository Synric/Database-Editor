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

        public static void LoadFiles()
        {
            string dbc_path = Properties.Settings.Default.DBC_Path;

            Map     = LoadFile($"{dbc_path}Map.dbc");
            Spell   = LoadFile($"{dbc_path}Spell.dbc");
            Area    = LoadFile($"{dbc_path}AreaTable.dbc");
            Family  = LoadFile($"{dbc_path}CreatureFamily.dbc");
            Faction = LoadFile($"{dbc_path}Faction.dbc");
            Emote   = LoadFile($"{dbc_path}Emotes.dbc");
        }

        public static DbcTable LoadFile(string path)
        {
            FileStream fileStream = File.OpenRead(path);

            return new DbcTable(fileStream, true); 
        }
    }
}
