#include <stdio.h>
#include <math.h>

//Função de conversão Decimal para Binário
long long int decToBin (long long int numDec){
    long long int numBin = 0;
    long long int resto, casaDec = 1;
    while (numDec != 0){
        resto = numDec % 2;
        numDec /= 2;
        numBin += resto * casaDec;
        casaDec *= 10;
    }
    return numBin;
    //Melhorar resultado, faltam zeros a esquerda em alguns casos; verificar se é possível separar os numeros binarios de 4 em 4 casas
    //Verificar necessidade de declarar algumas variáveis como 'long long'
}

//Função de conversão Binário para Decimal
long long int binToDec (long long int numBin){
    long long int numDec = 0, casaBin = 0, resto;
    while (numBin != 0){
        resto = numBin % 10;
        numBin /= 10;
        numDec += resto*pow(2, casaBin);
        casaBin++;
    }
    return numDec;
    //Melhorar resultado, números não binários "funcionam"
    //Verificar necessidade de declarar algumas variáveis como 'long long'
}
int main()
{
    long long int opcao, numDec, numBin;
    printf("\n************************************************\n");
    printf("Bem vindo ao Conversor de Bases,\npor favor escolha sua opcao de conversao:\n");
    printf("1 - Decimal para Binario\n");
    printf("2 - Binario para Decimal\n");
    printf("************************************************\n");
        scanf("%lld", &opcao);
        // Inserir um Switch Case
        switch(opcao){
            //Codigo conversao DECIMAL para BINARIO
            case 1:
            printf("\nVoce escolheu a opcao %lld\n", opcao);
                printf("\nDigite o numero que deseja converter:\n");
                scanf("%lld", &numDec);
                printf("\nA conversao do numero %lld de Decimal para Binario resulta em %lld\n", numDec, decToBin(numDec));
            break;

            //Codigo conversao BINARIO para DECIMAL
            case 2:
            printf("\nVoce escolheu a opcao %lld\n", opcao);
                printf("\nDigite o numero que deseja converter:\n");
                scanf("%lld", &numBin);
                printf("\nA conversao do numero %lld de Binario para Decimal resulta em %lld\n", numBin, binToDec(numBin));
            break;
            default:
                printf("\nPor favor escolha uma opcao valida");
        }

return 0;
}
