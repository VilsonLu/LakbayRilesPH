using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace LakbayRilesPH.Controller
{
    public class Login
    {
        public static Staff VerifyCredentials(String username, String password)
        {
            var db = WebMatrix.Data.Database.Open("SQLAzureConnection");
            var selectQuery = "SELECT StaffID, Username, FirstName, LastName, StationHandle, LineHandle FROM Staff WHERE Username = @0 and Password = @1";
            var result = db.QuerySingle(selectQuery, username, password);
            if (result != null)
            {
                Staff account = new Staff();
                account.StaffID = result["StaffID"];
                account.Username = result["Username"];
                account.FirstName = result["FirstName"];
                account.LastName = result["LastName"];
                if (result["StationHandle"] != null)
                {
                    account.StationHandle = result["StationHandle"];
                }
                else
                {
                    account.StationHandle = -1;
                }
       
                if (result["LineHandle"] != null)
                {
                    account.LineHandle = result["LineHandle"];
                }
                else
                {
                    account.LineHandle = -1;
                }
                return account;
            }
            else
            {
                return null;
            }
        }

        private static byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(cipherData, 0, cipherData.Length);
            cs.Close();
            byte[] decryptedData = ms.ToArray();

            return decryptedData;
        }

        private static string Decrypt(string cipherText)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes("xx[hello]167w", new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 
            0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
            byte[] decryptedData = Decrypt(cipherBytes, pdb.GetBytes(32), pdb.GetBytes(16));
            return System.Text.Encoding.Unicode.GetString(decryptedData);
        }
    }


}