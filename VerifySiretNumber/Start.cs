using System;
//using VerifySiretGenerateTVA.Exceptions;
using VerifySiretNumber.Services;
namespace VerifySiretNumber;

public class Start
{
   private readonly IVerifySiret _verifySiretNumber;

   public Start(IVerifySiret verifySiretNumber)
   {
      _verifySiretNumber = verifySiretNumber;
   }

   public void Run()
   {
      Console.Write("Please enter the Siret number : ");
      var siret = Console.ReadLine();
      while (!_verifySiretNumber.IsSiretValid(siret))
      {
         Console.Write("The siret number is invalid, try again : ");
         siret = Console.ReadLine();
      }

      ////Or use Invalid Exception  
      //if (!_verifySiretNumber.IsSiretValid(siret)) 
      //   throw new InvalidSiretException("The siret number is invalid, please try again ! ");
   }
}
