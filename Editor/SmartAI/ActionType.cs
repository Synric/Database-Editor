using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseEditor.Creature.CreatureSmartAI
{
    public partial class ActionType : Form
    {
        public ActionType()
        {
            InitializeComponent();
        }

        void ActionType_Load(object sender, EventArgs e)
        {
            addRow(0, "SMART_ACTION_NONE", "", "", "", "", "", "", "Do nothing");
            addRow(1, "SMART_ACTION_TALK", "Creature_text.groupid", "duration to wait before TEXT_OVER event is triggered", "", "", "", "", "Param 2 in Milliseconds.");
            addRow(2, "SMART_ACTION_SET_FACTION", "Faction ID (or 0 for default)", "", "", "", "", "", "");
            addRow(3, "SMART_ACTION_MORPH_TO_ENTRY_OR_MODEL", "Creature_template.entry(param1)", "Creature_template.model ID (param2)", "", "", "", "", "Take Display ID of creature (param1) OR Turn to Display ID (param2) OR Both = 0 for Demorph");
            addRow(4, "SMART_ACTION_SOUND", "Sound ID", "Text Range", "", "", "", "", "Play Sound; Text Range = 0 only sends sound to self, Text Range = 1 sends sound to everyone invisibility range");
            addRow(5, "SMART_ACTION_PLAY_EMOTE", "EmoteID", "", "", "", "", "", "Play Emote");
            addRow(6, "SMART_ACTION_FAIL_QUEST", "Quest ID", "", "", "", "", "", "Fail Quest of Target");
            addRow(7, "SMART_ACTION_ADD_QUEST", "Quest ID", "", "", "", "", "", "Add Quest to Target");
            addRow(8, "SMART_ACTION_SET_REACT_STATE", "State", "", "", "", "", "", "React State. Can be Aggressive, Passive or Defensive.");
            addRow(9, "SMART_ACTION_ACTIVATE_GOBJECT", "", "", "", "", "", "", "Activate Object");
            addRow(10, "SMART_ACTION_RANDOM_EMOTE", "Emote ID 1", "Emote ID 2", "Emote ID 3", "Emote ID 4", "Emote ID 5", "Emote ID 6", "Play Random Emote");
            addRow(11, "SMART_ACTION_CAST", "SpellId", "Cast Flags", "", "", "", "", "Cast Spell ID at Target");
            addRow(12, "SMART_ACTION_SUMMON_CREATURE", "Creature_template.entry", "Summon type", "duration in ms", "Storage ID (always 0)", "attack Invoker", "", "Summon Unit");
            addRow(13, "SMART_ACTION_THREAT_SINGLE_PCT", "Threat %", "", "", "", "", "", "Change Threat Percentage for Single Target");
            addRow(14, "SMART_ACTION_THREAT_ALL_PCT", "Threat %", "", "", "", "", "", "Change Threat Percentage for All Enemies");
            addRow(15, "SMART_ACTION_CALL_AREAEXPLOREDOREVENTHAPPENS", "Quest ID", "", "", "", "", "", "");
            addRow(16, "SMART_ACTION_SEND_CASTCREATUREORGO", "Quest ID", "Spell ID", "", "", "", "", "");
            addRow(17, "SMART_ACTION_SET_EMOTE_STATE", "Emote ID", "", "", "", "", "", "Play Emote Continuously");
            addRow(18, "SMART_ACTION_SET_UNIT_FLAG", "Creature_template.unit_flags (maybe more than one field OR'd together)", "", "", "", "", "", "Can set Multi-able flags at once");
            addRow(19, "SMART_ACTION_REMOVE_UNIT_FLAG", "Creature_template.unit_flags (maybe more than one field OR'd together)", "", "", "", "", "", "Can Remove Multi-able flags at once");
            addRow(20, "SMART_ACTION_AUTO_ATTACK", "Allow Attack State (0 = Stop attack, anything else means continue attacking)", "", "", "", "", "", "Stop or Continue Automatic Attack.");
            addRow(21, "SMART_ACTION_ALLOW_COMBAT_MOVEMENT", "Allow Combat Movement (0 = Stop combat based movement, anything else continue attacking)", "", "", "", "", "", "Allow or Disable Combat Movement");
            addRow(22, "SMART_ACTION_SET_EVENT_PHASE", "smart_scripts.event_phase_mask", "", "", "", "", "", "");
            addRow(23, "SMART_ACTION_INC_EVENT_PHASE", "Increment", "Decrement", "", "", "", "", "Set param 1 OR param 2 (not both). Value 0 has no effect.");
            addRow(24, "SMART_ACTION_EVADE", "", "", "", "", "", "", "Evade Incoming Attack");
            addRow(25, "SMART_ACTION_FLEE_FOR_ASSIST", "0/1 (If you want the fleeing NPC to say attempts to flee text on flee, use 1 on param1. For no message use 0.)", "", "", "", "", "", "If you want the fleeing NPC to say '%s attempts to run away in fear!' on flee, use 1 on param 1. 0 for no message.");
            addRow(26, "SMART_ACTION_CALL_GROUPEVENTHAPPENS", "Quest ID", "", "", "", "", "", "");
            addRow(27, "SMART_ACTION_CALL_CASTEDCREATUREORGO", "Creature_template.entry", "Spell ID", "", "", "", "", "");
            addRow(28, "SMART_ACTION_REMOVEAURASFROMSPELL", "Spell ID", "", "", "", "", "", "0 removes all auras");
            addRow(29, "SMART_ACTION_FOLLOW", "Distance (0 = Default value)", "Angle (0 = Default value)", "End creature_template.entry", "credit", "credit Type (0 monster kill, 1 event)", "", "Follow Target");
            addRow(30, "SMART_ACTION_RANDOM_PHASE", "Creature.phasemask1", "Creature.phasemask2", "Creature.phasemask3...", "", "", "", "");
            addRow(31, "SMART_ACTION_RANDOM_PHASE_RANGE", "Creature.phasemask minimum", "Creature.phasemask maximum", "", "", "", "", "");
            addRow(32, "SMART_ACTION_RESET_GOBJECT", "", "", "", "", "", "", "Reset Gameobject");
            addRow(33, "SMART_ACTION_CALL_KILLEDMONSTER", "Creature_template.entry", "", "", "", "", "", "This is the ID from quest_template. Required Npc Or Go");
            addRow(34, "SMART_ACTION_SET_INST_DATA", "Field", "Data", "", "", "", "", "Set Instance Data");
            addRow(35, "SMART_ACTION_SET_INST_DATA64", "Field", "", "", "", "", "", "Set Instance Data uint64");
            addRow(36, "SMART_ACTION_UPDATE_TEMPLATE", "Creature_template.entry", "Team (updates creature_template to given entry)", "", "", "", "", "");
            addRow(37, "SMART_ACTION_DIE", "", "", "", "", "", "", "Kill Target");
            addRow(38, "SMART_ACTION_SET_IN_COMBAT_WITH_ZONE", "", "", "", "", "", "", "");
            addRow(39, "SMART_ACTION_CALL_FOR_HELP", "Radius in yards that other creatures must be to acknowledge the cry for help", "", "", "", "", "", "");
            addRow(40, "SMART_ACTION_SET_SHEATH", "Sheath (0 - unarmed, 1 - melee, 2 - ranged)", "", "", "", "", "", "");
            addRow(41, "SMART_ACTION_FORCE_DESPAWN", "timer", "", "", "", "", "", "	 Despawn Target after param 1 Milliseconds");
            addRow(42, "SMART_ACTION_SET_INVINCIBILITY_HP_LEVEL", "Min Hp Value (+pct, -flat)", "", "", "", "", "", "");
            addRow(43, "SMART_ACTION_MOUNT_TO_ENTRY_OR_MODEL", "Creature_template.entry", "Creature_template.model ID", "", "", "", "", "Mount to Creature Entry (param 1) OR Mount to Creature Display (param 2) Or both = 0 for Unmount");
            addRow(44, "SMART_ACTION_SET_INGAME_PHASE_MASK", "Creature.phasemask", "", "", "", "", "", "");
            addRow(45, "SMART_ACTION_SET_DATA", "Field", "Data", "", "", "", "", "Set Data For Target, can be used with SMART_EVENT_DATA_SET");
            addRow(46, "SMART_ACTION_MOVE_FORWARD", "Distance in yards", "", "", "", "", "", "");
            addRow(47, "SMART_ACTION_SET_VISIBILITY", "0/1", "", "", "", "", "", "");
            addRow(48, "SMART_ACTION_SET_ACTIVE", "", "", "", "", "", "", "");
            addRow(49, "SMART_ACTION_ATTACK_START", "", "", "", "", "", "", "");
            addRow(50, "SMART_ACTION_SUMMON_GO", "Gameobject_template.entry", "Despawn Time in ms", "", "", "", "", "");
            addRow(51, "SMART_ACTION_KILL_UNIT", "", "", "", "", "", "", "");
            addRow(52, "SMART_ACTION_ACTIVATE_TAXI", "Taxi ID", "", "", "", "", "", "");
            addRow(53, "SMART_ACTION_WP_START", "walk = 0, run = 1", "Waypoints.entry", "can Repeat", "Quest_template.ID", "despawn time", "react State", "");
            addRow(54, "SMART_ACTION_WP_PAUSE", "time", "", "", "", "", "", "");
            addRow(55, "SMART_ACTION_WP_STOP", "despawn Time", "Quest_template.ID", "fail(0/1)", "", "", "", "");
            addRow(56, "SMART_ACTION_ADD_ITEM", "Item_template.entry", "count", "", "", "", "", "");
            addRow(57, "SMART_ACTION_REMOVE_ITEM", "Item_template.entry", "count", "", "", "", "", "");
            addRow(58, "SMART_ACTION_INSTALL_AI_TEMPLATE", "Template ID", "", "", "", "", "", "");
            addRow(59, "SMART_ACTION_SET_RUN", "0 = Off / 1 = On", "", "", "", "", "", "");
            addRow(60, "SMART_ACTION_SET_FLY", "0 = Off / 1 = On", "", "", "", "", "", "");
            addRow(61, "SMART_ACTION_SET_SWIM", "0 = Off / 1 = On", "", "", "", "", "", "");
            addRow(62, "SMART_ACTION_TELEPORT", "Map ID", "", "", "", "", "", "Continue this action with the TARGET_TYPE column. Use any target_type, and use target_x, target_y, target_z, target_o as the coordinates");
            addRow(63, "SMART_ACTION_STORE_VARIABLE_DECIMAL", "var ID", "number", "", "", "", "", "");
            addRow(64, "SMART_ACTION_STORE_TARGET_LIST", "var ID", "", "", "", "", "", "");
            addRow(65, "SMART_ACTION_WP_RESUME", "", "", "", "", "", "", "");
            addRow(66, "SMART_ACTION_SET_ORIENTATION", "This depends on whet target script have if SMART_TARGET_SELF than Facing will be set like in HomePosition, When SMART_TARGET_POSITION you need to set target_o. 0 = North, West = 1.5, South = 3, East = 4.5", "", "", "", "", "", "");
            addRow(67, "SMART_ACTION_CREATE_TIMED_EVENT", "id", "Initial Min", "Initial Max", "Repeat Min (only if it repeats)", "Repeat Max (only if it repeats)", "chance", "");
            addRow(68, "SMART_ACTION_PLAYMOVIE", "entry", "", "", "", "", "", "");
            addRow(69, "SMART_ACTION_MOVE_TO_POS", "Point ID", "", "", "", "", "", "	 Point ID is called by SMART_EVENT_MOVEMENTINFORM. Continue this action with the TARGET_TYPE column. Use any target_type, and use target_x, target_y, target_z, target_o as the coordinates");
            addRow(70, "SMART_ACTION_RESPAWN_TARGET", "Respawntime in seconds for gameobjects (only GOs)", "", "", "", "", "", "");
            addRow(71, "SMART_ACTION_EQUIP", "Creature_equip_template.entry", "Slot mask", "Slot 1 (item_template.entry)", "Slot 2 (item_template.entry)", "Slot 3 (item_template.entry)", "", "only slots with mask set will be sent to client, bits are 1, 2, 4, leaving mask 0 is defaulted to mask 7 (send all), Slots1-3 are only used if no Param1 is set");
            addRow(72, "SMART_ACTION_CLOSE_GOSSIP", "", "", "", "", "", "", "	gossip_menu_option.action_menu_id must be 0, and target_type must be 7");
            addRow(73, "SMART_ACTION_TRIGGER_TIMED_EVENT", "ID (> 1)", "", "", "", "", "", "");
            addRow(74, "SMART_ACTION_REMOVE_TIMED_EVENT", "ID (> 1)", "", "", "", "", "", "");
            addRow(75, "SMART_ACTION_ADD_AURA", "Spell ID", "", "", "", "", "", "");
            addRow(76, "SMART_ACTION_OVERRIDE_SCRIPT_BASE_OBJECT", "", "", "", "", "", "", "WARNING: CAN CRASH CORE, do not use if you dont know what you are doing");
            addRow(77, "SMART_ACTION_RESET_SCRIPT_BASE_OBJECT", "", "", "", "", "", "", "");
            addRow(78, "SMART_ACTION_CALL_SCRIPT_RESET", "", "", "", "", "", "", "");
            addRow(79, "SMART_ACTION_SET_RANGED_MOVEMENT", "attack Distance", "attack Angle", "", "", "", "", "Sets movement to follow at a specific range to the target..");
            addRow(80, "SMART_ACTION_CALL_TIMED_ACTIONLIST", "Entry Or Guid", "timer update type (0 OOC, 1 IC, 2 ALWAYS)", "", "", "", "", "");
            addRow(81, "SMART_ACTION_SET_NPC_FLAG", "Creature_template.npcflag", "", "", "", "", "", "");
            addRow(82, "SMART_ACTION_ADD_NPC_FLAG", "Creature_template.npcflag", "", "", "", "", "", "");
            addRow(83, "SMART_ACTION_REMOVE_NPC_FLAG", "Creature_template.npcflag", "", "", "", "", "", "");
            addRow(84, "SMART_ACTION_SIMPLE_TALK", "Creature_text.group ID", "", "", "", "", "", "Makes a player say text. SMART_EVENT_TEXT_OVER is not triggered and whispers can not be used.");
            addRow(85, "SMART_ACTION_INVOKER_CAST", "Spell ID", "cast Flags", "", "", "", "", "	 if avaliable, last used invoker will cast spellId with castFlags on targets");
            addRow(86, "SMART_ACTION_CROSS_CAST", "Spell ID", "cast Flags", "Caster Target Type", "Caster Target param 1", "Caster Target param 2", "Caster Target param 3", "");
            addRow(87, "SMART_ACTION_CALL_RANDOM_TIMED_ACTIONLIST", "Entry Or Guid 1", "Entry Or Guid 2", "Entry Or Guid 3", "Entry Or Guid 4", "Entry Or Guid 5", "Entry Or Guid 6", "Will select one entry from the ones provided. 0 is ignored.");
            addRow(88, "SMART_ACTION_CALL_RANDOM_RANGE_TIMED_ACTIONLIST", "Entry Or Guid 1", "Entry Or Guid 2", "", "", "", "", "0 is ignored.");
            addRow(89, "SMART_ACTION_RANDOM_MOVE", "Max distance in yards", "", "", "", "", "", "");
            addRow(90, "SMART_ACTION_SET_UNIT_FIELD_BYTES_1", "Value", "", "", "", "", "", "");
            addRow(91, "SMART_ACTION_REMOVE_UNIT_FIELD_BYTES_1", "Value", "", "", "", "", "", "");
            addRow(92, "SMART_ACTION_INTERRUPT_SPELL", "With delay (0/1)", "Spell ID", "Instant (0/1)", "", "", "", "This action allows you to interrupt the current spell being cast. If you do not set the spellId, the core will find the current spell depending on the withDelay and the withInstant values.");
            addRow(93, "SMART_ACTION_SEND_GO_CUSTOM_ANIM", "anim progress (0 - 255)", "", "", "", "", "", "");
            addRow(94, "SMART_ACTION_SET_DYNAMIC_FLAG", "dynamic flags", "", "", "", "", "", "");
            addRow(95, "SMART_ACTION_ADD_DYNAMIC_FLAG", "dynamic flags", "", "", "", "", "", "");
            addRow(96, "SMART_ACTION_REMOVE_DYNAMIC_FLAG", "dynamic flags", "", "", "", "", "", ""); 
            addRow(97, "SMART_ACTION_JUMP_TO_POS", "Speed XY", "Speed Z", "Target X", "Target Y", "Target Z", "", "");
            addRow(98, "SMART_ACTION_SEND_GOSSIP_MENU", "Gossip_menu_option.menu ID", "Gossip_menu_option.npc_text_id", "", "", "", "", "Can be used together with 'SMART_EVENT_GOSSIP_HELLO' to set custom gossip.");
            addRow(99, "SMART_ACTION_GO_SET_LOOT_STATE", "LootState (0 - Not ready, 1 - Ready, 2 - Activated, 3 - Just deactivated)", "", "", "", "", "", "");
            addRow(100, "SMART_ACTION_SEND_TARGET_TO_TARGET", "ID", "", "", "", "", "", "Send targets previously stored with SMART_ACTION_STORE_TARGET, to another npc/go, the other npc/go can then access them as if it was its own stored list");
        }

        void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }

        void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Hide();
        }

        void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }

        void addRow(int index, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8)
        {
            DataGridViewRow row = new DataGridViewRow();

            row.CreateCells(DataGrid);
            row.Cells[0].Value = index.ToString();
            row.Cells[1].Value = text1;
            row.Cells[2].Value = text2;
            row.Cells[3].Value = text3;
            row.Cells[4].Value = text4;
            row.Cells[5].Value = text5;
            row.Cells[6].Value = text6;
            row.Cells[7].Value = text7;
            row.Cells[8].Value = text8;

            DataGrid.Rows.Add(row);
        }

        public int Selected { get { return Convert.ToInt32(DataGrid.Rows[DataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString()); } }

        public override string ToString()
        {
            return Selected.ToString();
        }
    }
}
