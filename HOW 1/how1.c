#include <stdio.h>
#include <math.h>

//Função de conversão Decimal para Binário
unsigned long long int decToBin (unsigned long long int numDec){
    unsigned long long int numBin = 0;
    unsigned long long int resto, casaDec = 1;
    while (numDec != 0){
        resto = numDec % 2;
        numDec /= 2;
        numBin += resto * casaDec;
        casaDec *= 10;
    }
    return numBin;
}

//Função de conversão Binário para Decimal
unsigned long long int binToDec (unsigned long long int numBin){
    unsigned long long int numDec = 0, casaBin = 0, resto;
    while (numBin != 0){
        resto = numBin % 10;
        numBin /= 10;
        numDec += resto*pow(2, casaBin);
        casaBin++;
    }
    return numDec;
}
int main()
{
    unsigned long long int opcao, numDec, numBin;
    printf("\n************************************************\n");
    printf("Bem vindo ao Conversor de Bases,\npor favor escolha sua opcao de conversao:\n");
    printf("1 - Decimal para Binario\n");
    printf("2 - Binario para Decimal\n");
    printf("************************************************\n");
        scanf("%llu", &opcao);
        // Inserir um Switch Case
        switch(opcao){
            //Codigo conversao DECIMAL para BINARIO
            case 1:
            printf("\nVoce escolheu a opcao %llu\n", opcao);
                printf("\nDigite o numero que deseja converter:\n");
                scanf("%llu", &numDec);
                printf("\nA conversao do numero %llu de Decimal para Binario resulta em %llu\n", numDec, decToBin(numDec));
            break;

            //Codigo conversao BINARIO para DECIMAL
            case 2:
            printf("\nVoce escolheu a opcao %llu\n", opcao);
                printf("\nDigite o numero que deseja converter:\n");
                scanf("%llu", &numBin);
                printf("\nA conversao do numero %llu de Binario para Decimal resulta em %llu\n", numBin, binToDec(numBin));
            break;
            default:
                printf("\nPor favor escolha uma opcao valida");
        }

return 0;
}
