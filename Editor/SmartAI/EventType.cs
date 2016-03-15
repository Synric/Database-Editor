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
    public partial class EventType : Form
    {
        public EventType()
        {
            InitializeComponent();
        }

        private void EventType_Load(object sender, EventArgs e)
        {
            addRow(0, "SMART_EVENT_UPDATE_IC", "Initial Min", "Initial Max", "Repeat Min", "Repeat Max", "In combat.");
            addRow(1, "SMART_EVENT_UPDATE_OOC", "InitialMin", "Initial Max", "Repeat Min", "Repeat Max", "Out of combat.");
            addRow(2, "SMART_EVENT_HEALT_PCT", "HP Min%", "HP Max%", "Repeat Min", "Repeat Max", "Health Percentage");
            addRow(3, "SMART_EVENT_MANA_PCT", "Mana Min%", "Mana Max%", "Repeat Min", "Repeat Max", "Mana Percentage");
            addRow(4, "SMART_EVENT_AGGRO", "", "", "", "", "On Creature Aggro");
            addRow(5, "SMART_EVENT_KILL", "Cooldown Min 0", "Cooldown Max 1", "player Only 2", "else creature entry 3", "On Creature Kill");
            addRow(6, "SMART_EVENT_DEATH", "", "", "", "", "On Creature Death");
            addRow(7, "SMART_EVENT_EVADE", "", "", "", "", "On Creature Evade Attack");
            addRow(8, "SMART_EVENT_SPELLHIT", "Spell ID", "School", "Cooldown Min", "Cooldown Max", "On Creature/Gameobject Spell Hit");
            addRow(9, "SMART_EVENT_RANGE", "Min Dist", "Max Dist", "Repeat Min", "Repeat Max", "On Target In Range");
            addRow(10, "SMART_EVENT_OOC_LOS", "No Hostile", "Max Range", "Cooldown Min", "Cooldown Max", "On Target In Distance Out of Combat");
            addRow(11, "SMART_EVENT_RESPAWN", "type", "Map ID", "Zone ID", "", "On Creature/Gameobject Respawn");
            addRow(12, "SMART_EVENT_TARGET_HEALTH_PCT", "HP Min%", "HP Max%", "Repeat Min", "Repeat Max", "On Target Health Percentage");
            addRow(13, "SMART_EVENT_TARGET_CASTING", "Repeat Min", "Repeat Max", "", "", "On Target Casting Spell");
            addRow(14, "SMART_EVENT_FRIENDLY_HEALTH", "HP Deficit", "Radius", "Repeat Min", "Repeat Max", "On Friendly Health Deficit");
            addRow(15, "SMART_EVENT_FRIENDLY_IS_CC", "Radius", "Repeat Min", "Repeat Max", "", "");
            addRow(16, "SMART_EVENT_FRIENDLY_MISSING_BUFF", "Spell ID", "Radius", "Repeat Min", "Repeat Max", "On Friendly Lost Buff");
            addRow(17, "SMART_EVENT_SUMMONED_UNIT", "Creture ID (0 all)", "Cooldown Min", "Cooldown Max", "", "On Creature/Gameobject Summoned Unit");
            addRow(18, "SMART_EVENT_TARGET_MANA_PCT", "Mana Min%", "Mana Max%", "Repeat Min", "Repeat Max", "On Target Mana Percentage");
            addRow(19, "SMART_EVENT_ACCEPTED_QUEST", "Quest ID (0 any)", "", "", "", "On Target Accepted Quest");
            addRow(20, "SMART_EVENT_REWARD_QUEST", "Quest ID (0 any)", "", "", "", "On Target Rewarded Quest");
            addRow(21, "SMART_EVENT_REACHED_HOME", "", "", "", "", "On Creature Reached Home");
            addRow(22, "SMART_EVENT_RECEIVE_EMOTE", "Emote ID", "Cooldown Min", "Cooldown Max", "condition", "val1, val2, val3(?)");
            addRow(23, "SMART_EVENT_HAS_AURA", "Spell ID", "Stacks", "Repeat Min", "Repeat Max", "On¨Creature Has Aura");
            addRow(24, "SMART_EVENT_TARGET_BUFFED", "Spell ID", "Stacks", "Repeat Min", "Repeat Max", "On Target Buffed With Spell");
            addRow(25, "SMART_EVENT_RESET", "", "", "", "", "After Combat, On Respawnor Spawn");
            addRow(26, "SMART_EVENT_IC_LOS", "No Hostile", "Max Range", "Cooldown Min", "Cooldown Max", "On Target In Distance In Combat");
            addRow(27, "SMART_EVENT_PASSENGER_BOARDED", "Cooldown Min", "Cooldown Max", "", "", "");
            addRow(28, "SMART_EVENT_PASSENGER_REMOVED", "Cooldown Min", "Cooldown Max", "", "", "");
            addRow(29, "SMART_EVENT_CHARMED", "", "", "", "", "On Creature Charmed");
            addRow(30, "SMART_EVENT_CHARMED_TARGET", "", "", "", "", "On Target Charmed");
            addRow(31, "SMART_EVENT_SPELLHIT_TARGET", "Spell ID", "School", "Repeat Min", "Repeat Max", "On Target Spell Hit");
            addRow(32, "SMART_EVENT_DAMAGED", "Min Dmg", "Max Dmg", "Repeat Min", "Repeat Max", "On Creature Damaged");
            addRow(33, "SMART_EVENT_DAMAGED_TARGET", "Min Dmg", "Max Dmg", "Repeat Min", "Repeat Max", "On Target Damaged");
            addRow(34, "SMART_EVENT_MOVEMENTINFORM", "Movement Type (any)", "Point ID", "", "", "");
            addRow(35, "SMART_EVENT_SUMMON_DESPAWNED", "Entry", "Cooldown Min", "Cooldown Max", "", "On Summoned Unit Despawned");
            addRow(36, "SMART_EVENT_CORPSE_REMOVED", "", "", "", "", "On Creature Corpse Removed");
            addRow(37, "SMART_EVENT_AI_INIT", "", "", "", "", "");
            addRow(38, "SMART_EVENT_DATA_SET", "Field", "Value", "Cooldown Min", "Cooldown Max", "On Creature/Gameobject Data Set, Can be used with SMART_ACTION_SET_DATA");
            addRow(39, "SMART_EVENT_WAYPOINT_START", "PointId(0any)", "pathId(0any)", "", "", "OnCreatureWaypointIDStarted");
            addRow(40, "SMART_EVENT_WAYPOINT_REACHED", "Point ID (0 any)", "path ID (0 any)", "", "", "On Creature Waypoint ID Reached");
            addRow(41, "SMART_EVENT_TRANSPORT_ADDPLAYER [NOT IMPLEMENTED]", "", "", "", "", "");
            addRow(42, "SMART_EVENT_TRANSPORT_ADDCREATURE [NOT IMPLEMENTED]", "Entry (0 any)", "", "", "", "");
            addRow(43, "SMART_EVENT_TRANSPORT_REMOVE_PLAYER [NOT IMPLEMENTED]", "", "", "", "", "");
            addRow(44, "SMART_EVENT_TRANSPORT_RELOCATE [NOT IMPLEMENTED]", "Point ID", "", "", "", "");
            addRow(45, "SMART_EVENT_INSTANCE_PLAYER_ENTER [NOT IMPLEMENTED]", "Team (0 any)", "Cooldown Min", "Cooldown Max", "", "");
            addRow(46, "SMART_EVENT_AREATRIGGER_ONTRIGGER [NOT IMPLEMENTED]", "Trigger ID (0 any)", "", "", "", "");
            addRow(47, "SMART_EVENT_QUEST_ACCEPTED [NOT IMPLEMENTED]", "", "", "", "", "On Target Quest Accepted");
            addRow(48, "SMART_EVENT_QUEST_OBJ_COPLETETION [NOT IMPLEMENTED]", "", "", "", "", "On Target Quest Objective Completed");
            addRow(49, "SMART_EVENT_QUEST_COMPLETION [NOT IMPLEMENTED]", "", "", "", "", "On Target Quest Completed");
            addRow(50, "SMART_EVENT_QUEST_REWARDED [NOT IMPLEMENTED]", "", "", "", "", "On Target Quest Rewarded");
            addRow(51, "SMART_EVENT_QUEST_FAIL [NOT IMPLEMENTED]", "", "", "", "", "On Target Quest Field");
            addRow(52, "SMART_EVENT_TEXT_OVER", "Group ID (from creature_text)", "Creature ID (0 any)", "", "", "On TEXT_OVER Event Triggered After SMART_ACTION_TALK");
            addRow(53, "SMART_EVENT_RECEIVE_HEAL", "Min Heal", "Max Heal", "Cooldown Min", "Cooldown Max", "On Creature Received Healing");
            addRow(54, "SMART_EVENT_JUST_SUMMONED", "", "", "", "", "On Creature Just spawned");
            addRow(55, "SMART_EVENT_WAYPOINT_PAUSED", "Point ID (0 any)", "path ID (0 any)", "", "", "On Creature Paused at Waypoint ID");
            addRow(56, "SMART_EVENT_WAYPOINT_RESUMED", "Point ID (0 any)", "path ID (0 any)", "", "", "On Creature Resumed after Waypoint ID");
            addRow(57, "SMART_EVENT_WAYPOINT_STOPPED", "Point ID (0 any)", "path ID (0 any)", "", "", "On Creature Stopped On Waypoint ID");
            addRow(58, "SMART_EVENT_WAYPOINT_ENDED", "Point ID (0 any)", "path ID (0 any)", "", "", "On Creature Waypoint Path Ended");
            addRow(59, "SMART_EVENT_TIMED_EVENT_TRIGGERED", "ID", "", "", "", "");
            addRow(60, "SMART_EVENT_UPDATE", "Initial Min", "Initial Max", "Repeat Min", "Repeat Max", "");
            addRow(61, "SMART_EVENT_LINK", "", "", "", "", "used to link together multiple events");
            addRow(62, "SMART_EVENT_GOSSIP_SELECT", "menu_ID", "ID", "", "", "");
            addRow(63, "SMART_EVENT_JUST_CREATED", "", "", "", "", "");
            addRow(64, "SMART_EVENT_GOSSIP_HELLO", "", "", "", "", "");
            addRow(65, "SMART_EVENT_FOLLOW_COMPLETED", "", "", "", "", "");
            addRow(66, "SMART_EVENT_DUMMY_EFFECT [NOT IMPLEMENTED]", "spell ID", "effect Index", "", "", "");
            addRow(67, "SMART_EVENT_IS_BEHIND_TARGET", "Cooldown Min", "Cooldown Max", "", "", "");
            addRow(68, "SMART_EVENT_GAME_EVENT_START", "game_event.eventEntry", "", "", "", "");
            addRow(69, "SMART_EVENT_GAME_EVENT_END", "game_event.eventEntry", "", "", "", "");
            addRow(70, "SMART_EVENT_GO_STATE_CHANGED", "State (0 - Active, 1 - Ready, 2 - Active alternative)", "", "", "", "");
            addRow(71, "SMART_EVENT_GO_EVENT_INFORM", "Event ID", "", "", "", "");
            addRow(72, "SMART_EVENT_ACTION_DONE", "Event ID", "", "", "", "id = 1001 spellclick, id = 1002 fallonground, id = 1003 charge");	
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Hide();
        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }

        private void addRow(int index, string text1, string text2, string text3, string text4, string text5, string text6)
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

            DataGrid.Rows.Add(row);
        }

        public int Selected { get { return Convert.ToInt32(DataGrid.Rows[DataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString()); } }

        public override string ToString()
        {
            return Selected.ToString();
        }
    }
}
