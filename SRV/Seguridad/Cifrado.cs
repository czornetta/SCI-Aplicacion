using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Servicios.Seguridad
{
    public static class Cifrado
    {
        private static byte[] Llave 
        {
            get
            {
                string llave = "llaveDeEntriptacion";
                var md5 = new MD5CryptoServiceProvider();
                var llaveCifrada = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(llave));

                return llaveCifrada;
            }
        }

    public static string Cifrar(string value)
        {
            var md5 = new MD5CryptoServiceProvider();
            var md5data = md5.ComputeHash(Encoding.ASCII.GetBytes(value));

            return Convert.ToBase64String(md5data);

        }

        public static string Encriptar(string texto)
        {
            string textoEncriptado;
            try
            {
                byte[] textoBytes = UTF8Encoding.UTF8.GetBytes(texto);

                //Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = Llave;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateEncryptor();
                byte[] textoEncriptadoBytes = cTransform.TransformFinalBlock(textoBytes, 0, textoBytes.Length);
                tdes.Clear();

                //Conversión a String
                textoEncriptado = Convert.ToBase64String(textoEncriptadoBytes, 0, textoEncriptadoBytes.Length);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return textoEncriptado;
        }


        public static string Desencriptar(string textoEncriptado)
        {
            string texto;

            try
            {
                byte[] textoEncriptadoBytes = Convert.FromBase64String(textoEncriptado);

                //Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = Llave;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] textoBytes = cTransform.TransformFinalBlock(textoEncriptadoBytes, 0, textoEncriptadoBytes.Length);
                tdes.Clear();
                texto = UTF8Encoding.UTF8.GetString(textoBytes);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return texto;
        }
    }
}
