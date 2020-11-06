namespace EduWatch.Utilities
{
    /// <summary>
    /// Interface for password hashing classes.
    /// </summary>
    interface IPasswordHash
    {
        int HashSize { get; set; }
        int SaltSize { get; set; }
        int Iterations { get; set; }

        string Generate(string pass);
        bool Verify(string pass, string hash);
    }
}
