# Verify-Siret-Generate-TVA 

This code, written in C# .NET, verifies the validity of a company's Siret number in France.  

## Installation : 

To start using this project, follow these steps to install the necessary dependencies.

1. **Clone the Repository** :

   ```bash
   git clone https://github.com/YouvaLo/Verify-Siret-Is-Valid.git
   cd verify-siret-number

2. **Install Dependencies** : 

    ```bash
    dotnet add package Microsoft.Extensions.DependencyInjection
    dotnet add package Microsoft.Extensions.Hosting


This Code enables you to check the validity of the Siret number, based on the Luhn algorithm. 

## Explanation of the Luhn algorithm : 

    Step1 : Check that the SIRET is 14 digits long.
    
    Step2 : Scroll through the digits from right to left.
    
    Step3 : Digits with an odd index are multiplied by two (hence the Temp variable, which is false when the index is even and true when the index is odd).

    Step4 : The result of this multiplication by two, if is greater than 9, we subtract 9 otherwise we keep it as it is. 
    
    Step5 : We add up all the results.
    
    Step6 : If the total sum is a multiple of 10, then the siret is valid. 

---------------------------------------------------------------------------------------------------------------

