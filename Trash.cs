using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEditor
{
    class Trash
    {
        /////////// SEARCH LOAD
        //// OLD
        /*string query = String.Format("SELECT * FROM creature_template WHERE entry = {0}", query_id);

        mysql.Connection.Open();

        mysql.Command.CommandText = query;
        mysql.Reader = mysql.Command.ExecuteReader();

        while (mysql.Reader.Read())
        {
            List<string> result = new List<string>();

            for (int i = 0; i < mysql.Reader.FieldCount; i++)
                result.Add(mysql.Reader[i].ToString().Replace(",", "."));

            int row = 0;

            CreatureEditEntryBox.Text           = result[row++];
            CreatureEditDifficultyBox.Text      = result[row++];
            CreatureEditDifficulty2Box.Text     = result[row++];
            CreatureEditDifficulty3Box.Text     = result[row++];
            CreatureEditKillCreditBox.Text      = result[row++];
            CreatureEditKillCredit2Box.Text     = result[row++];
            CreatureEditModelIDBox.Text         = result[row++];
            CreatureEditModelID2Box.Text        = result[row++];
            CreatureEditModelID3Box.Text        = result[row++];
            CreatureEditModelID4Box.Text        = result[row++];
            CreatureEditNameBox.Text            = result[row++];
            CreatureEditSubNameBox.Text         = result[row++];
            CreatureEditIconNameBox.Text        = result[row++];
            CreatureEditGossipMenuIDBox.Text    = result[row++];
            CreatureEditMinLevelBox.Text        = result[row++];
            CreatureEditMaxLevelBox.Text        = result[row++];
            CreatureEditExpansionBox.Text       = result[row++];
            CreatureEditExpansionUnkBox.Text    = result[row++];
            CreatureEditFactionBox.Text         = result[row++];
            CreatureEditNPCFlagsBox.Text        = result[row++];
            CreatureEditWalkSpeedBox.Text       = result[row++];
            CreatureEditRunSpeedBox.Text        = result[row++];
            CreatureEditScaleBox.Text           = result[row++];
            CreatureEditRankBox.Text            = result[row++];
            CreatureEditMinDmgBox.Text          = result[row++];
            CreatureEditMaxDmgBox.Text          = result[row++];
            CreatureEditSchoolDamageBox.Text    = result[row++];
            CreatureEditAttackPowerBox.Text     = result[row++];
            CreatureEditDmgMultiplierBox.Text   = result[row++];
            CreatureEditBaseAttackTimeBox.Text  = result[row++];
            CreatureEditRangeAttackTimeBox.Text = result[row++];
            CreatureEditClassBox.Text           = result[row++];
            CreatureEditUnitFlagsBox.Text       = result[row++];
            CreatureEditUnitFlags2Box.Text      = result[row++];
            CreatureEditDynamicFlagsBox.Text    = result[row++];
            CreatureEditFamilyBox.Text          = result[row++];
            CreatureEditTrainerTypeBox.Text     = result[row++];
            CreatureEditTrainerSpellBox.Text    = result[row++];
            CreatureEditTrainerClassBox.Text    = result[row++];
            CreatureEditTrainerRaceBox.Text     = result[row++];
            CreatureEditMinRangeDmgBox.Text     = result[row++];
            CreatureEditMaxRangeDmgBox.Text     = result[row++];
            CreatureEditRangeAPBox.Text         = result[row++];
            CreatureEditTypeBox.Text            = result[row++];
            CreatureEditTypeFlagsBox.Text       = result[row++];
            CreatureEditTypeFlags2Box.Text      = result[row++];
            CreatureEditLootIDBox.Text          = result[row++];
            CreatureEditPickPocketIDBox.Text    = result[row++];
            CreatureEditSkinningIDBox.Text      = result[row++];
            CreatureEditResistanceBox.Text      = result[row++];
            CreatureEditResistance2Box.Text     = result[row++];
            CreatureEditResistance3Box.Text     = result[row++];
            CreatureEditResistance4Box.Text     = result[row++];
            CreatureEditResistance5Box.Text     = result[row++];
            CreatureEditResistance6Box.Text     = result[row++];
            CreatureEditSpellBox.Text           = result[row++];
            CreatureEditSpell2Box.Text          = result[row++];
            CreatureEditSpell3Box.Text          = result[row++];
            CreatureEditSpell4Box.Text          = result[row++];
            CreatureEditSpell5Box.Text          = result[row++];
            CreatureEditSpell6Box.Text          = result[row++];
            CreatureEditSpell7Box.Text          = result[row++];
            CreatureEditSpell8Box.Text          = result[row++];
            CreatureEditPetSpellDataBox.Text    = result[row++];
            CreatureEditVehicleIDBox.Text       = result[row++];
            CreatureEditMinGoldBox.Text         = result[row++];
            CreatureEditMaxGoldBox.Text         = result[row++];
            CreatureEditAINameBox.Text          = result[row++];
            CreatureEditMovementTypeBox.Text    = result[row++];
            CreatureEditInhabitTypeBox.Text     = result[row++];
            CreatureEditHoverHeightBox.Text     = result[row++];
            CreatureEditHealthBox.Text          = result[row++];
            CreatureEditManaBox.Text            = result[row++];
            CreatureEditMana2Box.Text           = result[row++];
            CreatureEditArmorBox.Text           = result[row++];
            CreatureEditRacialLeader.Checked    = Convert.ToInt32(result[row++]) == 1 ? true : false;
            CreatureEditQuestItemBox.Text       = result[row++];
            CreatureEditQuestItem2Box.Text      = result[row++];
            CreatureEditQuestItem3Box.Text      = result[row++];
            CreatureEditQuestItem4Box.Text      = result[row++];
            CreatureEditQuestItem5Box.Text      = result[row++];
            CreatureEditQuestItem6Box.Text      = result[row++];
            CreatureEditMovementIDBox.Text      = result[row++];
            CreatureEditHealthRegenBox.Text     = result[row++];
            CreatureEditEquipmentIDBox.Text     = result[row++];
            CreatureEditImmuneMaskBox.Text      = result[row++];
            CreatureEditExtraFlagsBox.Text      = result[row++];
            CreatureEditScriptNameBox.Text      = result[row++];
            CreatureEditWDBVerifiedBox.Text     = result[row++];
        }

        mysql.Connection.Close();

        //// LOCATION PAGE \\\\
        string query_location_count = $"SELECT COUNT(*) FROM creature WHERE id = {query_id}";
        string query_location = $"SELECT Guid, ID, Map, Position_X, Position_Y, Position_Z, Orientation, SpawnMask, PhaseMask, ModelID, Equipment_ID, SpawnTimeSecs, SpawnDist, CurrentWaypoint, CurHealth, CurMana, MovementType, NPCFlag, Unit_Flags, DynamicFlags FROM creature WHERE id = {query_id}";

        if (CreatureLocationDataGrid.RowCount > 0)
        {
            CreatureLocationDataGrid.Rows.Clear();

            for (int i = 0; i < CreatureLocationDataGrid.Rows.Count; i++)
            {
                if (CreatureLocationDataGrid.Rows[i].IsNewRow)
                    continue;

                CreatureLocationDataGrid.Rows.RemoveAt(i);
            }
        }

        mysql.Connection.Open();

        mysql.Command.CommandText = query_location_count;
        mysql.Reader = mysql.Command.ExecuteReader();

        int location_rows = 0;

        while(mysql.Reader.Read())
            location_rows = Convert.ToInt32(mysql.Reader[0].ToString());

        mysql.Reader.Close();

        mysql.Command.CommandText = query_location;
        mysql.Reader = mysql.Command.ExecuteReader();

        // DataGrid
        if(location_rows != 1 && location_rows != 0)
            CreatureLocationDataGrid.Rows.Add(location_rows - 1);

        int location_row_index = 0;

        if (mysql.Reader.HasRows)
        {
            while (mysql.Reader.Read())
            {
                List<string> result = new List<string>();

                for (int i = 0; i < mysql.Reader.FieldCount; i++)
                    result.Add(mysql.Reader[i].ToString().Replace(",", "."));

                for(int i = 0; i < 20; i++)
                    CreatureLocationDataGrid.Rows[location_row_index].Cells[i].Value = result[i].ToString();

                location_row_index += 1;
            }

            mysql.Reader.NextResult();
        }

        mysql.Connection.Close();

        //// MODEL INFO PAGE \\\\
        string query_modelInfo_count = String.Format("SELECT COUNT(*) FROM creature_model_info WHERE modelid in ({0}, {1}, {2}, {3})", CreatureEditModelIDBox.Text, CreatureEditModelID2Box.Text, CreatureEditModelID3Box.Text, CreatureEditModelID4Box.Text);
        string query_modelInfo = String.Format("SELECT ModelID, Bounding_Radius, Combat_Reach, Gender, ModelID_Other_Gender FROM creature_model_info WHERE modelid in ({0}, {1}, {2}, {3})", CreatureEditModelIDBox.Text, CreatureEditModelID2Box.Text, CreatureEditModelID3Box.Text, CreatureEditModelID4Box.Text);

        if (CreatureModelInfoDataGrid.RowCount > 0)
        {
            CreatureModelInfoDataGrid.Rows.Clear();

            for (int i = 0; i < CreatureModelInfoDataGrid.Rows.Count; i++)
            {
                if (CreatureModelInfoDataGrid.Rows[i].IsNewRow)
                    continue;

                CreatureModelInfoDataGrid.Rows.RemoveAt(i);
            }
        }

        mysql.Connection.Open();

        mysql.Command.CommandText = query_modelInfo_count;
        mysql.Reader = mysql.Command.ExecuteReader();

        int modelInfo_rows = 0;

        while (mysql.Reader.Read())
            modelInfo_rows = Convert.ToInt32(mysql.Reader[0].ToString());

        mysql.Reader.Close();

        mysql.Command.CommandText = query_modelInfo;
        mysql.Reader = mysql.Command.ExecuteReader();

        // DataGrid
        if (modelInfo_rows != 1 && modelInfo_rows != 0)
            CreatureModelInfoDataGrid.Rows.Add(modelInfo_rows - 1);

        int modelInfo_row_index = 0;

        if (mysql.Reader.HasRows)
        {
            while (mysql.Reader.Read())
            {
                List<string> result = new List<string>();

                for (int i = 0; i < mysql.Reader.FieldCount; i++)
                    result.Add(mysql.Reader[i].ToString().Replace(",", "."));

                for(int i = 0; i < 5; i++)
                    CreatureModelInfoDataGrid.Rows[modelInfo_row_index].Cells[i].Value = result[i].ToString();

                modelInfo_row_index += 1;
            }

            mysql.Reader.NextResult();
        }

        mysql.Connection.Close();

        //// LOOT PAGE \\\\
        string query_loot_count = String.Format("SELECT COUNT(*) FROM creature_loot_template WHERE entry = {0}", CreatureEditLootIDBox.Text);
        string query_loot = String.Format("SELECT Entry, Item, ChanceOrQuestChance, LootMode, GroupID, MinCountOrRef, MaxCount FROM creature_loot_template WHERE entry = {0}", CreatureEditLootIDBox.Text);

        if (CreatureLootDataGrid.RowCount > 0)
        {
            CreatureLootDataGrid.Rows.Clear();

            for (int i = 0; i < CreatureLootDataGrid.Rows.Count; i++)
            {
                if (CreatureLootDataGrid.Rows[i].IsNewRow)
                    continue;

                CreatureLootDataGrid.Rows.RemoveAt(i);
            }
        }

        mysql.Connection.Open();

        mysql.Command.CommandText = query_loot_count;
        mysql.Reader = mysql.Command.ExecuteReader();

        int loot_rows = 0;

        while (mysql.Reader.Read())
            loot_rows = Convert.ToInt32(mysql.Reader[0].ToString());

        mysql.Reader.Close();

        mysql.Command.CommandText = query_loot;
        mysql.Reader = mysql.Command.ExecuteReader();

        // DataGrid
        if (loot_rows != 1 && loot_rows != 0)
            CreatureLootDataGrid.Rows.Add(loot_rows - 1);

        int loot_row_index = 0;

        if (mysql.Reader.HasRows)
        {
            while (mysql.Reader.Read())
            {
                List<string> result = new List<string>();

                for (int i = 0; i < mysql.Reader.FieldCount; i++)
                    result.Add(mysql.Reader[i].ToString().Replace(",", "."));

                for (int i = 0; i < 7; i++)
                    CreatureLootDataGrid.Rows[loot_row_index].Cells[i].Value = result[i].ToString();

                loot_row_index += 1;
            }

            mysql.Reader.NextResult();
        }

        mysql.Connection.Close();

        //// PICK POCKET LOOT PAGE \\\\
        string query_PickPocketLoot_count = String.Format("SELECT COUNT(*) FROM pickpocketing_loot_template WHERE entry = {0}", CreatureEditPickPocketIDBox.Text);
        string query_PickPocketLoot = String.Format("SELECT Entry, Item, ChanceOrQuestChance, LootMode, GroupID, MinCountOrRef, MaxCount FROM pickpocketing_loot_template WHERE entry = {0}", CreatureEditPickPocketIDBox.Text);

        if (CreaturePickPocketLootDataGrid.RowCount > 0)
        {
            CreaturePickPocketLootDataGrid.Rows.Clear();

            for (int i = 0; i < CreaturePickPocketLootDataGrid.Rows.Count; i++)
            {
                if (CreaturePickPocketLootDataGrid.Rows[i].IsNewRow)
                    continue;

                CreaturePickPocketLootDataGrid.Rows.RemoveAt(i);
            }
        }

        mysql.Connection.Open();

        mysql.Command.CommandText = query_PickPocketLoot_count;
        mysql.Reader = mysql.Command.ExecuteReader();

        int PickPocketLoot_rows = 0;

        while (mysql.Reader.Read())
            PickPocketLoot_rows = Convert.ToInt32(mysql.Reader[0].ToString());

        mysql.Reader.Close();

        mysql.Command.CommandText = query_PickPocketLoot;
        mysql.Reader = mysql.Command.ExecuteReader();

        // DataGrid
        if (PickPocketLoot_rows != 1 && PickPocketLoot_rows != 0)
            CreaturePickPocketLootDataGrid.Rows.Add(PickPocketLoot_rows - 1);

        int PickPocketLoot_row_index = 0;

        if (mysql.Reader.HasRows)
        {
            while (mysql.Reader.Read())
            {
                List<string> result = new List<string>();

                for (int i = 0; i < mysql.Reader.FieldCount; i++)
                    result.Add(mysql.Reader[i].ToString().Replace(",", "."));

                for (int i = 0; i < 7; i++)
                    CreaturePickPocketLootDataGrid.Rows[PickPocketLoot_row_index].Cells[i].Value = result[i].ToString();

                PickPocketLoot_row_index += 1;
            }

            mysql.Reader.NextResult();
        }

        mysql.Connection.Close();

        //// SKINNING LOOT PAGE \\\\
        string query_SkinningLoot_count = String.Format("SELECT COUNT(*) FROM skinning_loot_template WHERE entry = {0}", CreatureEditSkinningIDBox.Text);
        string query_SkinningLoot = String.Format("SELECT Entry, Item, ChanceOrQuestChance, LootMode, GroupID, MinCountOrRef, MaxCount FROM skinning_loot_template WHERE entry = {0}", CreatureEditSkinningIDBox.Text);

        if (CreatureSkinningLootDataGrid.RowCount > 0)
        {
            CreatureSkinningLootDataGrid.Rows.Clear();

            for (int i = 0; i < CreatureSkinningLootDataGrid.Rows.Count; i++)
            {
                if (CreatureSkinningLootDataGrid.Rows[i].IsNewRow)
                    continue;

                CreatureSkinningLootDataGrid.Rows.RemoveAt(i);
            }
        }

        mysql.Connection.Open();

        mysql.Command.CommandText = query_SkinningLoot_count;
        mysql.Reader = mysql.Command.ExecuteReader();

        int SkinningLoot_rows = 0;

        while (mysql.Reader.Read())
            SkinningLoot_rows = Convert.ToInt32(mysql.Reader[0].ToString());

        mysql.Reader.Close();

        mysql.Command.CommandText = query_SkinningLoot;
        mysql.Reader = mysql.Command.ExecuteReader();

        // DataGrid
        if (SkinningLoot_rows != 1 && SkinningLoot_rows != 0)
            CreatureSkinningLootDataGrid.Rows.Add(SkinningLoot_rows - 1);

        int SkinningLoot_row_index = 0;

        if (mysql.Reader.HasRows)
        {
            while (mysql.Reader.Read())
            {
                List<string> result = new List<string>();

                for (int i = 0; i < mysql.Reader.FieldCount; i++)
                    result.Add(mysql.Reader[i].ToString().Replace(",", "."));

                for (int i = 0; i < 7; i++)
                    CreatureSkinningLootDataGrid.Rows[SkinningLoot_row_index].Cells[i].Value = result[i].ToString();

                SkinningLoot_row_index += 1;
            }

            mysql.Reader.NextResult();
        }

        mysql.Connection.Close();

        //// EQUIP TEMPLATE \\\\
        string query_EquipTemplate = String.Format("SELECT * FROM creature_equip_template WHERE entry = {0}", CreatureEditEquipmentIDBox.Text);

        // delete cache
        CreatureOtherEquipTemplateEntryBox.Text = String.Empty;
        CreatureOtherEquipTemplateItem1Box.Text = String.Empty;
        CreatureOtherEquipTemplateItem2Box.Text = String.Empty;
        CreatureOtherEquipTemplateItem3Box.Text = String.Empty;

        mysql.Connection.Open();

        mysql.Command.CommandText = query_EquipTemplate;
        mysql.Reader = mysql.Command.ExecuteReader();

        if (mysql.Reader.HasRows)
        {
            while (mysql.Reader.Read())
            {
                List<string> result = new List<string>();

                for (int i = 0; i < mysql.Reader.FieldCount; i++)
                    result.Add(mysql.Reader[i].ToString().Replace(",", "."));

                CreatureOtherEquipTemplateEntryBox.Text = result[0].ToString();
                CreatureOtherEquipTemplateItem1Box.Text = result[1].ToString();
                CreatureOtherEquipTemplateItem2Box.Text = result[2].ToString();
                CreatureOtherEquipTemplateItem3Box.Text = result[3].ToString();
            }
        }

        mysql.Connection.Close();

        //// TEMPLATE ADDON \\\\
        string query_TemplateAddon = String.Format("SELECT * FROM creature_template_addon WHERE entry = {0}", query_id);

        // delete cache
        CreatureOtherTemplateAddonEntryBox.Text  = String.Empty;
        CreatureOtherTemplateAddonPathIDBox.Text = String.Empty;
        CreatureOtherTemplateAddonMountBox.Text  = String.Empty;
        CreatureOtherTemplateAddonBytesBox.Text  = String.Empty;
        CreatureOtherTemplateAddonBytes2Box.Text = String.Empty;
        CreatureOtherTemplateAddonEmoteBox.Text  = String.Empty;
        CreatureOtherTemplateAddonAurasBox.Text  = String.Empty;

        mysql.Connection.Open();

        mysql.Command.CommandText = query_TemplateAddon;
        mysql.Reader = mysql.Command.ExecuteReader();

        if (mysql.Reader.HasRows)
        {
            while (mysql.Reader.Read())
            {
                List<string> result = new List<string>();

                for (int i = 0; i < mysql.Reader.FieldCount; i++)
                    result.Add(mysql.Reader[i].ToString().Replace(",", "."));

                CreatureOtherTemplateAddonEntryBox.Text  = result[0].ToString();
                CreatureOtherTemplateAddonPathIDBox.Text = result[1].ToString();
                CreatureOtherTemplateAddonMountBox.Text  = result[2].ToString();
                CreatureOtherTemplateAddonBytesBox.Text  = result[3].ToString();
                CreatureOtherTemplateAddonBytes2Box.Text = result[4].ToString();
                CreatureOtherTemplateAddonEmoteBox.Text  = result[5].ToString();
                CreatureOtherTemplateAddonAurasBox.Text  = result[6].ToString();
            }
        }

        mysql.Connection.Close();

        //// ADDON \\\\
        // delete cache
        CreatureOtherAddonGUIDBox.Text   = String.Empty;
        CreatureOtherAddonPathIDBox.Text = String.Empty;
        CreatureOtherAddonMountBox.Text  = String.Empty;
        CreatureOtherAddonBytesBox.Text  = String.Empty;
        CreatureOtherAddonBytes2Box.Text = String.Empty;
        CreatureOtherAddonEmoteBox.Text  = String.Empty;
        CreatureOtherAddonAurasBox.Text  = String.Empty;

        //// ON KILL REPUTATION \\\\
        string query_OnKillReputation = String.Format("SELECT * FROM creature_onkill_reputation WHERE creature_id = {0}", query_id);

        // delete cache
        CreatureOtherOnKillReputationEntryBox.Text            = String.Empty;
        CreatureOtherOnKillReputationFactionBox.Text          = String.Empty;
        CreatureOtherOnKillReputationFaction2Box.Text         = String.Empty;
        CreatureOtherOnKillReputationMaxStandingBox.Text      = String.Empty;
        CreatureOtherOnKillReputationValueBox.Text            = String.Empty;
        CreatureOtherOnKillReputationMaxStanding2Box.Text     = String.Empty;
        CreatureOtherOnKillReputationValue2Box.Text           = String.Empty;
        CreatureOtherOnKillReputationIsTeamAwardBox.Checked   = false;
        CreatureOtherOnKillReputationIsTeamAward2Box.Checked  = false;
        CreatureOtherOnKillReputationTeamDependentBox.Checked = false;

        mysql.Connection.Open();

        mysql.Command.CommandText = query_OnKillReputation;
        mysql.Reader = mysql.Command.ExecuteReader();

        if (mysql.Reader.HasRows)
        {
            while (mysql.Reader.Read())
            {
                List<string> result = new List<string>();
                string replace = String.Empty;

                for (int i = 0; i < mysql.Reader.FieldCount; i++)
                    result.Add(mysql.Reader[i].ToString().Replace(",", "."));

                CreatureOtherOnKillReputationEntryBox.Text        = result[0].ToString();
                CreatureOtherOnKillReputationFactionBox.Text      = result[1].ToString();
                CreatureOtherOnKillReputationFaction2Box.Text     = result[2].ToString();
                CreatureOtherOnKillReputationMaxStandingBox.Text  = result[3].ToString();
                CreatureOtherOnKillReputationValueBox.Text        = result[5].ToString();
                CreatureOtherOnKillReputationMaxStanding2Box.Text = result[6].ToString();
                CreatureOtherOnKillReputationValue2Box.Text       = result[8].ToString();

                if (result[4].ToString() == "1")
                    CreatureOtherOnKillReputationIsTeamAwardBox.Checked = true;
                if (result[7].ToString() == "1")
                    CreatureOtherOnKillReputationIsTeamAward2Box.Checked = true;
                if (result[9].ToString() == "1")
                    CreatureOtherOnKillReputationTeamDependentBox.Checked = true;
            }
        }

        mysql.Connection.Close();

        //// INVOLVED IN PAGE \\\\
        string query_InvolvedInStarts_count = String.Format("SELECT COUNT(*) FROM creature_questrelation WHERE id = {0}"   , query_id);
        string query_InvolvedInEnds_count   = String.Format("SELECT COUNT(*) FROM creature_involvedrelation WHERE id = {0}", query_id);
        string query_InvolvedInStarts       = String.Format("SELECT quest FROM creature_questrelation WHERE id = {0}"      , query_id);
        string query_InvolvedInEnds         = String.Format("SELECT quest FROM creature_involvedrelation WHERE id = {0}"   , query_id);

        // clear Starts
        if (CreatureInvolvedInTabStartsDataGrid.RowCount > 0)
        {
            CreatureInvolvedInTabStartsDataGrid.Rows.Clear();

            for (int i = 0; i < CreatureInvolvedInTabStartsDataGrid.Rows.Count; i++)
            {
                if (CreatureInvolvedInTabStartsDataGrid.Rows[i].IsNewRow)
                    continue;

                CreatureInvolvedInTabStartsDataGrid.Rows.RemoveAt(i);
            }
        }

        // clear Ends
        if (CreatureInvolvedInTabEndsDataGrid.RowCount > 0)
        {
            CreatureInvolvedInTabEndsDataGrid.Rows.Clear();

            for (int i = 0; i < CreatureInvolvedInTabEndsDataGrid.Rows.Count; i++)
            {
                if (CreatureInvolvedInTabEndsDataGrid.Rows[i].IsNewRow)
                    continue;

                CreatureInvolvedInTabEndsDataGrid.Rows.RemoveAt(i);
            }
        }

        mysql.Connection.Open();

        // starts count
        mysql.Command.CommandText = query_InvolvedInStarts_count;
        mysql.Reader = mysql.Command.ExecuteReader();

        int InvolvedInStarts_rows = 0;

        while (mysql.Reader.Read())
            InvolvedInStarts_rows = Convert.ToInt32(mysql.Reader[0].ToString());

        mysql.Reader.Close();

        // ends count
        mysql.Command.CommandText = query_InvolvedInEnds_count;
        mysql.Reader = mysql.Command.ExecuteReader();

        int InvolvedInEnds_rows = 0;

        while (mysql.Reader.Read())
            InvolvedInEnds_rows = Convert.ToInt32(mysql.Reader[0].ToString());

        mysql.Reader.Close();

        // add to list id of quest [Starts]
        mysql.Command.CommandText = query_InvolvedInStarts;
        mysql.Reader = mysql.Command.ExecuteReader();

        List<string> QuestListStarts = new List<string>();

        if (mysql.Reader.HasRows)
        {
            while (mysql.Reader.Read())
                QuestListStarts.Add(mysql.Reader[0].ToString());

            mysql.Reader.NextResult();
        }

        mysql.Reader.Close();

        // add to list id of quest [Ends]
        mysql.Command.CommandText = query_InvolvedInEnds;
        mysql.Reader = mysql.Command.ExecuteReader();

        List<string> QuestListEnds = new List<string>();

        if (mysql.Reader.HasRows)
        {
            while (mysql.Reader.Read())
                QuestListEnds.Add(mysql.Reader[0].ToString());

            mysql.Reader.NextResult();
        }

        mysql.Reader.Close();

        // query all quest [Starts]
        if (QuestListStarts.Count != 1 && QuestListStarts.Count != 0)
            CreatureInvolvedInTabStartsDataGrid.Rows.Add(QuestListStarts.Count - 1);

        for (int i = 0; i < QuestListStarts.Count; i++)
        {
            string query_InvolvedInStartsQuest = String.Format("SELECT Id, Title, Level, RequiredRaces, RewardOrRequiredMoney, RewardMoneyMaxLevel FROM quest_template WHERE id = {0}", QuestListStarts[i]);

            mysql.Command.CommandText = query_InvolvedInStartsQuest;
            mysql.Reader = mysql.Command.ExecuteReader();

            if (mysql.Reader.HasRows)
            {
                while(mysql.Reader.Read())
                {
                    CreatureInvolvedInTabStartsDataGrid.Rows[i].Cells[0].Value = mysql.Reader[0].ToString();
                    CreatureInvolvedInTabStartsDataGrid.Rows[i].Cells[1].Value = mysql.Reader[1].ToString();
                    CreatureInvolvedInTabStartsDataGrid.Rows[i].Cells[2].Value = mysql.Reader[2].ToString();

                    if (mysql.Reader[4].ToString() != "0")
                        CreatureInvolvedInTabStartsDataGrid.Rows[i].Cells[4].Value = String.Format("{0} Min coppers, {1} Max level coppers.", mysql.Reader[4].ToString(), mysql.Reader[5].ToString());
                    else
                        CreatureInvolvedInTabStartsDataGrid.Rows[i].Cells[4].Value = String.Format("{0} at Max level coppers.", mysql.Reader[5].ToString());

                    bool QuestIsAlliance = false;
                    bool QuestIsHorde = false;

                    string QuestFaction = String.Empty;

                    _Math.Math math = new _Math.Math();
                    string _math = math.DecimalToBinary(Convert.ToInt32(mysql.Reader[3].ToString()));

                    if(_math.Length >= 1)
                        if (_math.Substring(_math.Length - 1) == "1")
                            QuestIsAlliance = true;
                    if (_math.Length >= 2)
                        if (_math.Substring(_math.Length - 2, 1) == "1")
                            QuestIsHorde = true;
                    if (_math.Length >= 3)
                        if (_math.Substring(_math.Length - 3, 1) == "1")
                            QuestIsAlliance = true;
                    if (_math.Length >= 4)
                        if (_math.Substring(_math.Length - 4, 1) == "1")
                            QuestIsAlliance = true;
                    if (_math.Length >= 5)
                        if (_math.Substring(_math.Length - 5, 1) == "1")
                            QuestIsHorde = true;
                    if (_math.Length >= 6)
                        if (_math.Substring(_math.Length - 6, 1) == "1")
                            QuestIsHorde = true;
                    if (_math.Length >= 7)
                        if (_math.Substring(_math.Length - 7, 1) == "1")
                            QuestIsAlliance = true;
                    if (_math.Length >= 8)
                        if (_math.Substring(_math.Length - 8, 1) == "1")
                            QuestIsHorde = true;
                    if (_math.Length >= 9)
                        if (_math.Substring(_math.Length - 9, 1) == "1")
                            QuestIsHorde = true;
                    if (_math.Length >= 10)
                        if (_math.Substring(_math.Length - 10, 1) == "1")
                            QuestIsHorde = true;
                    if (_math.Length >= 11)
                        if (_math.Substring(_math.Length - 11, 1) == "1")
                            QuestIsAlliance = true;
                    if (_math.Length >= 12)
                        if (_math.Substring(_math.Length - 12, 1) == "1")
                            QuestIsAlliance = true;

                    if (QuestIsAlliance)
                        QuestFaction = "Alliance";
                    if (QuestIsHorde)
                        QuestFaction = "Horde";
                    if (QuestIsAlliance && QuestIsHorde)
                        QuestFaction = "Neutral";

                    CreatureInvolvedInTabStartsDataGrid.Rows[i].Cells[3].Value = QuestFaction;
                }

                mysql.Reader.NextResult();
            }

            mysql.Reader.Close();
        }

        // query all quest [Ends]
        if (QuestListEnds.Count != 1 && QuestListEnds.Count != 0)
            CreatureInvolvedInTabEndsDataGrid.Rows.Add(QuestListEnds.Count - 1);

        for (int i = 0; i < QuestListEnds.Count; i++)
        {
            string query_InvolvedInEndsQuest = String.Format("SELECT Id, Title, Level, RequiredRaces, RewardOrRequiredMoney, RewardMoneyMaxLevel FROM quest_template WHERE id = {0}", QuestListEnds[i]);

            mysql.Command.CommandText = query_InvolvedInEndsQuest;
            mysql.Reader = mysql.Command.ExecuteReader();

            if (mysql.Reader.HasRows)
            {
                while (mysql.Reader.Read())
                {
                    CreatureInvolvedInTabEndsDataGrid.Rows[i].Cells[0].Value = mysql.Reader[0].ToString();
                    CreatureInvolvedInTabEndsDataGrid.Rows[i].Cells[1].Value = mysql.Reader[1].ToString();
                    CreatureInvolvedInTabEndsDataGrid.Rows[i].Cells[2].Value = mysql.Reader[2].ToString();

                    if (mysql.Reader[4].ToString() != "0")
                        CreatureInvolvedInTabEndsDataGrid.Rows[i].Cells[4].Value = String.Format("{0} Min coppers, {1} Max level coppers.", mysql.Reader[4].ToString(), mysql.Reader[5].ToString());
                    else
                        CreatureInvolvedInTabEndsDataGrid.Rows[i].Cells[4].Value = String.Format("{0} at Max level coppers.", mysql.Reader[5].ToString());

                    bool QuestIsAlliance = false;
                    bool QuestIsHorde = false;

                    string QuestFaction = String.Empty;

                    _Math.Math math = new _Math.Math();
                    string _math = math.DecimalToBinary(Convert.ToInt32(mysql.Reader[3].ToString()));

                    if (_math.Length >= 1)
                        if (_math.Substring(_math.Length - 1) == "1")
                            QuestIsAlliance = true;
                    if (_math.Length >= 2)
                        if (_math.Substring(_math.Length - 2, 1) == "1")
                            QuestIsHorde = true;
                    if (_math.Length >= 3)
                        if (_math.Substring(_math.Length - 3, 1) == "1")
                            QuestIsAlliance = true;
                    if (_math.Length >= 4)
                        if (_math.Substring(_math.Length - 4, 1) == "1")
                            QuestIsAlliance = true;
                    if (_math.Length >= 5)
                        if (_math.Substring(_math.Length - 5, 1) == "1")
                            QuestIsHorde = true;
                    if (_math.Length >= 6)
                        if (_math.Substring(_math.Length - 6, 1) == "1")
                            QuestIsHorde = true;
                    if (_math.Length >= 7)
                        if (_math.Substring(_math.Length - 7, 1) == "1")
                            QuestIsAlliance = true;
                    if (_math.Length >= 8)
                        if (_math.Substring(_math.Length - 8, 1) == "1")
                            QuestIsHorde = true;
                    if (_math.Length >= 9)
                        if (_math.Substring(_math.Length - 9, 1) == "1")
                            QuestIsHorde = true;
                    if (_math.Length >= 10)
                        if (_math.Substring(_math.Length - 10, 1) == "1")
                            QuestIsHorde = true;
                    if (_math.Length >= 11)
                        if (_math.Substring(_math.Length - 11, 1) == "1")
                            QuestIsAlliance = true;
                    if (_math.Length >= 12)
                        if (_math.Substring(_math.Length - 12, 1) == "1")
                            QuestIsAlliance = true;

                    if (QuestIsAlliance)
                        QuestFaction = "Alliance";
                    if (QuestIsHorde)
                        QuestFaction = "Horde";
                    if (QuestIsAlliance && QuestIsHorde)
                        QuestFaction = "Neutral";

                    CreatureInvolvedInTabEndsDataGrid.Rows[i].Cells[3].Value = QuestFaction;
                }

                mysql.Reader.NextResult();
            }

            mysql.Reader.Close();
        }

        mysql.Connection.Close();

        //// SMARTAI PAGE \\\\
        if (CreatureSmartAIDataGrid.RowCount > 0)
        {
            CreatureSmartAIDataGrid.Rows.Clear();

            for (int i = 0; i < CreatureSmartAIDataGrid.Rows.Count; i++)
            {
                if (CreatureSmartAIDataGrid.Rows[i].IsNewRow)
                    continue;

                CreatureSmartAIDataGrid.Rows.RemoveAt(i);
            }
        }

        // select guids, entry
        string query_smartai_guids_count = String.Format("SELECT COUNT(*) FROM creature WHERE id = {0}", query_id);
        string query_smartai_guids = String.Format("SELECT guid FROM creature WHERE id = {0}", query_id);

        List<string> smartAI_guids = new List<string>();
        int smartai_guids_rows = 0;

        mysql.Connection.Open();

        // count guids
        mysql.Command.CommandText = query_smartai_guids_count;
        mysql.Reader = mysql.Command.ExecuteReader();

        while (mysql.Reader.Read())
            smartai_guids_rows = Convert.ToInt32(mysql.Reader[0].ToString());

        mysql.Reader.Close();

        // guids
        mysql.Command.CommandText = query_smartai_guids;
        mysql.Reader = mysql.Command.ExecuteReader();

        if(mysql.Reader.HasRows)
        {
            while (mysql.Reader.Read())
                smartAI_guids.Add("-" + mysql.Reader[0].ToString());

            mysql.Reader.NextResult();
        }

        mysql.Reader.Close();

        // basic entry
        string query_smartai_entry_count = String.Format("SELECT COUNT(*) FROM smart_scripts WHERE entryorguid = {0} and source_type = 0", query_id);
        string query_smartai_entry = String.Format("SELECT * FROM smart_scripts WHERE entryorguid = {0} and source_type = 0", query_id);

        mysql.Command.CommandText = query_smartai_entry_count;
        mysql.Reader = mysql.Command.ExecuteReader();

        int smartai_entry_rows = 0;

        while (mysql.Reader.Read())
            smartai_entry_rows = Convert.ToInt32(mysql.Reader[0].ToString());

        mysql.Reader.Close();

        mysql.Command.CommandText = query_smartai_entry;
        mysql.Reader = mysql.Command.ExecuteReader();

        if (smartai_entry_rows != 0 && smartai_entry_rows != 1)
            CreatureSmartAIDataGrid.Rows.Add(smartai_entry_rows - 1);

        int smartai_entry_row = 0;

        if (mysql.Reader.HasRows)
        {
            while (mysql.Reader.Read())
            {
                List<string> result = new List<string>();
                string replace = String.Empty;

                for (int i = 0; i < mysql.Reader.FieldCount; i++)
                {
                    replace = mysql.Reader[i].ToString().Replace(",", ".");
                    result.Add(replace);
                }

                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[0].Value = result[0].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[1].Value = result[1].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[2].Value = result[2].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[3].Value = result[3].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[4].Value = result[4].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[5].Value = result[5].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[6].Value = result[6].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[7].Value = result[7].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[8].Value = result[8].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[9].Value = result[9].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[10].Value = result[10].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[11].Value = result[11].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[12].Value = result[12].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[13].Value = result[13].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[14].Value = result[14].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[15].Value = result[15].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[16].Value = result[16].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[17].Value = result[17].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[18].Value = result[18].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[19].Value = result[19].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[20].Value = result[20].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[21].Value = result[21].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[22].Value = result[22].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[23].Value = result[23].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[24].Value = result[24].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[25].Value = result[25].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[26].Value = result[26].ToString();
                CreatureSmartAIDataGrid.Rows[smartai_entry_row].Cells[27].Value = result[27].ToString();

                smartai_entry_row++;
            }

            mysql.Reader.NextResult();
        }

        mysql.Reader.Close();

        // basic guids
        if (smartAI_guids.Count != 0 && smartAI_guids.Count != 1)
            CreatureSmartAIDataGrid.Rows.Add(smartAI_guids.Count - 1);

        for (int i = 0; i < smartAI_guids.Count; i++)
        {
            string query_smartai_count = String.Format("SELECT COUNT(*) FROM smart_scripts WHERE entryorguid = {0} and source_type = 0", smartAI_guids[i]);
            string query_smartai = String.Format("SELECT * FROM smart_scripts WHERE entryorguid = {0} and source_type = 0", smartAI_guids[i]);

            // smartai count
            mysql.Command.CommandText = query_smartai_count;
            mysql.Reader = mysql.Command.ExecuteReader();

            int smartai_rows = 0;

            while (mysql.Reader.Read())
                smartai_rows = Convert.ToInt32(mysql.Reader[0].ToString());

            mysql.Reader.Close();

            // smartai
            mysql.Command.CommandText = query_smartai;
            mysql.Reader = mysql.Command.ExecuteReader();

            if (mysql.Reader.HasRows)
            {
                while (mysql.Reader.Read())
                {
                    List<string> result = new List<string>();
                    string replace = String.Empty;

                    for (int j = 0; j < mysql.Reader.FieldCount; j++)
                    {
                        replace = mysql.Reader[j].ToString().Replace(",", ".");
                        result.Add(replace);
                    }

                    CreatureSmartAIDataGrid.Rows[i].Cells[0].Value = result[0].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[1].Value = result[1].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[2].Value = result[2].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[3].Value = result[3].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[4].Value = result[4].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[5].Value = result[5].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[6].Value = result[6].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[7].Value = result[7].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[8].Value = result[8].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[9].Value = result[9].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[10].Value = result[10].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[11].Value = result[11].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[12].Value = result[12].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[13].Value = result[13].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[14].Value = result[14].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[15].Value = result[15].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[16].Value = result[16].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[17].Value = result[17].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[18].Value = result[18].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[19].Value = result[19].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[20].Value = result[20].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[21].Value = result[21].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[22].Value = result[22].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[23].Value = result[23].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[24].Value = result[24].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[25].Value = result[25].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[26].Value = result[26].ToString();
                    CreatureSmartAIDataGrid.Rows[i].Cells[27].Value = result[27].ToString();
                }

                mysql.Reader.NextResult();
            }

            mysql.Reader.Close();
        }

        mysql.Connection.Close();*/
    }
}
