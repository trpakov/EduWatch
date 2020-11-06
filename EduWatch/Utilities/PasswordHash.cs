using System;
using System.Security.Cryptography;

namespace EduWatch.Utilities
{
    /// <summary>
    /// A class that hashes a plain text password and checks if a password corresponds to a given hash.
    /// </summary>
    internal class PasswordHash : IPasswordHash
    {
        int _saltSize = 0;
        int _hashSize = 0;
        int _iterations = 0;

        public int SaltSize {
            get => _saltSize;
            set {
                if (value < 8) throw new ArgumentException("The specified salt size is smaller than 8 bytes.");
                _saltSize = value;
            } }

        public int HashSize {
            get => _hashSize;
            set {
                if (value < 16) throw new ArgumentException("The specified hash size is too small. Use a number larger than 16.");
                _hashSize = value;
            } }

        public int Iterations {
            get => _iterations;
            set {
                if (value < 1) throw new ArgumentException("The specified iteration size is smaller than 1.");
                _iterations = value;
            } }

        public PasswordHash(int saltSize = 16, int hashSize = 20, int iterations = 10000)
        {
            SaltSize = saltSize;
            HashSize = hashSize;
            Iterations = iterations;
        }
        
        // Cryptographic random number generator
        static readonly RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        public string Generate(string password)
        {
            if (password == null) throw new ArgumentNullException(password, "The password is null.");

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

        public bool Verify(string userInputPass, string saltAndHashString)
        {
            if (userInputPass == null) throw new ArgumentNullException(userInputPass, "The password is null.");

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
