using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System;

namespace MOSROManager
{
    public partial class pNewUser : UserControl
    {

        public pNewUser()
        {
            InitializeComponent();
            //Console.WriteLine(CreateMD5("123456"));
        }

        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            try
            {
                int isUserFound = await Common.SqlConnection.RowCount($"SELECT TOP 1 StrUserID FROM {Common.Config.SR_Account}..TB_User Where StrUserID = '{tUsername.Text}'");
                if (tUsername.Text.Length > 1 && tPassword.Text.Length > 1)
                {
                    if (isUserFound == 0)
                    {
                        string query = @"DECLARE @Username VARCHAR(16) = '{1}' --enter username
                                , @Password VARCHAR(16) = '{2}' --enter password
                                , @MD5 VARCHAR(32)
                                , @NewJID INT

                                SET @MD5 = CONVERT(VARCHAR(32), HashBytes('MD5', @Password) ,2)

                                INSERT INTO {0}..TB_User (StrUserID, [password], sec_primary, sec_content, Email, Name, phone, address)
                                VALUES (@Username, @MD5, {3}, {4}, '{5}', '{6}', '{7}', '{8}')

                                SET @NewJID = SCOPE_IDENTITY()

                                INSERT INTO {0}..SK_Silk
                                VALUES (@NewJID, 0, 0, 0)";
                        await Common.SqlConnection.ExecuteNonQuery(query, Common.Config.SR_Account, tUsername.Text, tPassword.Text, tSecurityPrimary.Text, tSecurityContent.Text, tEmail.Text, tName.Text, tPhone.Text, tAddress.Text);
                        Common.Dashboard.writeLog("Account has been created successfully", 1);
                    }
                    else
                        Common.Dashboard.writeLog("This username is already used!", 2);
                } else
                    Common.Dashboard.writeLog("Username and password cannot be empty!", 2);
            } catch (Exception ex)
            {
                Common.Dashboard.writeLog("Error has been occurred while creating a new account, ERROR: "+ex.Message, 0);
            }
        }
    }
}
