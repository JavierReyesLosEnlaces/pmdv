﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    internal class AesCryp
    {
        public static string IV = "asdfghjklñzxcvbn"; // 16 caracteres
        public static string Key = "asdfghjklñzxcvbnasdfghjklñzxcvbn"; // 32 caracteres

        //Llamada al servicio de criptografía

        public static string Encrypt(string decrypted)
        {
            byte[] textbytes = ASCIIEncoding.ASCII.GetBytes(decrypted);

            AesCryptoServiceProvider encdec = new AesCryptoServiceProvider();
            encdec.BlockSize = 128;
            encdec.KeySize = 256;
            encdec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            encdec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            encdec.Padding = PaddingMode.PKCS7;
            encdec.Mode = CipherMode.CBC;

            //Encriptador
            ICryptoTransform icrypt = encdec.CreateEncryptor(encdec.Key, encdec.IV);

            byte[] enc = icrypt.TransformFinalBlock(textbytes,0, textbytes.Length);
            icrypt.Dispose();

            return Convert.ToBase64String(enc);
        }

        public static string Decrypt(string encrypted)
        {
            byte[] encbytes = Convert.FromBase64String(encrypted);

            AesCryptoServiceProvider encdec = new AesCryptoServiceProvider();
            encdec.BlockSize = 128;
            encdec.KeySize = 256;
            encdec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            encdec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            encdec.Padding = PaddingMode.PKCS7;
            encdec.Mode = CipherMode.CBC;

            //Encriptador
            ICryptoTransform icrypt = encdec.CreateDecryptor(encdec.Key, encdec.IV);

            byte[] dec = icrypt.TransformFinalBlock(encbytes, 0, encbytes.Length);
            icrypt.Dispose();

            return ASCIIEncoding.ASCII.GetString(dec);
        }
    }
}
