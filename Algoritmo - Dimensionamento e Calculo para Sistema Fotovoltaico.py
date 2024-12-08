
'''  Author: PHNO - Tecnologo | Pos-Graduado em Energia Solar Fotovoltaica
     Data Release: 29/11/2024
     Versao Codigo: 0.0.0.2v
     Replit: @PHNO, @PHREPLIT
     E-mail: phreplit@gmail.com  '''

'''  Algoritmo: Dimensionamento e Calculo para Sistema Fotovoltaico na area de Energia Solar Fotovoltaica, 
     desenvolvido para estudantes e profissionais de engenharia eletrica e areas correlatas, como energias renovaveis.  '''

import os # import lib - os clear
import sys
import json

def reset_text():
    os.system('cls' if os.name=='nt' else 'clear')

op = 0 
while op != -1:
  print('')
  print(' Dimensionamento e Calculo para Sistema Fotovoltaico ')
  print('')
  print('')
  print('1. Converter - volts [CA] em watts [CC]')
  print('2. Converter - watts [CC] em volts [CA]')
  print('3. Calcular a Potencia dos Modulos')
  print('4. Calcular Geracao Semanal de Energia Solar')
  print('5. Calcular Geracao Mensal de Energia Solar')
  print('6. Calcular Geracao Anual de Energia Solar')
  print('7. Calcular e Dimensionar a Quantidade de Modulos')
  print('[8] Info')
  print('[9] Sobre')
  print('10. Sair')
  print('')
  op = int(input('Digite sua escolha: '))
  if op == 1:
   v2 = float(10)
   print('')
   v1 = float(input('Digite quantos volts quer converter em watts: '))
   print('')
   result = float(v1 * v2)
   print('')
   print('Os {} volts inseridos equivalem a {} watts.'.format(v1,result))
   print('')
   print('Teclar enter para retornar ao menu...')
   a1 = str(input(''))
   reset_text()
  elif op == 2:
   v4 = float(10)
   print('')
   v3 = float(input('Digite quantos watts quer converter em volts: '))
   print('')
   result2 = float(v3 / v4)
   print('')
   print('Os {} watts inseridos equivalem a {} volts.'.format(v3,result2))
   print('')
   print('Teclar enter para retornar ao menu...')
   a2 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 3:
   print('')
   v5 = int(input('Digite a potencia nominal do modulo em watts: '))
   print('')
   v6 = int(input('Digite a quantidade de modulos: '))
   print('')
   result3 = v5 * v6
   print('')
   print('A potencia dos modulos sera de {} watts.'.format(result3))
   print('')
   print('Teclar enter para retornar ao menu...')
   a3 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 4:
   v11 = float(1000)
   print('')
   v7 = float(input('Digite a potencia dos modulos em watts: '))
   print('')
   v8 = float(input('Digite a quantidade de horas por dia: '))
   print('')
   v9 = float(input('Digite a quantidade de dias por semana: '))
   print('')
   v10 = float(v7 * v8 * v9)
   result4 = float(v10 / v11)
   print('')
   print('o resultado sera {} kwh/semana geracao [leste/oeste].'.format(result4))
   print('')
   print('Teclar enter para retornar ao menu...')
   a4 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 5:
   v16 = float(1000)
   print('')
   v12 = float(input('Digite a potencia dos modulos em watts: '))
   print('')
   v13 = float(input('Digite a quantidade de horas por dia: '))
   print('')
   v14 = float(input('Digite a quantidade de dias por mes: '))
   print('')
   v15 = float(v12 * v13 * v14)
   result5 = float(v15 / v16)
   print('')
   print('o resultado sera {} kwh/mes geracao [leste/oeste].'.format(result5))
   print('')
   print('Teclar enter para retornar ao menu...')
   a5 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 6:
   v21 = float(1000)
   print('')
   v17 = float(input('Digite a potencia dos modulos em watts: '))
   print('')
   v18 = float(input('Digite a quantidade de horas por dia: '))
   print('')
   v19 = float(input('Digite a quantidade de dias por ano: '))
   print('')
   v20 = float(v17 * v18 * v19)
   result6 = float(v20 / v21)
   print('')
   print('o resultado sera {} kwh/ano geracao [leste/oeste].'.format(result6))
   print('')
   print('Teclar enter para retornar ao menu...')
   a6 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 7:
   print('')
   v22 = float(input('Digite a Potencia calculada do sistema (Pfv) em watts: '))
   print('')
   v23 = float(input('Digite a Potencia nominal do modulo em watts:  '))
   print('')
   result7 = int(v22 / v23) # int e não float porque o resultado será impresso com mais precisão.
   print('')
   print('A quantidade maxima de modulos para este dimensionamento eh de {} placas fotovoltaicas.'.format(result7)) # o resultado sera atualizado no futuro.
   print('')
   print('Teclar enter para retornar ao menu...')
   a7 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 8:
   reset_text()
   print('')
   print('Info')
   print('')
   print('Para converter volts em watts multiplicamos os volts por 10.')
   print('Para converter watts em volts dividimos os watts por 10.')
   print('Para calcular a potencia dos modulos fazemos a multiplicacao da potencia nominal do modulo vezes a quantidade de modulos.')
   print('Para calcular a geracao semanal utilizamos o calculo (potencia dos modulos)x(horas por dia)x(dias por semana) ')
   print('e o resultado sera em watts-hora e entao para obte-lo em kwh dividimos por 1000 para converter para kwh, conforme calculado acima.')
   print('Para calcular a geracao mensal utilizamos o calculo (potencia dos modulos)x(horas por dia)x(dias por mes) ')
   print('e o resultado sera em watts-hora e entao para obte-lo em kwh dividimos por 1000 para converter para kwh, conforme calculado acima.')
   print('Para calcular a geracao anual utilizamos o calculo (potencia dos modulos)x(horas por dia)x(dias por ano) ')
   print('e o resultado sera em watts-hora e entao para obte-lo em kwh dividimos por 1000 para converter para kwh, conforme calculado acima.')
   print('Para calcular e dimensionar a quantidade de modulos que compoe um painel solar utilizamos o seguinte calculo: ')
   print('Potencia calculada do sistema (Pfv) em watts dividido pela Potencia nominal do modulo em watts = a Quantidade de Modulos.')
   print('Para converter 1kwh para 1wh basta fazer o calculo ex: 73kwh para wh sera 73000 wh.')
   print('')
   print('Teclar enter para retornar ao menu...')
   a5 = str(input(''))
   reset_text()
  elif op == 9:
   reset_text()
   print('')
   print('Algoritmo: Dimensionamento e Calculo para Sistema Fotovoltaico')
   print('')
   print('Author: PHNO')
   print('Data Release: 29/11/2024')
   print('Versao Codigo: 0.0.0.2v')
   print('Replit: @PHNO, @PHREPLIT')
   print('E-mail: phreplit@gmail.com')
   print('')
   print('Teclar enter para retornar ao menu...')
   a5 = str(input(''))
   reset_text()
  elif op == 10:
   print('')
   print('Algoritmo Finalizado!')
   print('')
   break
  else: 
   print('')
   print('Erro. escolha novamente!')
   print('')
   print('Teclar enter para retornar ao menu...')
   a6 = str(input(''))
   reset_text()
