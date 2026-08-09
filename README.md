# Exercícios de Programação em C#

Este repositório reúne exercícios práticos realizados durante meus estudos de programação, lógica e orientação a objetos.

A proposta foi estudar cursos de **Java**, incluindo um curso básico com introdução a interfaces gráficas usando **Swing**, e um curso específico de **Programação Orientada a Objetos em Java**. A partir desses conteúdos, alguns exercícios foram reconstruídos em **C#**, utilizando o ecossistema **.NET**.

Essa prática permitiu comparar duas linguagens com conceitos semelhantes, compreender o que é específico de cada sintaxe e fortalecer a capacidade de transferir conhecimentos de uma tecnologia para outra.

## Cursos de referência

### Curso de Java para Iniciantes

[**Curso de Java para Iniciantes — Grátis, Completo e com Certificado**](https://www.youtube.com/watch?v=sTX0UEplF54&list=PLHz_AreHm4dkI2ZdjTwZA4mPMxWTfNSpR)

Curso ministrado por Gustavo Guanabara, do Curso em Vídeo. A formação apresenta a base da linguagem Java e percorre temas como história e funcionamento do Java, instalação do JDK, primeiros programas, variáveis, tipos de dados, operadores, estruturas condicionais e de repetição, métodos, arrays, strings e desenvolvimento de aplicações tradicionais.

O curso também apresenta conceitos relacionados à criação de interfaces gráficas, incluindo **Swing** e uma introdução ao **JavaFX**. Embora os exemplos originais sejam feitos em Java, os exercícios deste repositório utilizam os mesmos fundamentos de lógica em C# e .NET.

A relação prática foi feita da seguinte forma:

| Conteúdo estudado em Java | Aplicação neste repositório em C#/.NET |
|---|---|
| Variáveis e tipos de dados | Declarações e manipulação de dados em C# |
| Condicionais | Regras de decisão em simuladores e sistemas |
| Laços de repetição | Percorrimento de arrays e processamento de informações |
| Métodos | Organização de operações reutilizáveis |
| Arrays e strings | Exercícios `ArrayParImpar` e `Reversor_de_palavras` |
| Entrada e saída | Interação com o usuário nos exercícios de console |
| Regras de negócio | `PostoSimulator`, `SistemaCadastro` e `Programa Perito Criminal` |
| Interfaces gráficas como conceito | Base para compreender a separação entre interface e lógica |

### Curso de POO Java

[**Curso de POO Java — Programação Orientada a Objetos**](https://www.youtube.com/watch?v=KlIL63MeyMY&list=PLHz_AreHm4dkqe2aR0tQK74m8SFe-aGsY)

Curso ministrado por Gustavo Guanabara, do Curso em Vídeo. O conteúdo apresenta os fundamentos da Programação Orientada a Objetos por meio de classes, objetos, atributos, métodos, construtores, encapsulamento, herança, polimorfismo, abstração e interfaces.

O exercício `POO/ProjetoYoutube` foi desenvolvido em C# como uma aplicação prática desses conceitos. A ideia original estudada em Java foi adaptada para o modelo de projetos do .NET, mantendo o objetivo conceitual, mas utilizando a sintaxe, as propriedades e as estruturas próprias do C#.

| Conceito de POO estudado em Java | Implementação em C#/.NET |
|---|---|
| Classes e objetos | `Pessoa`, `Gafanhoto`, `Video` e `Visualizacao` |
| Herança | Especialização de `Pessoa` em `Gafanhoto` |
| Encapsulamento | Campos, propriedades e métodos das classes |
| Polimorfismo | Comportamentos redefinidos nas classes derivadas |
| Interfaces | `AcoesVideo` como contrato de operações |
| Associação entre classes | Usuários, vídeos e visualizações |
| Métodos e construtores | Inicialização e comportamento dos objetos |
| Projeto Java/IDE | Solução `.sln` e projeto `.csproj` no .NET |

## Objetivos

- Praticar lógica de programação;
- Reforçar estruturas condicionais e de repetição;
- Trabalhar com arrays e manipulação de dados;
- Desenvolver soluções de ordenação e transformação de textos;
- Praticar a organização de pequenos sistemas;
- Estudar os fundamentos da orientação a objetos;
- Comparar Java e C#;
- Aprender a utilizar o .NET para executar projetos C#;
- Desenvolver autonomia para reconstruir soluções em outra linguagem.

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

Exercício de manipulação de arrays e classificação de valores pares e ímpares. Trabalha com arrays, estruturas de repetição, operador módulo, condições lógicas e processamento de dados.

### CalculadoraCompasso 2.0

Exercício de construção de uma calculadora baseada em operações matemáticas e regras de processamento. Pratica entrada de dados, cálculos e estruturas condicionais.

### Ordenador

Exercício voltado à comparação e ordenação de valores, praticando arrays ou coleções, laços de repetição e organização de dados em memória.

### PostoSimulator

Simulação de um posto de combustível, com regras baseadas no tipo de combustível, quantidade abastecida e valor final. O exercício aproxima a lógica de programação de uma situação do mundo real.

### Programa Perito Criminal

Sistema baseado em perguntas e respostas que produz uma classificação final. Pratica combinação de condições, tomada de decisão e modelagem de regras.

### Reversor_de_palavras

Exercício de manipulação de strings para inverter ou reorganizar palavras, trabalhando com caracteres, textos e raciocínio algorítmico.

### SistemaCadastro

Exercício de cadastro e gerenciamento de informações, praticando entrada de dados, armazenamento, consultas e organização de operações de um pequeno sistema.

## Projeto de orientação a objetos

### ProjetoYoutube

O diretório `POO/ProjetoYoutube` contém uma aplicação em C# que simula uma estrutura de vídeos, usuários e visualizações.

Principais classes:

- `Pessoa.cs`: classe-base para representação de pessoas;
- `Gafanhoto.cs`: especialização de pessoa, representando um usuário;
- `Video.cs`: representação de um vídeo;
- `Visualizacao.cs`: relacionamento entre um usuário e um vídeo;
- `AcoesVideo.cs`: interface com operações relacionadas ao vídeo;
- `Program.cs`: ponto de entrada para execução dos testes.

O projeto utiliza classes, objetos, herança, encapsulamento, polimorfismo, abstração, interfaces, propriedades, construtores e relacionamentos entre entidades.

## Java como base e C# como adaptação

Os cursos foram acompanhados em Java, mas os exercícios deste repositório foram implementados em C#. O objetivo não foi realizar uma tradução literal dos exemplos, mas compreender a lógica e reconstruir as soluções utilizando as ferramentas da plataforma .NET.

A adaptação envolveu diferenças como:

| Elemento | Java | C#/.NET |
|---|---|---|
| Herança | `extends` | `:` |
| Implementação de interface | `implements` | `:` |
| Método principal | `public static void main` | `static void Main` |
| Propriedades | Getters e setters tradicionais | Properties com `get` e `set` |
| Projeto | Estrutura Java e IDE | Arquivos `.csproj` e `.sln` |
| Execução | JDK e ferramentas Java | SDK do .NET e `dotnet run` |
| Interface gráfica | Swing ou JavaFX | Possível evolução para Windows Forms ou WPF |

Essa comparação ajudou a separar conceitos fundamentais — como classes, métodos, herança e polimorfismo — das características específicas de uma linguagem.

## Tecnologias e ferramentas

- C#;
- .NET SDK;
- Projetos `.csproj`;
- Soluções `.sln`;
- Programação estruturada;
- Programação orientada a objetos;
- Git e GitHub;
- Java e Java Swing como base de estudos.

## Como executar

### Pré-requisitos

Instale o SDK do .NET:

[Download do .NET](https://dotnet.microsoft.com/download)

Verifique a instalação:

```bash
dotnet --version
```

### Executar o projeto de POO

```bash
cd POO/ProjetoYoutube/ProjetoYoutube
dotnet run
```

Para abrir a solução em uma IDE compatível com .NET, utilize o arquivo:

```text
POO/ProjetoYoutube/ProjetoYoutube.sln
```

### Executar um exercício de lógica

Entre na pasta que contém o projeto `.csproj` e execute:

```bash
dotnet run
```

Por exemplo:

```bash
cd "Lógica de programação/ArrayParImpar/ArrayParImpar"
dotnet run
```

Os caminhos podem ser ajustados conforme a estrutura local de cada exercício.

## Aprendizados

Este repositório representa uma etapa prática de consolidação dos fundamentos de programação.

Os exercícios permitiram praticar:

- Decomposição de problemas em etapas menores;
- Transformação de regras em algoritmos;
- Escolha de estruturas de controle;
- Manipulação de arrays, strings e valores numéricos;
- Representação de entidades por meio de classes;
- Reutilização de comportamentos com herança;
- Definição de contratos com interfaces;
- Adaptação de conceitos entre Java e C#;
- Utilização do SDK e das ferramentas do .NET;
- Aprendizado progressivo de uma nova linguagem.

A experiência mostrou que aprender uma linguagem nova não significa começar do zero. Conceitos como lógica, abstração, estruturas de dados e orientação a objetos podem ser transferidos, enquanto a sintaxe e as ferramentas são estudadas de forma incremental.

## Relação com Java Swing

O curso básico de Java também apresentou aplicações tradicionais e interfaces gráficas com Swing. Embora este repositório esteja concentrado em exercícios de console e em um projeto de POO em C#, o contato com Swing ajudou a compreender:

- A separação entre interface e lógica;
- A associação entre ações do usuário e comportamentos do programa;
- A organização de aplicações em componentes;
- O fluxo de entrada, processamento e saída;
- A importância de manter as regras de negócio organizadas.

Esse conhecimento pode ser utilizado futuramente para evoluir os exercícios para interfaces gráficas em C#, como Windows Forms ou WPF, ou para aplicações web baseadas em .NET.

## Possíveis melhorias

- Adicionar um README específico para cada exercício;
- Criar testes automatizados;
- Padronizar nomes de pastas e projetos;
- Adicionar interfaces gráficas a exercícios selecionados;
- Criar uma solução geral para organizar os projetos;
- Implementar validações para entradas inválidas;
- Separar melhor regras de negócio e interface;
- Criar versões web utilizando ASP.NET Core;
- Documentar as diferenças entre as versões Java e C#.

## Autor

Desenvolvido por **Bruno Ozen** como parte de um processo prático de aprendizagem em programação, Java, C#, .NET, lógica e orientação a objetos.

- GitHub: [Bruno-Ozen](https://github.com/Bruno-Ozen)
- Repositório: [Exercicios-1](https://github.com/Bruno-Ozen/Exercicios-1)
