using System;
using System.Windows.Forms;

namespace DatabaseEditor.GameObject.Edit
{
    public partial class Type : Form
    {
        public Type()
        {
            InitializeComponent();
        }

        void Type_Load(object sender, EventArgs e)
        {
            addRow(0, "DOOR", "startOpen (Boolean flag)", "open (LockId from Lock.dbc)", "autoClose (Time in milliseconds) ", "noDamageImmune (Boolean flag)", "openTextID (Unknown Text ID)", "closeTextID (Unknown Text ID) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(1, "BUTTON", "startOpen (State)", "open (LockId from Lock.dbc)", "autoClose (long unknown flag)", "linkedTrap (gameobject_template.entry (Spawned GO type 6))", "noDamageImmune (Boolean flag)", "large? (Boolean flag)", "openTextID (Unknown Text ID)", "closeTextID (Unknown Text ID)", "losOK (Boolean flag) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(2, "QUEST GIVER", "open (LockId from Lock.dbc)", "questList (unknown ID)", "pageMaterial (PageTextMaterial.dbc)", "gossipID (gossip_menu id)", "customAnim (unknown value from 1 to 4)", "noDamageImmune (Boolean flag)", "openTextID (Unknown Text ID)", "losOK (Boolean flag)", "allowMounted (Boolean flag)", "large? (Boolean flag) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(3, "CHEST", "open (LockId from Lock.dbc)", "chestLoot (gameobject_loot_template.entry) This field comes from WDB and is not to be changed", "chestRestockTime (time in seconds)", "consumable (State: Boolean flag)", "minRestock (Min successful loot attempts for Mining, Herbalism etc)", "maxRestock (Max successful loot attempts for Mining, Herbalism etc)", "lootedEvent (unknown ID)", "linkedTrap (gameobject_template.entry (Spawned GO type 6))", "questID (quest_template.id of completed quest)", "level (minimal level required to open this gameobject)", "losOK (Boolean flag)", "leaveLoot (Boolean flag)", "notInCombat (Boolean flag)", "log loot (Boolean flag)", "openTextID (Unknown ID)", "use group loot rules (Boolean flag) ", "", "", "", "", "", "", "", "");
            addRow(4, "BINDER", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(5, "GENERIC", "floatingTooltip (Boolean flag)", "highlight (Boolean flag)", "serverOnly? (Always 0)", "large? (Boolean flag)", "floatOnWater (Boolean flag)", "questID (Required active quest_template.id to work) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(6, "TRAP", "open (LockId from Lock.dbc)", "level (npc equivalent level for casted spell)", "diameter (so radius*2)", "spell (Spell Id from Spell.dbc)", "type (0 trap with no despawn after cast. 1 trap despawns after cast. 2 bomb casts on spawn)", "cooldown (time in seconds)", "&nbsp;? (unknown flag)", "startDelay? (time in seconds)", "serverOnly? (always 0)", "stealthed (Boolean flag)", "large? (Boolean flag)", "stealthAffected (Boolean flag)", "openTextID (Unknown ID) ", "", "", "", "", "", "", "", "", "", "", "");
            addRow(7, "CHAIR", "chairslots (number of players that can sit down on it)", "chairorientation? (number of usable side?) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(8, "SPELL FOCUS", "spellFocusType (from SpellFocusObject.dbc; value also appears as RequiresSpellFocus in Spell.dbc)", "diameter (so radius*2)", "linkedTrap (gameobject_template.entry (Spawned GO type 6))", "serverOnly? (Always 0)", "questID (Required active quest_template.id to work)", "large? (Boolean flag)", "floatingTooltip (Boolean flag) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(9, "TEXT", "pageID (page_text.entry)", "language (from Languages.dbc)", "pageMaterial (PageTextMaterial.dbc) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(10, "GOOBER", "open (LockId from Lock.dbc)", "questID (Required active quest_template.id to work)", "eventID (event_script id)", "&nbsp;? (unknown flag)", "customAnim (unknown)", "consumable (Boolean flag controling if gameobject will despawn or not)", "cooldown (time is seconds)", "pageID (page_text.entry)", "language (from Languages.dbc) ", "pageMaterial (PageTextMaterial.dbc)", "spell (Spell Id from Spell.dbc)", "noDamageImmune (Boolean flag)", "linkedTrap (gameobject_template.entry (Spawned GO type 6))", "large? (Boolean flag)", "openTextID (Unknown ID)", "closeTextID (Unknown ID)", "losOK (Boolean flag) (somewhat related to battlegrounds) ", "", "", "", "", "", "", "");
            addRow(11, "TRANSPORT", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(12, "AREA DAMAGE", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(13, "CAMERA", "open (LockId from Lock.dbc)", "camera (Cinematic entry from CinematicCamera.dbc) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(14, "MAP OBJECT", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(15, "MAP OBJECT TRANSPORT", "taxiPathID (Id from TaxiPath.dbc)", "moveSpeed", "accelRate", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(16, "DUEL ARBITER", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(17, "FISHING NODE", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(18, "RITUAL", "casters?", "spell (Spell Id from Spell.dbc)", "animSpell (Spell Id from Spell.dbc)", "ritualPersistent (Boolean flag)", "casterTargetSpell (Spell Id from Spell.dbc)", "casterTargetSpellTargets (Boolean flag)", "castersGrouped (Boolean flag) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(19, "MAILBOX", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(20, "AUCTION HOUSE", "actionHouseID (From AuctionHouse.dbc&nbsp;?) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(21, "GUARD POST", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(22, "SPELL CASTER", "spell (Spell Id from Spell.dbc)", "charges", "partyOnly (Boolean flag, need to be in group to use it) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(23, "MEEETING STONE", "minLevel", "maxLevel", "areaID (From AreaTable.dbc) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(24, "FLAG STAND", "open (LockId from Lock.dbc)", "pickupSpell (Spell Id from Spell.dbc)", "radius (distance)", "returnAura (Spell Id from Spell.dbc)", "returnSpell (Spell Id from Spell.dbc)", "noDamageImmune (Boolean flag)", "&nbsp;?", "losOK (Boolean flag) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(25, "FISHING HOLE", "radius (distance)", "chestLoot (gameobject_loot_template.entry)", "minRestock", "maxRestock ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(26, "FLAG DROP", "open (LockId from Lock.dbc)", "eventID (Unknown Event ID)", "pickupSpell (Spell Id from Spell.dbc)", "noDamageImmune (Boolean flag) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(27, "MINI GAME", "areatrigger_teleport.id ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(28, "LOTTERY KIOSK", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(29, "CAPTURE POINT", "radius (Distance)", "spell (Unknown ID, not a spell id in dbc file, maybe server only side spell)", "worldState1", "worldstate2", "winEventID1 (Unknown Event ID)", "winEventID2 (Unknown Event ID)", "contestedEventID1 (Unknown Event ID)", "contestedEventID2 (Unknown Event ID)", "progressEventID1 (Unknown Event ID)", "progressEventID2 (Unknown Event ID)", "neutralEventID1 (Unknown Event ID)", "neutralEventID2 (Unknown Event ID)", "neutralPercent", "worldstate3", "minSuperiority", "maxSuperiority", "minTime (in seconds)", "maxTime (in seconds)", "large? (Boolean flag) ", "", "", "", "", "");
            addRow(30, "AURA GENERATOR", "startOpen (Boolean flag)", "radius (Distance)", "auraID1 (Spell Id from Spell.dbc)", "conditionID1 (Unknown ID) ", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(31, "DUNGEON DIFFICULTY", "mapID (From Map.dbc) ", "difficulty", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(32, "BARBER CHAIR", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(33, "DESTRUCTIBLE BUILDING", "intactNumHits ", "creditProxyCreature ", "state1Name ", "intactEvent ", "damagedDisplayId ", "damagedNumHits ", "empty3 ", "empty4 ", "empty5 ", "damagedEvent ", "destroyedDisplayId ", "empty7 ", "empty8 ", "empty9 ", "destroyedEvent ", "empty10 ", "debuildingTimeSecs ", "empty11 ", "destructibleData ", "rebuildingEvent ", "empty12 ", "empty13 ", "damageEvent ", "empty14 ");
            addRow(34, "GUILD BANK", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            addRow(35, "TRAP DOOR", "whenToPause", "startOpen", "autoClose", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
        }

        void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }

        void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }

        void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Hide();
        }

        void addRow(int index, string title, string data0, string data1, string data2, string data3, string data4, string data5, string data6, string data7, string data8, string data9, string data10, string data11, string data12, string data13, string data14, string data15, string data16, string data17, string data18, string data19, string data20, string data21, string data22, string data23)
        {
            DataGridViewRow row = new DataGridViewRow();

            row.CreateCells(DataGrid);
            row.Cells[0].Value = index.ToString();
            row.Cells[1].Value = title;
            row.Cells[2].Value = data0;
            row.Cells[3].Value = data1;
            row.Cells[4].Value = data2;
            row.Cells[5].Value = data3;
            row.Cells[6].Value = data4;
            row.Cells[7].Value = data5;
            row.Cells[8].Value = data6;
            row.Cells[9].Value = data7;
            row.Cells[10].Value = data8;
            row.Cells[11].Value = data9;
            row.Cells[12].Value = data10;
            row.Cells[13].Value = data11;
            row.Cells[14].Value = data12;
            row.Cells[15].Value = data13;
            row.Cells[16].Value = data14;
            row.Cells[17].Value = data15;
            row.Cells[18].Value = data16;
            row.Cells[19].Value = data17;
            row.Cells[20].Value = data18;
            row.Cells[21].Value = data19;
            row.Cells[22].Value = data20;
            row.Cells[23].Value = data21;
            row.Cells[24].Value = data22;
            row.Cells[25].Value = data23;

            DataGrid.Rows.Add(row);
        }

        public int Selected { get { return Convert.ToInt32(DataGrid.Rows[DataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString()); } }

        public override string ToString()
        {
            return Selected.ToString();
        }
    }
}
