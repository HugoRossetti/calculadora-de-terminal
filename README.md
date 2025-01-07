# Calculadora de Terminal em Csharp (C#)

## Descrição

Este projeto consiste em uma **calculadora de terminal** desenvolvida com a linguagem **C#**. A aplicação permite realizar operações matemáticas básicas, como adição, subtração, multiplicação e divisão, de forma simples e eficiente diretamente pelo terminal.

## Funcionalidades

- Realizar **adição** de dois números.
- Realizar **subtração** de dois números.
- Realizar **divisão** de dois números.
- Realizar **multiplicação** de dois números.
- Realizar **potenciação** de dois números.
- Realizar **seno** de um ângulo.
- Realizar **coseno** de um ângulo.
- Realizar **tangente** de um ângulo.
- Realizar **raiz quadrada** de um número.
- Interface simples e intuitiva diretamente no terminal.

## Estrutura do Projeto

A estrutura do projeto está organizada da seguinte forma:

```
calculadora-de-terminal/
├── bin/                # Arquivos binários gerados pelo build
├── obj/                # Arquivos temporários gerados pelo build
├── Models/             # Classes auxiliares ou modelos (se aplicável)
├── Program.cs          # Arquivo principal com o código da calculadora
├── calculadora-de-terminal.sln  # Arquivo de solução do Visual Studio
```

## Como Executar

### Requisitos

- **.NET SDK** instalado (versão 6.0 ou superior).
- Um terminal ou prompt de comando.

### Passos para executar

1. Clone o repositório:

   ```bash
   git clone https://github.com/HugoRossetti/calculadora-de-terminal.git
   ```

2. Navegue até o diretório do projeto:

   ```bash
   cd calculadora-de-terminal
   ```

3. Execute o programa:

   ```bash
   dotnet run
   ```

4. Siga as instruções exibidas no terminal para realizar os cálculos.

## Exemplos de Uso

### Entrada

```
Escolha a operação desejada:
1 - Soma
2 - Subtração
3 - Multiplicação
4 - Potenciação
5 - Seno
6 - Coseno
7 - Tangente
8 - Raiz Quadrada

opção: 1

Digite o primeiro número: 10
Digite o segundo número: 20
```

### Saída

```
Resultado: 30
```

## Melhorias Futuras

- Implementar **validação de entrada** para evitar erros ao inserir dados inválidos.
- Criar uma **interface gráfica** simples para complementar a versão de terminal.

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests no repositório.

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).

---

Feito com ❤️ por Hugo Rossetti
