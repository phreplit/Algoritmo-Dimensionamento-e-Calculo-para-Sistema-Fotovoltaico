
// Author: PHNO - Tecnologo | Pos-Graduado em Energia Solar Fotovoltaica
// Data Release: 29/11/2024
// Versao Codigo: 0.0.0.2v
// Replit: @PHNO, @PHREPLIT
// E-mail: phreplit@gmail.com

// Algoritmo: Dimensionamento e Calculo para Sistema Fotovoltaico na area de Energia Solar Fotovoltaica, 
// desenvolvido para estudantes e profissionais de engenharia eletrica e areas correlatas, como energias renovaveis.

import java.io.IOException;
import java.util.Scanner; // importa lib

public class Main {

public static void main(String[] args) throws IOException, InterruptedException {

loop: 
while (true) {

  System.out.println("\n");
  System.out.println("\n");
  System.out.println(" Dimensionamento e Calculo para Sistema Fotovoltaico ");
  System.out.println("");
  System.out.println("");
  System.out.println("1. Converter - volts [CA] em watts [CC]");
  System.out.println("2. Converter - watts [CC] em volts [CA]");
  System.out.println("3. Calcular a Potencia dos Modulos");
  System.out.println("4. Calcular Geracao Semanal de Energia Solar");
  System.out.println("5. Calcular Geracao Mensal de Energia Solar");
  System.out.println("6. Calcular Geracao Anual de Energia Solar");
  System.out.println("7. Calcular e Dimensionar a Quantidade de Modulos");
  System.out.println("[8] Info");
  System.out.println("[9] Sobre");
  System.out.println("\n10. Sair");
  
  System.out.println("\nDigite sua escolha: ");

Scanner scanner = new Scanner(System.in);

int choice = scanner.nextInt();

try {
  
switch (choice) {
  case 1:
    double v2 = 10;
    System.out.println("\nDigite quantos volts quer converter em watts:  "); 
    double v1 = scanner.nextInt();
    double result = (v1 * v2); 
    System.out.println("\n");
    System.out.println("\nOs " + v1 + " volts inseridos equivalem a " + result + " watts."); 
    Scanner scanner1 = new Scanner(System.in);
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter = scanner1.nextLine();
    clear(); 
    break;
  case 2:
    double v4 = 10;
    System.out.println("\nDigite quantos watts quer converter em volts: ");  
    double v3 = scanner.nextInt();
    System.out.println("\n");
    double result1 = (v3 / v4);
    System.out.println("\nOs " + (v3) + " watts inseridos equivalem a " + (result1) + " volts.");
    Scanner scanner2 = new Scanner(System.in);
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter2 = scanner2.nextLine();
    clear(); 
    break;
  case 3:  
    System.out.println("\nDigite a potencia nominal do modulo em watts: ");  
    int v5 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nDigite a quantidade de modulos: ");  
    int v6 = scanner.nextInt();
    System.out.println("\n");
    int result2 = (v5 * v6);
    System.out.println("\nA potencia dos modulos sera de " + (result2) + " watts.");
    Scanner scanner3 = new Scanner(System.in);
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter3 = scanner3.nextLine();
    clear();
  break;
  case 4:
    float v10 = 1000; // divide por 1000 para converter para kwh
    System.out.println("\nDigite a potencia dos modulos em watts: ");   
    float v7 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nDigite a quantidade de horas por dia: ");   
    float v8 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nDigite a quantidade de dias por semana: ");   
    float v9 = scanner.nextInt();
    System.out.println("\n");
    float v11 = (v7 * v8 * v9);
    float result3 = v11 / v10;
    System.out.println("\n o resultado sera " + (result3) + " kwh/semana geracao [leste/oeste]");
    Scanner scanner4 = new Scanner(System.in);
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter4 = scanner4.nextLine();
    clear(); 
  break;
  case 5:
	float v15 = 1000; // divide por 1000 para converter para kwh
	System.out.println("\nDigite a potencia dos modulos em watts: ");   
	float v12 = scanner.nextInt();
	System.out.println("\n");
	System.out.println("\nDigite a quantidade de horas por dia: ");   
	float v13 = scanner.nextInt();
	System.out.println("\n");
	System.out.println("\nDigite a quantidade de dias por mes: ");   
	float v14 = scanner.nextInt();
	System.out.println("\n");
	float v16 = (v12 * v13 * v14);
	float result4 = v16 / v15;
	System.out.println("\n o resultado sera " + (result4) + " kwh/mes geracao [leste/oeste]");
	Scanner scanner5 = new Scanner(System.in);
	System.out.println("\nTeclar enter para retornar ao menu...\n");
	String enter5 = scanner5.nextLine();
	clear();
  break;
  case 6:
        float v20 = 1000; // divide por 1000 para converter para kwh
	System.out.println("\nDigite a potencia dos modulos em watts: ");   
	float v17 = scanner.nextInt();
	System.out.println("\n");
	System.out.println("\nDigite a quantidade de horas por dia: ");   
	float v18 = scanner.nextInt();
	System.out.println("\n");
	System.out.println("\nDigite a quantidade de dias por ano: ");   
	float v19 = scanner.nextInt();
	System.out.println("\n");
	float v21 = (v17 * v18 * v19);
	float result5 = v21 / v20;
	System.out.println("\n o resultado sera " + (result5) + " kwh/ano geracao [leste/oeste]");
	Scanner scanner6 = new Scanner(System.in);
	System.out.println("\nTeclar enter para retornar ao menu...\n");
	String enter6 = scanner6.nextLine();
	clear();	
  break;
  case 7:
	System.out.println("\nDigite a Potencia calculada do sistema (Pfv) em watts: ");   
	float v22 = scanner.nextInt();
	System.out.println("\n");
	System.out.println("\nDigite a Potencia nominal do modulo em watts: ");   
	float v23 = scanner.nextInt();
	System.out.println("\n");
	float result6 = (v22 / v23);
	System.out.println("\n A quantidade maxima de modulos para este dimensionamento eh de " + (result6) + " placas fotovoltaicas.");
	Scanner scanner7 = new Scanner(System.in);
	System.out.println("\nTeclar enter para retornar ao menu...\n");
	String enter7 = scanner7.nextLine();
	clear();
  break;
  case 8:
  clear();
  System.out.println("\n");
  System.out.println("Info");
  System.out.println("");
  System.out.println("Para converter volts em watts multiplicamos os volts por 10.");
  System.out.println("Para converter watts em volts dividimos os watts por 10.");
  System.out.println("Para calcular a potencia dos modulos fazemos a multiplicacao da potencia nominal do modulo vezes a quantidade de modulos.");
  System.out.println("Para calcular a geracao semanal utilizamos o calculo (potencia dos modulos)x(horas por dia)x(dias por semana) ");
  System.out.println("e o resultado será em watts-hora e então para obtê-lo em kwh dividimos por 1000 para converter para kwh, conforme calculado acima.");
  System.out.println("Para calcular a geracao mensal utilizamos o calculo (potencia dos modulos)x(horas por dia)x(dias por mes) ");
  System.out.println("e o resultado será em watts-hora e então para obtê-lo em kwh dividimos por 1000 para converter para kwh, conforme calculado acima.");
  System.out.println("Para calcular a geracao anual utilizamos o calculo (potencia dos modulos)x(horas por dia)x(dias por ano) ");
  System.out.println("e o resultado será em watts-hora e então para obtê-lo em kwh dividimos por 1000 para converter para kwh, conforme calculado acima.");
  System.out.println("Para calcular e dimensionar a quantidade de modulos que compoe um painel solar utilizamos o seguinte calculo: ");
  System.out.println("Potencia calculada do sistema (Pfv) em watts dividido pela Potencia nominal do modulo em watts = a Quantidade de Modulos.");
  System.out.println("Para converter 1kwh para 1wh basta fazer o calculo ex: 73kwh para wh sera 73000 wh.");
  System.out.println("");
  Scanner scanner8 = new Scanner(System.in);
  System.out.println("\nTeclar enter para retornar ao menu...\n");
  String enter8 = scanner8.nextLine();
  clear();
  break;
  case 9:
  clear();
  System.out.println("\n");
  System.out.println("Algoritmo: Dimensionamento e Calculo para Sistema Fotovoltaico");
  System.out.println("");
  System.out.println("Author: PHNO");
  System.out.println("Data Release: 29/11/2024");
  System.out.println("Versao Codigo: 0.0.0.2v");
  System.out.println("Replit: @PHNO, @PHREPLIT");
  System.out.println("E-mail: phreplit@gmail.com");
  System.out.println("");
  Scanner scanner9 = new Scanner(System.in);
  System.out.println("\nTeclar enter para retornar ao menu...\n");
  String enter9 = scanner9.nextLine();
  clear();
  break;
  case 10:
  System.out.println("\n Algoritmo Finalizado! ");
  break loop;
  default:
    Scanner scanner01 = new Scanner(System.in);
    System.out.println("\n Erro, Opcao Invalida! ");
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter01 = scanner01.nextLine();
    clear();
    }
  } catch (Exception e) {
  Scanner scanner9 = new Scanner(System.in);
  System.out.println("\nErro, falha no sistema!");
  System.out.println("\nTeclar enter para retornar ao menu...\n");
  String enter9 = scanner9.nextLine();
  clear();
  }            
}
}
public static void clear() {
     System.out.print("\033[H\033[2J"); // clear screen
     System.out.flush();
}
}
