#include <stdio.h>
#include <math.h>
int main()
{
    int opcao, numero;
    //Declarar restante das variaveis

    printf("\n************************************************\n");
    printf("Bem vindo ao Conversor de Bases,\npor favor escolha sua opcao de conversao:\n");
    printf("1 - Decimal para Binario\n");
    printf("2 - Binario para Decimal\n");
    printf("************************************************\n");
        scanf("%d", &opcao);
        printf("Voce escolheu a opcao %d\n", opcao);
        // Inserir um Switch Case
        switch(opcao){
            //Codigo conversao DECIMAL para BINARIO
            case 1:
                printf("Digite o numero que deseja converter:\n");
                scanf("%d", &numero);
                    // Fazer operacoes de conversao
            
            printf("A conversao do numero %d para a opcao %d resulta em X\n", numero, opcao);
            break;

            //Codigo conversao BINARIO para DECIMAL
            case 2:
                printf("Digite o numero que deseja converter:\n");
                scanf("%d", &numero);
                    // Fazer operacoes de conversao
            
            printf("A conversao do numero %d para a opcao %d resulta em X\n", numero, opcao);
            break;
            default:
                printf("Por favor escolha uma opção válida");
        }

return 0;
}