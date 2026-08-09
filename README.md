# Exercícios de Programação em C#

Este repositório reúne exercícios práticos realizados durante meus estudos de programação, lógica e orientação a objetos.

A proposta principal foi utilizar conteúdos aprendidos em cursos de **Java**, incluindo aplicações tradicionais com **Java Swing**, e em um curso específico de **Programação Orientada a Objetos em Java**, para implementar exercícios equivalentes em **C#**.

Essa abordagem permitiu estudar não apenas a sintaxe de uma linguagem, mas também compreender quais conceitos são compartilhados entre diferentes ecossistemas e como adaptar uma solução de uma linguagem para outra.

## Objetivos

- Praticar lógica de programação;
- Reforçar estruturas condicionais e de repetição;
- Trabalhar com arrays e manipulação de dados;
- Desenvolver soluções de ordenação e transformação de textos;
- Praticar organização de pequenos sistemas;
- Estudar os fundamentos da orientação a objetos;
- Comparar conceitos de Java e C#;
- Desenvolver autonomia para aprender uma nova linguagem a partir de conhecimentos prévios.

## Organização do repositório

```text
Exercicios-1/
├── Lógica de programação/
│   ├── ArrayParImpar/
│   ├── CalculadoraCompasso2.0/
│   ├── Ordenador/
│   ├── PostoSimulator/
│   ├── Programa Perito Criminal/
│   ├── Reversor_de_palavras/
│   └── SistemaCadastro/
├── POO/
│   └── ProjetoYoutube/
├── .gitattributes
├── LICENSE
└── README.md
```

## Exercícios de lógica de programação

### ArrayParImpar

Exercício voltado à manipulação de arrays e à classificação de valores pares e ímpares.

Conceitos praticados:

- Arrays;
- Estruturas de repetição;
- Operador módulo;
- Condições lógicas;
- Entrada e processamento de dados.

### CalculadoraCompasso 2.0

Exercício de construção de uma calculadora baseada em regras de processamento e operações matemáticas.

Conceitos praticados:

- Operações aritméticas;
- Entrada de dados;
- Estruturas condicionais;
- Organização de regras de cálculo;
- Desenvolvimento incremental de uma solução.

### Ordenador

Exercício de ordenação e organização de valores.

Conceitos praticados:

- Comparação de valores;
- Algoritmos de ordenação;
- Arrays ou coleções;
- Laços de repetição;
- Manipulação de dados em memória.

### PostoSimulator

Simulação de um sistema de abastecimento em posto de combustível.

O exercício trabalha com regras de negócio baseadas no tipo de combustível, quantidade abastecida e cálculo do valor final.

Conceitos praticados:

- Simulação de situações reais;
- Regras condicionais;
- Cálculos com valores numéricos;
- Organização de entradas e saídas;
- Modelagem de um pequeno problema do mundo real.

### Programa Perito Criminal

Exercício baseado em um fluxo de perguntas e análise de respostas para chegar a uma classificação final.

Conceitos praticados:

- Estruturas condicionais;
- Combinação de respostas;
- Tomada de decisão;
- Organização de regras de classificação;
- Modelagem de um fluxo lógico.

### Reversor_de_palavras

Exercício de manipulação de strings para inverter ou reorganizar palavras.

Conceitos praticados:

- Strings;
- Percorrimento de caracteres;
- Manipulação de texto;
- Conversão e organização de dados;
- Raciocínio algorítmico.

### SistemaCadastro

Exercício de cadastro e gerenciamento de informações.

Conceitos praticados:

- Entrada de dados;
- Armazenamento em estruturas de dados;
- Consulta de informações;
- Organização de um fluxo cadastral;
- Separação entre operações de um pequeno sistema.

## Exercício de orientação a objetos

### ProjetoYoutube

O diretório `POO/ProjetoYoutube` contém uma implementação em C# baseada em um exercício de orientação a objetos estudado originalmente em Java.

O projeto simula uma estrutura de vídeos, usuários e visualizações, utilizando classes que representam elementos de uma plataforma de vídeos.

As principais classes são:

- `Pessoa.cs`: classe-base para representação de pessoas;
- `Gafanhoto.cs`: especialização de pessoa, representando um usuário;
- `Video.cs`: representação de um vídeo;
- `Visualizacao.cs`: relacionamento entre um usuário e um vídeo;
- `AcoesVideo.cs`: contrato de operações relacionadas ao vídeo;
- `Program.cs`: ponto de entrada para execução dos testes.

O exercício trabalha conceitos importantes de orientação a objetos, como:

- Classes e objetos;
- Herança;
- Encapsulamento;
- Polimorfismo;
- Abstração;
- Interfaces;
- Sobrescrita de métodos;
- Relacionamento entre classes;
- Construtores e propriedades.

## Java como base e C# como adaptação

Os cursos utilizados como referência apresentavam os conceitos em Java. Parte dos exercícios estava associada ao aprendizado tradicional da linguagem, incluindo a criação de interfaces gráficas com Swing, enquanto outro curso era focado especificamente em orientação a objetos.

Em vez de apenas reproduzir os exemplos em Java, este repositório registra uma etapa posterior do aprendizado: a implementação de alguns exercícios em C#.

A adaptação exigiu compreender quais elementos pertenciam ao conceito de programação e quais eram apenas características específicas da linguagem Java. Por exemplo:

| Conceito | Java | C# |
|---|---|---|
| Classe | `class` | `class` |
| Herança | `extends` | `:` |
| Interface | `implements` | `:` |
| Método principal | `public static void main` | `static void Main` |
| Propriedades | Getters e setters ou campos | Properties com `get` e `set` |
| Projeto | Estrutura Java/IDE | `.csproj` e `.sln` |

O objetivo não foi fazer uma tradução literal de código, mas reconstruir as soluções em C# preservando a lógica e os conceitos estudados.

## Tecnologias e ferramentas

- C#;
- .NET;
- Visual Studio ou ambiente compatível;
- Arquivos `.csproj`;
- Soluções `.sln`;
- Programação estruturada;
- Programação orientada a objetos;
- Git e GitHub.

## Como executar

### Pré-requisitos

Instale o SDK do .NET em sua máquina:

[Download do .NET](https://dotnet.microsoft.com/download)

Verifique a instalação:

```bash
dotnet --version
```

### Executar um exercício de lógica

Entre no diretório de um dos exercícios que possui uma solução `.sln`. Por exemplo:

```bash
cd "Lógica de programação/ArrayParImpar"
dotnet run
```

Dependendo da estrutura interna do projeto, também pode ser necessário entrar no diretório que contém o arquivo `.csproj`:

```bash
cd "Lógica de programação/ArrayParImImpar/ArrayParImpar"
dotnet run
```

Confira o nome exato das pastas caso o caminho varie em sua instalação.

### Executar o projeto de POO

```bash
cd POO/ProjetoYoutube/ProjetoYoutube
dotnet run
```

Para abrir a solução em uma IDE compatível:

```bash
start ../ProjetoYoutube.sln
```

No Linux, pode-se utilizar uma IDE compatível com .NET ou executar diretamente pelo terminal com `dotnet run`.

## Aprendizados

Este repositório representa uma etapa importante de consolidação dos fundamentos de programação.

A realização dos exercícios permitiu praticar:

- Como decompor problemas em etapas menores;
- Como transformar regras em algoritmos;
- Como escolher estruturas de controle adequadas;
- Como manipular arrays, strings e valores numéricos;
- Como representar entidades por meio de classes;
- Como reutilizar comportamentos usando herança;
- Como definir contratos com interfaces;
- Como adaptar conceitos entre Java e C#;
- Como aprender uma linguagem nova a partir de conhecimentos anteriores.

A experiência também mostrou que aprender uma nova linguagem não significa começar do zero. Os conceitos de lógica, abstração, estruturas de dados e orientação a objetos são transferíveis, enquanto a sintaxe e as ferramentas podem ser estudadas progressivamente.

## Relação com Java Swing

Os conteúdos de Java estudados incluíram aplicações tradicionais e interfaces gráficas com Swing. Embora os exercícios deste repositório estejam concentrados principalmente em implementações de lógica e orientação a objetos em C#, o conhecimento adquirido com Java Swing contribuiu para compreender:

- Separação entre interface e lógica;
- Organização de eventos e ações;
- Estruturação de aplicações;
- Fluxo de entrada e saída de dados;
- Necessidade de conectar componentes visuais a comportamentos do programa.

Esse conhecimento também serve como base para evoluir futuramente os exercícios para interfaces gráficas em C#, como Windows Forms, WPF ou outras tecnologias de aplicação desktop.

## Próximas melhorias possíveis

- Adicionar README específico para cada exercício;
- Criar testes automatizados;
- Padronizar os nomes das pastas e projetos;
- Adicionar interfaces gráficas aos exercícios selecionados;
- Criar uma solução `.sln` geral para organizar os projetos;
- Migrar alguns exercícios para uma aplicação web;
- Adicionar validações mais robustas para entradas inválidas;
- Melhorar a separação entre regras de negócio e interface;
- Comparar formalmente cada implementação entre Java e C#.

## Autor

Desenvolvido por **Bruno Ozen** como parte de um processo prático de aprendizagem em programação, Java, C#, lógica e orientação a objetos.

- GitHub: [Bruno-Ozen](https://github.com/Bruno-Ozen)
- Repositório: [Exercicios-1](https://github.com/Bruno-Ozen/Exercicios-1)

## Licença

Este projeto contém um arquivo `LICENSE` no repositório. Consulte-o para obter os termos de utilização e distribuição do código.
