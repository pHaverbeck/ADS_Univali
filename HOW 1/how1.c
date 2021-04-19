#include <stdio.h>
#include <math.h>

//Função de conversão Decimal para Binário.
unsigned long long int decToBin (unsigned long long int numDec) // Declaração de função decimal para binário, que utiliza número decimal de entrada. Utilizado unsigned long long int para armazenar o máximo possível de dados.
{ 
    unsigned long long int numBin = 0;
    unsigned long long int resto, casaDec = 1;
    while (numDec != 0)                     // Número decimal deve ser diferente de zero. Quando for zero, irá retornar número binário zero.
    {                    
        resto = numDec % 2;                 // Cálculo do resto para operação de conversão.
        numDec /= 2;                        // Após operação de resto, o número em questão é dividido por 2 para continuar próximas operações.
        numBin += resto * casaDec;          // O número binário resultante é a soma do número binário anterior (zero para a primeira iteração) com a multiplicação do resto recém calculado e a casa decimal referente à operação (começa em 1).
        casaDec *= 10;                      // Atualização da casa decimal para próxima iteração; É a multiplicação da casa decimal atual por 10.
    }
    return numBin;                          // Retorna o valor em binário.
}

//Função de conversão Binário para Decimal.
unsigned long long int binToDec (unsigned long long int numBin) // Mesma situação já descrita acima, mas para função binário para decimal.
{
    unsigned long long int numDec = 0, casaBin = 0, resto;
    while (numBin != 0)                     // Número binário deve ser diferente de zero. Quando for zero, retornará zero para a conversão.
    {                    
        resto = numBin % 10;                // Cálculo do resto para operação de conversão.
        numBin /= 10;                       // Após a operação de resto, o número em questão é dividido por 10 para continuar próximas operações.
        numDec += resto*pow(2, casaBin);    // O número decimal resultante é a soma do número decimal anterior (zero para primeira iteração) com a multiplicação do resto recém calculado e a o número 2 elevado na casa em que o número binário se encontra (zero para primeira iteração).
        casaBin++;                          // Atualização da casa binária para próxima iteração (soma 1).
    }
    return numDec;                          // Retorna o valor em decimal.
}
int main()
{
    int opcao;
    unsigned long long int numDec, numBin;
    printf("\n************************************************\n");
    printf("Bem vindo ao Conversor de Bases,\npor favor escolha sua opcao de conversao:\n");
    printf("1 - Decimal para Binario\n");
    printf("2 - Binario para Decimal\n");
    printf("************************************************\n");
    scanf("%d", &opcao);                // Scan da escolha de opção
        switch(opcao)                   // Switch case para as escolhas
        {                  
            case 1:                     // Case 1: Codigo conversao DECIMAL para BINARIO
            printf("\nVoce escolheu a opcao %llu\n", opcao);
                printf("\nDigite o numero que deseja converter:\n");
                scanf("%llu", &numDec); // Scan do número decimal desejado para fazer operação, e alocação de tal na variável numDec.
                printf("\nA conversao do numero %llu de Decimal para Binario resulta em %llu\n", numDec, decToBin(numDec)); // Descrição da operação realizada com o resultado da função decTobin.
                printf("************************************************\n");
            break;
            case 2:                     // Case 2: Codigo conversao BINARIO para DECIMAL
            printf("\nVoce escolheu a opcao %llu\n", opcao);
                printf("\nDigite o numero que deseja converter:\n");
                scanf("%llu", &numBin); // Scan do número binário desejado para fazer operação, e alocação de tal na variável numBin.
                printf("\nA conversao do numero %llu de Binario para Decimal resulta em %llu\n", numBin, binToDec(numBin)); // Descrição da operação realizada com o resultado da função binToDec.
                printf("************************************************\n");
            break;
            default:
                printf("\nPor favor escolha uma opcao valida\n"); // Case Padrão: Caso não sejam inseridos os números 1 ou 2 nas opções de operação, esta mensagem será apresentada.
                printf("************************************************\n");
        }

return 0;
}
