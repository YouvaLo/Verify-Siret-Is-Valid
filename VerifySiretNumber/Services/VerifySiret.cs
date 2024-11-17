using System;

namespace VerifySiretNumber.Services;

public class VerifySiret : IVerifySiret
{
   // Luhn Algorithm to verify if Siret number is valid
   public bool IsSiretValid(string siret)
   {
      //The siret number must be not null and 14 digits long 
      if (string.IsNullOrEmpty(siret) || siret.Length != 14) return false;

      int sum = 0;
      bool temp = false;

      for (int i = siret.Length - 1; i >= 0; i--)
      {
         int digit = int.Parse(siret[i].ToString());

         //Temp = true -> digit impair 
         if (temp)
         {
            digit *= 2;
            if (digit > 9) digit -= 9;
         }

         sum += digit;
         //when i is odd, temp is true, else temp is false 
         temp = !temp;
      }

      //true when sum is multiple of 10 
      return (sum % 10 == 0);
   }
}
