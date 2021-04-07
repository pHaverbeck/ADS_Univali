#include <stdio.h>
#include <math.h>
int main()
{
    int opcao, numDec = 0, numBin = 0, resto = 0, casaDec = 1;
    //Declarar restante das variaveis
    printf("\n************************************************\n");
    printf("Bem vindo ao Conversor de Bases,\npor favor escolha sua opcao de conversao:\n");
    printf("1 - Decimal para Binario\n");
    printf("2 - Binario para Decimal\n");
    printf("************************************************\n");
        scanf("%d", &opcao);
        // Inserir um Switch Case
        switch(opcao){
            //Codigo conversao DECIMAL para BINARIO
            case 1:
            printf("Voce escolheu a opcao %d\n", opcao);
            printf("Digite o numero que deseja converter:\n");
                scanf("%d", &numDec);
                printf("A conversao do numero %d de Decimal para Binario resulta em %d\n", numDec, numBin);
                    while (numDec != 0){
                        resto = numDec % 2;
                        numDec /= 2;
                        numBin += resto * casaDec;
                        casaDec *= 10;
                    }
                    return numBin;
            break;

            //Codigo conversao BINARIO para DECIMAL
            case 2:
            printf("Voce escolheu a opcao %d\n", opcao);
                printf("Digite o numero que deseja converter:\n");
                scanf("%d", &numBin);
                    // Fazer operacoes de conversao

            printf("A conversao do numero %d de Binario para Decimal resulta em %d\n", numBin, numDec);
            break;
            default:
                printf("Por favor escolha uma opcao valida");
        }

return 0;
}