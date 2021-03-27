#include <stdio.h>
int main()
{
    int opcao, numero;
    //Declarar restante das variaveis

    printf("************************************************\n");
    printf("Bem vindo ao Conversor de Bases,\n por favor escolha sua opção de conversão:\n");
    printf("1 - Decimal para Binario\n");
    prtinf("2 - Binario para Decimal\n")
    printf("************************************************\n");
        scanf("%d", &opcao);
        printf("Você escolheu a opção %d\n", opcao);
        printf("Digite o número que deseja converter:\n");
            scanf("%d", &numero);
            printf("A conversão do número %d para a opção %d resulta em X\n", numero, opcao);
return 0;
}