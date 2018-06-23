using System;
using System.Text;

namespace OTP
{
    class otp
    {
        public long time = 0;
        public string key = null;
        public long distance = 0;

        public long getkey(byte[] a)
        {
            long key = 0;
            for (int i = 0; i < a.Length; i++)
            {
                key += a[i];
            }

            return key / a.Length;
        }

        public long generate()
        {
            long encode = generatehash(key);
            string stamp = (time / distance * encode).ToString();      
            long hash = generatehash(stamp);
            long shash = (long)Math.Pow(hash, 3);

            return shash;
        }

        public bool verify(long hash)
        {
            if (generate().Equals(hash))
                return true;
            else
                return false;
        }
        
        public long generatehash(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            System.Security.Cryptography.SHA256 sHA256 = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sHA256.ComputeHash(bytes);

            return getkey(hash);
        }
    }

}
