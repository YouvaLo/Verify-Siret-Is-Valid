using System;

namespace VerifySiretNumber.Services;

public interface IVerifySiret
{
   bool IsSiretValid(string siret);
}
