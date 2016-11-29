using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace Servidor.modelo
{
    class CifradoSimetrico
    {
        public byte[] llave { set; get; }
        public byte[] IV { set; get; }
        public int modo { set; get; } // 1 - CTR, 0 - CBC

        public CifradoSimetrico(int modo)
        {
            this.modo = modo;
            using (AesManaged modelo = new AesManaged())
            {
                modelo.KeySize = 192;
                modelo.GenerateKey();
                llave = modelo.Key;
                modelo.GenerateIV();
                IV = modelo.IV;
            }

            Console.WriteLine("Cifrador creado...");
        }

        public byte[] cifrar(object textoClaro)
        {
            // Check arguments.
            if (textoClaro == null) { throw new ArgumentNullException("plainText"); }
            byte[] textoCifrado;

            if ( modo == 1 )
            {
                using (Aes256CounterMode algoritmo = new Aes256CounterMode(IV))
                {
                    ICryptoTransform ict = algoritmo.CreateEncryptor(llave, null);

                    byte[] input = ObjectToByteArray(textoClaro);

                    foreach (byte b in input)
                        { Console.WriteLine("Byte original: " + b); }

                    textoCifrado = new byte[input.Length];
                    ict.TransformBlock(input, 0, input.Length, textoCifrado, 0);

                    foreach (byte b in textoCifrado)
                        { Console.WriteLine("Byte salido: " + b); }

                    //Console.WriteLine("A: " + a);
                }

                return textoCifrado;
            }

            else
            {
                using (AesManaged algoritmo = new AesManaged { Mode = CipherMode.CBC, KeySize = 192, Key = llave, IV = this.IV, BlockSize = 128 })
                {
                    algoritmo.Key = llave;
                    algoritmo.IV = IV;
                    ICryptoTransform encryptor = algoritmo.CreateEncryptor(algoritmo.Key, algoritmo.IV);

                    using ( MemoryStream to = new MemoryStream() )
                    {
                        using (CryptoStream writer = new CryptoStream(to, encryptor, CryptoStreamMode.Write))
                        {
                            byte[] input = ObjectToByteArray(textoClaro);
                            writer.Write( input , 0, input.Length );
                            writer.FlushFinalBlock();
                            textoCifrado = to.ToArray();
                        }
                    }
                }
                return textoCifrado;
            }
        }

        public object descifrar(byte[] textoCifrado)
        {
            // Check arguments.
            if (textoCifrado == null) { throw new ArgumentNullException("plainText"); }
            object textoClaro;

            if ( modo == 1 )
            {
                //Console.WriteLine("Llave: " + llave.Length);
                using ( Aes256CounterMode algoritmo = new Aes256CounterMode(IV) )
                {
                    ICryptoTransform ict = algoritmo.CreateEncryptor(llave, null);

                    byte[] txtClr = new byte[textoCifrado.Length];
                    int a = ict.TransformBlock(textoCifrado, 0, textoCifrado.Length, txtClr, 0);

                    //Console.WriteLine("A: " + a);

                    foreach (byte b in txtClr)
                        { Console.WriteLine("Salida: " + b); }

                    //ict.TransformFinalBlock(txtClr,0,txtClr.Length);
                }

                return ByteArrayToObject(textoCifrado);
            }
            else
            {
                using (AesManaged algoritmo = new AesManaged { Mode = CipherMode.CBC, KeySize = 192, Key = llave, IV = this.IV, BlockSize = 128 })
                {
                    ICryptoTransform decryptor = algoritmo.CreateDecryptor(llave, IV);

                    using (MemoryStream msDecrypt = new MemoryStream(textoCifrado))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            byte[] output = new byte[textoCifrado.Length];
                            csDecrypt.Read(output, 0, textoCifrado.Length);

                            textoClaro = ByteArrayToObject(output);
                        }
                    }
                }
                return textoClaro;
            }
        }

        public byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using ( MemoryStream ms = new MemoryStream() )
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public Object ByteArrayToObject(byte[] arrBytes)
        {
            using ( MemoryStream memStream = new MemoryStream() )
            {
                BinaryFormatter binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                object obj = binForm.Deserialize(memStream);
                return obj;
            }
        }

    }
}

