
//  Author: PHNO - Tecnólogo | Pós-Graduado em Energia Solar Fotovoltaica
//  Data Release: 29/11/2023
//  Versão Código: 2.0.1v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algoritmo: Dimensionamento e Calculo para Sistema Fotovoltaico na area de Energia Solar Fotovoltaica, 
// desenvolvido para estudantes e profissionais de engenharia eletrica e areas correlatas, como energias renovaveis.

#include <stdio.h> // importa lib
#include <stdlib.h> 
#include <math.h> 

int menu(); 
void op1(); // cabecalho
void op2(); 
void op3();
void op4();
void op5();
void op6();
void op7();
void op8();
int menu_developer();

int menu() { // Funcao Menu  
int op, c;

printf("\n  Dimensionamento e Calculo para Sistema Fotovoltaico \n");
printf("\n");
printf("\n\t Menu \n");

printf("\n1. Converter - volts [CA] em watts [CC]");
printf("\n2. Converter - watts [CC] em volts [CA]");
printf("\n3. Calcular a Potencia dos Modulos");
printf("\n4. Calcular Geração Semanal de Energia Solar");
printf("\n5. Calcular Geração Mensal de Energia Solar");
printf("\n6. Calcular Geração Anual de Energia Solar ");
printf("\n7. Calcular e Dimensionar a Quantidade de Modulos\n");
printf("\n[8] Info\n");
printf("\n[9] Sobre\n");
printf("\n10. Sair\n");

printf("\nDigite sua escolha: ");
scanf("%d", &op);

while ((c = getchar()) != '\n' && c != EOF) {} // limpar o buffer do teclado.   
return op; 
}

int main() { // Funcao principal

int op = 0, c;

while (op != -1) { 
op = menu(); 
switch (op) { 
case 1: 
op1(); // funcao 1
break; 
case 2: 
op2(); // funcao 2
break; 
case 3: 
op3(); // funcao 3
break;
case 4:
op4(); // funcao 4
break;
case 5: 
op5(); // funcao 5
break; 
case 6: 
op6(); // funcao 6
break;
case 7:
op7(); // funcao 7
break;
case 8:
op8(); // funcao 8
break;
case 9:
menu_developer(); // funcao 9
break;
case 10:
printf("\n");
printf("\n Algoritmo Finalizado! \n"); // Ao Sair
printf("\n");
return 0;
break;
default: // resposta padrao
printf("\n");
printf("Opcao Incorreta!\n"); 
printf("\n");
// printf("\n");
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
} 
} 
return 0; 
} 

void op1() { 
double v1;
double v2 = 10;
double resultado;
printf("\n");
printf("\n Digite quantos volts quer converter em watts: ");
scanf("%lf", &v1, stdin);
resultado = (v1 * v2);
printf("\n");
printf("\n Os %1.f volts inseridos equivalem a %1.f watts. \n", v1, resultado);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
//printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op2() { 
double v1;
double v2 = 10;
double resultado;
printf("\n");
printf("\n Digite quantos watts quer converter em volts: ");
scanf("%lf", &v1, stdin);
resultado = (v1 / v2);
printf("\n");
printf("\n Os %1.f watts inseridos equivalem a %1.f volts. \n", v1, resultado);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
//printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op3() { 
int v1;
int v2;
int resultado;
printf("\n");
printf("\n Digite a potencia nominal do modulo em watts: ");
scanf("%d", &v1, stdin);
printf("\n");
printf("\n Digite a quantidade de modulos: ");
scanf("%d", &v2, stdin);
resultado = (v1 * v2);
printf("\n A potencia dos modulos sera de %d watts.\n", resultado);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
//printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op4() { 
float v1;
float v2;
float v3;
float v4;
float v5 = 1000;
float resultado;
printf("\n");
printf("\n Digite a potencia dos modulos em watts: ");
scanf("%f", &v1, stdin);
printf("\n");
printf("\n Digite a quantidade de horas por dia: ");
scanf("%f", &v2, stdin);
printf("\n");
printf("\n Digite a quantidade de dias por semana: ");
scanf("%f", &v3, stdin);
v4 = (v1 * v2 * v3);
resultado = v4 / v5;
printf("\n o resultado sera %.2f kwh/semana geracao [leste/oeste]\n", resultado);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
// printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op5() { 
float v1;
float v2;
float v3;
float v4;
float v5 = 1000;
float resultado;
printf("\n");
printf("\n Digite a potencia dos modulos em watts: ");
scanf("%f", &v1, stdin);
printf("\n");
printf("\n Digite a quantidade de horas por dia: ");
scanf("%f", &v2, stdin);
printf("\n");
printf("\n Digite a quantidade de dias por mes: ");
scanf("%f", &v3, stdin);
v4 = (v1 * v2 * v3);
resultado = v4 / v5;
printf("\n o resultado sera %.2f kwh/mes geracao [leste/oeste]\n", resultado);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
// printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n"); 
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op6() { 
float v1;
float v2;
float v3;
float v4;
float v5 = 1000;
float resultado;
printf("\n");
printf("\n Digite a potencia dos modulos em watts: ");
scanf("%f", &v1, stdin);
printf("\n");
printf("\n Digite a quantidade de horas por dia: ");
scanf("%f", &v2, stdin);
printf("\n");
printf("\n Digite a quantidade de dias por ano: ");
scanf("%f", &v3, stdin);
v4 = (v1 * v2 * v3);
resultado = v4 / v5;
printf("\n o resultado sera %.2f kwh/ano geracao [leste/oeste]\n", resultado);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
// printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op7() { 
float v1;
float v2;
float resultado;
printf("\n");
printf("\n Digite a Potencia calculada do sistema (Pfv) em watts: ");
scanf("%f", &v1, stdin);
printf("\n");
printf("\n Digite a Potencia nominal do modulo em watts: ");
scanf("%f", &v2, stdin);
resultado = (v1 / v2);
printf("\n A quantidade maxima de modulos para este dimensionamento eh de %.2f placas fotovoltaicas.\n", resultado);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
// printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op8() { 
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
printf("\n");
printf("\nInfo ");
printf("\n");
printf("\nPara converter volts em watts multiplicamos os volts por 10.\n");
printf("\nPara converter watts em volts dividimos os watts por 10.\n");
printf("\nPara calcular a potencia dos modulos fazemos a multiplicacao da potencia nominal do modulo vezes a quantidade de modulos.\n");
printf("\nPara calcular a geração semanal utilizamos o calculo (potencia dos modulos)x(horas por dia)x(dias por semana). \n");
printf("\nPara calcular a geração mensal utilizamos o calculo (potencia dos modulos)x(horas por dia)x(dias por mes). \n");
printf("\nPara calcular a geração anual utilizamos o calculo (potencia dos modulos)x(horas por dia)x(dias por ano). \n");
printf("\nPara calcular e dimensionar a quantidade de modulos que compoe um painel solar utilizamos o seguinte calculo: \n");
printf("\nPotencia calculada do sistema (Pfv) em watts dividido pela Potencia nominal do modulo em watts = a Quantidade de Modulos.\n");
printf("\nPara converter 1kwh para 1wh basta fazer o calculo ex: 73kwh para wh sera 73000 wh.\n");
printf("\n");
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
// printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

int menu_developer(){
  system("clear");      // linux
  system("tput reset"); // linux
  printf("\n Algoritmo: Dimensionamento e Calculo para Sistema Fotovoltaico \n");
  printf("\n Author: PHNO ");
  printf("\n Data Release: 29/11/2023 ");
  printf("\n Versao Codigo: 2.0.1v");
  printf("\n Replit: @PHNO, @PHREPLIT");
  printf("\n E-mail: phreplit@gmail.com \n");
  printf("\n Teclar enter para retornar ao menu...\n ");
  getchar();
  scanf("c\n");
  system("clear");      // linux
  system("tput reset"); // linux
  return 0;
}
