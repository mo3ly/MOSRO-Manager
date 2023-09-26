
using System;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace MOSROManager
{
    class ItemInfo
    {
        private int ItemID;
        private SqlDataReader ItemRow;
        string query = @" USE {0}
                        SELECT 
                        it.[ID64] ,oc.[ID] ,oc.[CodeName128] ,oc.[ReqLevel1], oc.[NameStrID128] ,it.[OptLevel] ,it.[Variance] ,it.[Data] ,oc.[AssocFileIcon128]
                        FROM [dbo].[_Items] AS it
                        LEFT JOIN [dbo].[_RefObjCommon] oc ON oc.ID = it.RefItemID
                        WHERE it.[ID64] = {1}";

        public ItemInfo(int ItemID)
        {
            this.ItemID = ItemID;
        }

        public async Task<StringBuilder> ItemData()
        {
            try
            {
                ItemRow = await Common.SqlConnection.GetReaderResult(query, Common.Config.SR_Shard, ItemID);
                await ItemRow.ReadAsync();

                StringBuilder tContent = new StringBuilder();
                // name and optlevel
                tContent.AppendLine($"{ItemName()}{OptLevel()}");
                // level
                if (ItemLevel() != null)
                    tContent.AppendLine($"{ItemLevel()}");
                // quantity
                if(Convert.ToInt32(ItemRow["Data"]) > 0)
                    tContent.AppendLine($"Quantity ({ItemRow["Data"]})");

                // Dev data
                tContent.AppendLine("\n[Development info]");
                tContent.AppendLine($"ID - {ItemRow["ID"]}");
                tContent.AppendLine($"ID64 - {ItemRow["ID64"]}\n");

                return tContent;
            } catch {
                Common.Dashboard.writeLog($"Error while loading item info ID64: {ItemID}.", 0);
            }
            return null;
        }

        private string ItemName()
        {
            if (ItemID != 0 && ItemRow != null && Common.ItemNameDictionary.ContainsKey(ItemRow["NameStrID128"].ToString()))
                return Common.ItemNameDictionary[ItemRow["NameStrID128"].ToString()];
            else
                return ItemRow["NameStrID128"].ToString();
        }

        private string OptLevel()
        {
            // add advance part
            if (Convert.ToInt32(ItemRow["OptLevel"]) > 0)
            {
                return $" (+{ItemRow["OptLevel"]})";
            }
            return null;
        }

        private string ItemSeal()
        {
            // power...
            // sos...
            // null if not seal
            return null;
        }
        
        private string ItemType()
        {
            //Sub Type
            //Type
            return null;
        }

        private string ItemDegree()
        {
            // degree
            return null;
        }

        private string ItemLevel() 
        {
            if (Convert.ToInt32(ItemRow["ReqLevel1"]) > 0)
            {
                return $"Level: {ItemRow["ReqLevel1"]}";
            }
            return null;
        }

        private string WhiteStates()
        {
            // variance states
            return null;
        }

        private string BlueStates()
        {
            // blue states
            return null;
        }
    }
}
