using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockDB
{
    public class Mine
    {
        public static string GetHash(int Block, string Data, ref long Nonce, string PreviousBlock = "0000000000000000000000000000000000000000000000000000000000000000", char Character = '0', int Dificulty = 4)
        {
            string chars = new String(Character, Dificulty);
            string hash = "";
            string block = Block.ToString();
            string previousBlock = PreviousBlock;
            for (long i = 0; i < Int64.MaxValue; i++)
            {
                string data = block + previousBlock + Data + i.ToString();
                hash = Hashes.SHA256Of(data);
                if (hash.Substring(0, chars.Length) == chars)
                {
                    Nonce = i;
                    break;
                }
            }
            return hash;
        }

        public static string GetHashParallel(int Block, string Data, ref int Nonce, string PreviousBlock = "0000000000000000000000000000000000000000000000000000000000000000", char Character = '0', int Dificulty = 4)
        {
            string chars = new String(Character, Dificulty);
            string hash = "";
            string block = Block.ToString();
            string previousBlock = PreviousBlock.ToString();
            int nonce = Nonce;
            Parallel.For(0, int.MaxValue, (i, loopState) =>
            {
                string data = block + previousBlock + Data + i.ToString();
                string hash2 = Hashes.SHA256Of(data);
                if (hash2.Substring(0, chars.Length) == chars)
                {
                    hash = hash2;
                    nonce = i;
                    loopState.Break(); 
                }
            });
            Nonce = nonce;
            return hash;
        }

        public static bool ValidateHash(string Hash,int Block, string Data, long Nonce, string PreviousBlock = "0000000000000000000000000000000000000000000000000000000000000000", char Character = '0', int Dificulty = 4)
        {
            string chars = new String(Character, Dificulty);
            bool valid = Hash.Substring(0, chars.Length) == chars;

            if (valid)
            {
                string data = Block.ToString() + PreviousBlock + Data + Nonce.ToString();
                valid = Hashes.SHA256Of(data) == Hash;
            }
           
            return valid;
        }
    }
}
