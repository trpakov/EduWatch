using System;
using System.Security.Cryptography;

namespace EduWatch.Utilities
{
    internal static class PasswordHash
    {
        const int SaltSize = 16;
        const int HashSize = 20;
        const int Iterations = 10000;
        
        // Cryptographic random number generator
        static readonly RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        internal static string Generate(string password)
        {
            // Create salt array and fill it with cryptographically strong sequence of random values
            byte[] salt = new byte[SaltSize];
            rng.GetBytes(salt);

            // Create hash array and generate hash using Rfc2898DeriveBytes, which implements password-based key derivation
            using(var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
            {
                byte[] hash = pbkdf2.GetBytes(HashSize);

                // Combine salt and hash and return the result as a base-64 string
                byte[] saltAndHash = new byte[SaltSize + HashSize];
                Array.Copy(salt, 0, saltAndHash, 0, SaltSize);
                Array.Copy(hash, 0, saltAndHash, SaltSize, HashSize);
                return Convert.ToBase64String(saltAndHash);
            }
        }

        internal static bool Verify(string userInputPass, string saltAndHashString)
        {
            // Convert the stored salt+hash combo to byte array and extract the salt
            byte[] saltAndHash = Convert.FromBase64String(saltAndHashString);
            byte[] salt = new byte[SaltSize];
            Array.Copy(saltAndHash, 0, salt, 0, SaltSize);

            // Use the password entered by the user and the salt to generate a hash
            using(var pbkdf2 = new Rfc2898DeriveBytes(userInputPass, salt, Iterations))
            {
                byte[] hash = pbkdf2.GetBytes(HashSize);

                // If the two hashes are different the password is incorrect, else its correct
                for (int i = 0; i < HashSize; i++)
                    if (hash[i] != saltAndHash[SaltSize + i]) return false;
            }

            return true;
        }
    }
}
